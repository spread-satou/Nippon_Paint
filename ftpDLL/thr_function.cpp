#include "pch.h"
#include "thr_function.h"
//#include <windows.h>          // これをincludeすると、winbase.h等でコンパイルエラーとなる。
#include <stdio.h>
#include <sstream>
#include <iostream>

#include "ecode.h"
#include "def_dbg.h"
#include "ftplog.h"
#include "csInterface.h"
#include "params.h"

#include "thr_semaphore.h"
#include "ftpsocket.h"
#include "ftpsocket_tran.h"
#include "ftplog.h"
#include "util_strtok.h"
#include "util_mktime.h"
#include "util_findfile.h"
#include "util_file.h"

using namespace utility;

extern csInterface  csIfObj;                            // C#/C++共有パラメータ
extern params       sharedObj;
extern ftplog*      pSharedLog;
extern int          gLogCtrl;                           // コンソールアウトあり

extern int sem_init(int siSEMID, LONG lInitialCount, LONG lMaximumCount);
extern int sem_wait(int siSEMID, DWORD dwMaxms, DWORD dwMilliseconds);
extern int sem_post(int siSEMID);

//! SND/ORDERファイル一覧
static std::vector<std::string> vnList;

//! プロトタイプ宣言
void nlst_receiver(void* pArguments);
void retr_receiver(void* pArguments);
void stor_ans_sender(void* pArguments);
void stor_nty_sender(void* pArguments);

/*!
 * @file        thr_function.cpp
 * @fn          nlst_receiver(void* pArguments)
 * @brief       NLSTレスポンス受信
 * @details     フォアグラウンドとセマフォで同期をとりながら、データ受信を行う。
 *              セマフォ獲得、解放タイミングはシビアなので、変更時には
 *              FTPサーバー、フォアグラウンド、バックグラウンド、三者まとめて検討が必要(三位一体, Trinity)。
 * @return      void
 * @param[in]	pArguments      ftpsocket_tran オブジェクトポインタ
 * @date        2022/3/28
 * @note        C++メソッドをcallするためのCスタイル関数(LINK対策)
 */
void nlst_receiver(void* pArguments)
{
    int                 ret_socket;
    ftpsocket*          ptrns = (ftpsocket*)pArguments; // ptrnsは ftpsocket_tran オブジェクト
    ADDRINFOA           ai_tran;                        // the getaddrinfo function(input引数) to hold host address information.
    const char*         pai_tran[2] = {"", ""};
    unsigned short      u16port;
    std::stringstream   ss_port;
    std::string         str_port;
    std::string         str_msg;
    int                 zeroflg = 1;                    // 0バイト受信許可

    LOGTRACE(ECTRL::eYE, ERANK::eDBG, ENAME::eBG_NLST, "nlst_receiver()>>>\n");

    ftpsocket::addrinfo(&ai_tran, SOCPORT_TRAN);
    ss_port << ptrns->mu16PORT;
    ss_port >> str_port;
    pai_tran[1] = str_port.c_str();

    // socket()～release()をサブルーチンにして、共通化するとsem_post()が見えにくくなるので、サブルーチンにはしない。
    /*
     * ■ socket()～listen()
     */
    ret_socket = ptrns->initialize(ai_tran, (void*)&pai_tran[0]);
    ::sem_post(ESEMID::eFGBG);                          // socket()～listen()まで完了通知

    if (ret_socket < 0) {
        goto EXIT_FUNCTION;                             //return;
    }

    /*
     * ■ accept(), 接続待ち
     */
    LOGTRACE(ECTRL::eYE, ERANK::eDBG, ENAME::eBG_NLST, "sem_post()->connect()\n");
    ret_socket = ptrns->connect(SOCTRAN::eLISTEN);
    ::sem_post(ESEMID::eFGBG);                          // accept()完了通知

    if (ret_socket < 0) {
        goto EXIT_FUNCTION;                             //return;
    }

    // listenソケットは不要
    // ここで ::shutdown()しても失敗する。マニュアルと違う。
    //ptrns->disconnect(SOCTRAN::eLISTEN);
    ptrns->release(SOCTRAN::eLISTEN);

    /*
     * ■ データ受信
     */
    LOGTRACE(ECTRL::eYE, ERANK::eDBG, ENAME::eBG_NLST, "sem_post()->receiver()\n");
    str_msg.clear();
    ret_socket = ((ftpsocket_tran*)ptrns)->receiver(FTP_WAITTIME, zeroflg, str_msg);
    if (ret_socket < 0) {
        goto EXIT_FUNCTION;                             //return;
    }
    LOGTRACE(ECTRL::eYE, ERANK::eDBG, ENAME::eBG_NLST, "%s\n", str_msg.c_str());

EXIT_FUNCTION:
    // 設計当初、PORT番号更新は通信成功時のみ。
    // bind()に失敗した場合、失敗したPORT番号で再接続するため、失敗と再接続を繰り返していた。

    // PORT番号は必ず、更新する。
    u16port = ptrns->mu16PORT;
    u16port++;
    if (u16port == 0) {                                 // オーバーフローしたなら、
        u16port = SOCPORT_LOCAL;                        // プライベートポート番号の初期値をセット
    }
    ptrns->mu16PORT = u16port;

    if (ret_socket < 0) {
        // 失敗するはず => ptrns->disconnect(SOCTRAN::eLISTEN);
        ptrns->release(SOCTRAN::eLISTEN);

        sharedObj.sync_wait();                          // セマフォ獲得待ち
        sharedObj.mOrder.setcmd(ord_buffer::eCMD::eFAILED);
        sharedObj.sync_post();                          // セマフォ獲得解放

        ::sem_post(ESEMID::eFGBG);                      // thread exit通知
        return;
    }

    /*
     * ■ あと処理   (次のコマンドはRETR/NLST)
     */
    size_t              ret_util;
    std::string         str_new = "";                   // 最新ファイル名

    std::vector<std::string>            vstrnlst;       // ファイル一覧
    std::vector<std::string>::iterator  iter;
    std::string         str_yyyymmdd;
    size_t              leng;
    int                 found_files = 0;

    // ファイルリスト初期化(0件)
    vnList.clear();

    // データフロー
    //  受信メッセージ => ファイル一覧 => 最新ファイル名
    //  str_msg => vstrnlst => str_new

    str_new.clear();
    leng = str_msg.size();                              // 受信メッセージ
    if (leng == 0) {
        ;// 0byte受信時はなにもできない(ファイル一覧取得できず)
    }
    else {
        // 1行に複数のファイル名が連なっているので、配列に分割する
        ret_util = strtok::splitter(vstrnlst, str_msg.c_str(), str_msg.size(), "\x0d\x0a");

        // ファイル名文字列は固定長 ORD_FNAMEEXT_SIZE
        // サーバーはファイル名にCRLFもつけて返してくる
        for (iter = vstrnlst.begin(); iter != vstrnlst.end(); iter++) {
            if ((*iter).size() >= ORD_FNAMEEXT_SIZE) {  // 終端にCRLFがついていれば、 ORD_FNAMEEXT_SIZE 以上のレングス
                vnList.push_back(*iter);                // 規定されたファイル限定
                found_files++;
            }
        }                                               // 取得したファイル名分、ループ
    }   // if (leng == 0)

    // ■ログファイル
    //  "ログファイル名"は書き換えられることを想定していないため、排他不要
    std::string         str_fullpath_logf;
    str_fullpath_logf = sharedObj.mstrFullPath[EPRM_PATH::eFTPLOG];

    pSharedLog->sync_wait();
    if (found_files > 0) {                              // 見つかったファイル数
        // "Found %d order files to be processed",
        pSharedLog->mvElement[EMSG::eNLST_FOUND_ORD]->writer(&gLogCtrl, str_fullpath_logf.c_str(), found_files);
    }
    else {
        // "No files in the orders directory",
        pSharedLog->mvElement[EMSG::eNLST_NOFILES_ORDDIR]->writer(&gLogCtrl, str_fullpath_logf.c_str());
    }
    pSharedLog->sync_post();

    // ■ ダウンロード
    sharedObj.sync_wait();                              // セマフォ獲得待ち
    if (vnList.size() > 0) {
        // 常に要素0にダウンロードするファイル名がセットされている
        // (ダウンロード完了後、vnList[0]をerase()する)
        str_new = vnList[0];
        sharedObj.mOrder.setfn(EFOLDER::eORD, str_new);
        sharedObj.mOrder.setcmd(ord_buffer::eCMD::eDOWNLOAD);
    }
    else {
#ifdef FTP_ENDLESS
        LOGTRACE(ECTRL::eYE, ERANK::eDBG, ENAME::eBG_NLST, "setcmd(ord_buffer::eCMD::eNLST)");
        sharedObj.mOrder.setcmd(ord_buffer::eCMD::eNLST);
#else
        LOGTRACE(ECTRL::eYE, ERANK::eDBG, ENAME::eBG_NLST, "setcmd(ord_buffer::eCMD::eABORT)");
        sharedObj.mOrder.setcmd(ord_buffer::eCMD::eABORT);
#endif  /* #ifdef FTP_ENDLESS */
    }
    sharedObj.sync_post();                              // セマフォ獲得解放

    // ■ フォアグラウンド通知
    // receiver()実行時にフォアグラウンドにディスパッチする場合としない場合がある。
    // ディスパッチしない場合、フォアグラウントでsem_wait()できないため、
    // ↓ sem_post()をcallすると、ERROR_TOO_MANY_POSTS(298)が返る。
    // 致命的エラーではないので(itron,linuxなら、無視)、Windowsは一般ユーザーが操作する
    // OSなので、できるだけエラーは救っておきたいので、ディスパッチする機会を与えるため、
    // Sleep(1)をcall
    ::Sleep(1);
    ::sem_post(ESEMID::eFGBG);                          // thread exit通知
    LOGTRACE(ECTRL::eYE, ERANK::eDBG, ENAME::eBG_NLST, "nlst_receiver()<<<\n");
    return;                                             // 正常終了
}

/*!
 * @file        thr_function.cpp
 * @fn          retr_receiver(void* pArguments)
 * @brief       RETRレスポンス受信(download)
 * @details     フォアグラウンドとセマフォで同期をとりながら、データ受信を行う。
 *              セマフォ獲得、解放タイミングはシビアなので、変更時には
 *              FTPサーバー、フォアグラウンド、バックグラウンド、三者まとめて検討が必要(三位一体, Trinity)。
 * @return      void
 * @param[in]	pArguments      ftpsocket_tran オブジェクトポインタ
 * @date        2022/3/28
 * @note        C++メソッドをcallするためのCスタイル関数(LINK対策)
 */
void retr_receiver(void* pArguments)
{
    int                 ret_socket;
    ftpsocket*          ptrns = (ftpsocket*)pArguments; // ptrnsは ftpsocket_tran オブジェクト
    ADDRINFOA           ai_tran;                        // the getaddrinfo function(input引数) to hold host address information.
    const char*         pai_tran[2] = {"", ""};
    unsigned short      u16port;
    std::stringstream   ss_port;
    std::string         str_port;
    std::string         str_dl_msg;                     // downloadメッセージ
    std::string         str_dbg = "\x0d\x0a";
    int                 zeroflg = 0;                    // 0バイト受信禁止

    LOGTRACE(ECTRL::eYE, ERANK::eDBG, ENAME::eBG_RETR, "retr_receiver()>>>\n");

    ftpsocket::addrinfo(&ai_tran, SOCPORT_TRAN);
    ss_port << ptrns->mu16PORT;
    ss_port >> str_port;
    pai_tran[1] = str_port.c_str();

    // socket()～release()をサブルーチンにして、共通化するとsem_post()が見えにくくなるので、サブルーチンにはしない。
    /*
     * ■ socket()～listen()
     */
    ret_socket = ptrns->initialize(ai_tran, (void*)&pai_tran[0]);
    ::sem_post(ESEMID::eFGBG);                          // socket()～listen()まで完了通知

    if (ret_socket < 0) {
        goto EXIT_FUNCTION;                             //return;
    }

    /*
     * ■ accept(), 接続待ち
     */
    LOGTRACE(ECTRL::eYE, ERANK::eDBG, ENAME::eBG_RETR, "sem_post()->connect()\n");

    ret_socket = ptrns->connect(SOCTRAN::eLISTEN);      // listen()に使用したソケットで接続
    ::sem_post(ESEMID::eFGBG);                          // accept()完了通知

    if (ret_socket < 0) {
        goto EXIT_FUNCTION;                             //return;
    }

    // listenソケットは不要
    // ここで ::shutdown()しても失敗する。マニュアルと違う。
    //ptrns->disconnect(SOCTRAN::eLISTEN);                // listenソケットは不要
    ptrns->release(SOCTRAN::eLISTEN);

    /*
     * ■ データ受信
     */
    LOGTRACE(ECTRL::eYE, ERANK::eDBG, ENAME::eBG_RETR, "sem_post()->receiver()\n");

    ret_socket = ((ftpsocket_tran*)ptrns)->receiver(FTP_WAITTIME, zeroflg, str_dl_msg);
    if (ret_socket < 0) {
        goto EXIT_FUNCTION;                             //return;
    }
    LOGTRACE(ECTRL::eYE, ERANK::eDBG, ENAME::eBG_RETR, "%s\n", str_dl_msg.c_str());

EXIT_FUNCTION:
    // PORT番号は必ず、更新する。理由はnlst_receiver()参照
    u16port = ptrns->mu16PORT;
    u16port++;
    if (u16port == 0) {                                 // オーバーフローしたなら、
        u16port = SOCPORT_LOCAL;                        // プライベートポート番号の初期値をセット
    }
    ptrns->mu16PORT = u16port;

    if (ret_socket < 0) {
        // 失敗するはず => ptrns->disconnect(SOCTRAN::eLISTEN);
        ptrns->release(SOCTRAN::eLISTEN);

        sharedObj.sync_wait();                          // セマフォ獲得待ち
        sharedObj.mOrder.setcmd(ord_buffer::eCMD::eFAILED);
        sharedObj.sync_post();                          // セマフォ獲得解放

        ::sem_post(ESEMID::eFGBG);                      // thread exit通知
        return;       
    }

    /*
     * ■ あと処理
     */
    int         ret_ord;
    int         ret_okyerr = 1;                         // 1: OKY, 0: ERR
    const char* pext[2]  = {".ERR",".OKY"};             // OKY/ERR拡張子
    bool        flg_save = false;                       // ダウンロードデータ保存要否
    int         flg_inspect = 0;                        // 1:検査要, 0:検査不要(OKY/ERR不定), -1:検査不要(ERR確定)
    int         siext_index = 0;
    std::string str_updfn;                              // OKY/ERRファイル名
    std::string str_result;
    std::string str_fullpath_logf;
    char*       pbuff = (char*)0;

    std::string strdir_incom = sharedObj.mstrCurDir[EPRM_CLIDIR::eINCOM];
    std::string str_fullpath_ord;

    // ■ ログファイル
    //   "ログファイル名"は書き換えられることを想定していないため、排他不要
    str_fullpath_logf = sharedObj.mstrFullPath[EPRM_PATH::eFTPLOG];

    pSharedLog->sync_wait();
    pSharedLog->mvElement[EMSG::eRETR_PROCESS_ORD]->writer(&gLogCtrl, str_fullpath_logf.c_str());
    pSharedLog->sync_post();

    // ■ 取り込み済判定
    sharedObj.sync_wait();                              // セマフォ獲得待ち

    // incomingフォルダ内の同名ファイル検索処理
    // 1. NOT FOUND     新規保存処理※1
    // 2. FOUND         取り込み済確認処理※2

    //                  ※1 ORDファイル保存 & OKY/ERR判定

    //                  ※2 差異判定するため、ファイルリード
    //                  リード結果と差異あれば(最新データなので)、ORDファイル保存 & OKY/ERR判定
    //                  差異なければ、取り込み済なので、ERR(ORDファイル保存不要)

    std::string         str_orddir = sharedObj.mstrCurDir[EPRM_CLIDIR::eINCOM];
    std::string         str_ordfn[2];                   // ORDファイル名
    filename            ord_fname;;
    std::string         str_fullpath;
    utility::findfile   ff;                             // ファイル検索
    int                 found = 0;                      // 0はnot found..

    sharedObj.mOrder.getfn(EFOLDER::eORD, str_ordfn[0]/*拡張子あり*/);
    ord_fname.left(str_ordfn[1]/*拡張子なし*/, str_ordfn[0].c_str(), ".");

    // ローカル変数初期値 仮決め
    ret_okyerr  = 1;                                    // OKY
    flg_inspect = 0;                                    // OKY/ERR判定: 不要
    flg_save    = false;                                // ORDファイル保存: 不要

    if (str_dl_msg.size() != ORD_EXPECTED_SIZE) {       // 固定長異常
        flg_inspect = -1;                               // ERR確定
        ret_okyerr  = 0;                                // ERR確定
    }
    else {
        found = ff.finder(str_orddir.c_str(), str_ordfn[0].c_str()); // ORDファイル検索
        if (found > 0) {                                    // 見つかった
            // incomming/???.ORDをファイルリード
            // 差異判定
            //  差異あり    OKY/ERR判定
            //  差異なし    ERR

            // ファイルリード & 差異判定
            str_fullpath = str_orddir + "\\" + str_ordfn[0];
            ret_ord = sharedObj.mOrder.reader(
                str_fullpath.c_str(),
                (unsigned char*)str_dl_msg.c_str(),
                str_dl_msg.size());
            if (ret_ord < 0) {                          // 失敗
                flg_inspect = -1;                       // ERR確定
            }
            else if (ret_ord == 0) {                    // 差異がなければ、取り込み済
                flg_inspect = -1;                       // ERR確定
            }
            else {                                      // 差異があれば、取り込み要
                flg_save = true;
                flg_inspect = true;
            }
        }
        else {                                          // 見つからない
            str_fullpath.clear();
            sharedObj.mOrder.bufclear();
            flg_save = true;
            flg_inspect = true;
        }
    }

    // ORDファイル保存
    if (flg_save == true) {
        str_fullpath_ord = strdir_incom + "\\" + str_ordfn[0];
        utility::file::writer(str_fullpath_ord.c_str(), str_dl_msg.c_str(), str_dl_msg.size());

        // メモリ上のORDを更新
        sharedObj.mOrder.memupdate((unsigned char*)str_dl_msg.c_str(), str_dl_msg.size());
    }

    // ダウンロードメッセージ OKY/ERR判定
    if (flg_inspect == 1) {                             // 検査要
        ret_okyerr = sharedObj.mOrder.inspector(str_result);
    }
    else if (flg_inspect == -1) {                       // 検査不要 ERR確定
        ret_okyerr = 0;
        sharedObj.mOrder.make_allerr(str_result);
    }
    else {
        str_result.clear();
    }

    // ORDファイル名から、OKY/ERRファイル名作成
    siext_index= (ret_okyerr == 1) ? 1 : 0;
    str_updfn  = str_ordfn[1] + pext[siext_index];      // updateファイル名
    sharedObj.mOrder.setfn(EFOLDER::eANS, str_updfn);

    LOGTRACE(ECTRL::eYE, ERANK::eDBG, ENAME::eBG_RETR, "setcmd(ord_buffer::eCMD::eUPLANS)\n");
    sharedObj.mOrder.setcmd(ord_buffer::eCMD::eUPLANS);

    // ■ フォアグラウンド通知
    // receiver()実行時にフォアグラウンドにディスパッチする場合としない場合がある。
    // ディスパッチしない場合、フォアグラウントでsem_wait()できないため、
    // ↓ sem_post()をcallすると、ERROR_TOO_MANY_POSTS(298)が返る。
    // 致命的エラーではないので(itron,linuxなら、無視するであろう課題)、
    // Windowsは一般ユーザーが操作するOSなので、できるだけエラーは救っておきたいの
    // で、ディスパッチする機会を与えるため、Sleep(1)をcall。
    // 発生頻度は減ったものの、稀にMANY_POSTが発生する。
    ::Sleep(1);

    sharedObj.sync_post();                              // セマフォ獲得解放
    ::sem_post(ESEMID::eFGBG);                          // thread exit通知

    LOGTRACE(ECTRL::eYE, ERANK::eDBG, ENAME::eBG_RETR, "retr_receiver()<<<\n");
    return;                                             // 正常終了
}

/*!
 * @file        thr_function.cpp
 * @fn          stor_ans_sender(void* pArguments)
 * @brief       STORメッセージ送信(upload)
 * @details     フォアグラウンドとセマフォで同期をとりながら、データ送信を行う。
 *              セマフォ獲得、解放タイミングはシビアなので、変更時には
 *              FTPサーバー、フォアグラウンド、バックグラウンド、三者まとめて検討が必要(三位一体, Trinity)。
 * @return      void
 * @param[in]	pArguments      ftpsocket_tran オブジェクトポインタ
 * @date        2022/3/28
 * @note        C++メソッドをcallするためのCスタイル関数(LINK対策)
 */
void stor_ans_sender(void* pArguments)
{
    int                 ret_socket;
    ftpsocket*          ptrns = (ftpsocket*)pArguments; // ptrnsは ftpsocket_tran オブジェクト
    ADDRINFOA           ai_tran;                        // the getaddrinfo function(input引数) to hold host address information.
    const char*         pai_tran[2] = { "", "" };
    unsigned short      u16port;
    std::stringstream   ss_port;
    std::string         str_port;
    std::string         str_msg;

    LOGTRACE(ECTRL::eYE, ERANK::eDBG, ENAME::eBG_STOR1, "stor_ans_sender()>>>\n");

    ftpsocket::addrinfo(&ai_tran, SOCPORT_TRAN);
    ss_port << ptrns->mu16PORT;
    ss_port >> str_port;
    pai_tran[1] = str_port.c_str();

    // socket()～release()をサブルーチンにして、共通化するとsem_post()が見えにくくなるので、サブルーチンにはしない。
    /*
     * ■ socket()～listen()
     */
    ret_socket = ptrns->initialize(ai_tran, (void*)&pai_tran[0]);
    ::sem_post(ESEMID::eFGBG);                          // socket()～listen()まで完了通知

    if (ret_socket < 0) {
        goto EXIT_FUNCTION;                             //return;
    }

    /*
     * ■ accept(), 接続待ち
     */
    LOGTRACE(ECTRL::eYE, ERANK::eDBG, ENAME::eBG_STOR1, "sem_post()->connect()\n");

    ret_socket = ptrns->connect(SOCTRAN::eLISTEN);
    ::sem_post(ESEMID::eFGBG);                          // accept()完了通知

    if (ret_socket < 0) {
        goto EXIT_FUNCTION;                             //return;
    }

EXIT_FUNCTION:
    // PORT番号は必ず、更新する。理由はnlst_receiver()参照
    u16port = ptrns->mu16PORT;
    u16port++;
    if (u16port == 0) {                                 // オーバーフローしたなら、
        u16port = SOCPORT_LOCAL;                        // プライベートポート番号の初期値をセット
    }
    ptrns->mu16PORT = u16port;

    // listenソケットは不要
    // ここで ::shutdown()しても失敗する<=マニュアルと違う。
    // ptrns->disconnect(SOCTRAN::eLISTEN);
    ptrns->release(SOCTRAN::eLISTEN);

    if (ret_socket < 0) {
        sharedObj.sync_wait();                          // セマフォ獲得待ち
        sharedObj.mOrder.setcmd(ord_buffer::eCMD::eFAILED);
        sharedObj.sync_post();                          // セマフォ獲得解放
        return;       
    }

    /*
     * ■ データ送信 upload
     */
    std::string str;
    std::string str_ordfn[2];                           // ORDファイル名
    filename    ord_fname;;
    std::string str_updfn;                              // notifyファイル名

    sharedObj.sync_wait();                              // セマフォ獲得待ち
    sharedObj.mOrder.getOKYERRString(str);              // OKY/ERR文字列
    sharedObj.sync_post();                              // セマフォ獲得解放

    LOGTRACE(ECTRL::eYE, ERANK::eDBG, ENAME::eBG_STOR1, "sem_post()->sender()\n");

    ((ftpsocket_tran*)ptrns)->sender(FTP_WAITTIME, str.c_str(), str.size());
    ptrns->disconnect(SOCTRAN::eACCEPT);
    ptrns->release(SOCTRAN::eACCEPT);

    // ■ ログファイル
    //   "ログファイル名"は書き換えられることを想定していないため、排他不要
    std::string         str_fullpath_logf;
    str_fullpath_logf = sharedObj.mstrFullPath[EPRM_PATH::eFTPLOG];

    pSharedLog->sync_wait();
    pSharedLog->mvElement[EMSG::ESTOR_UPL]->writer(&gLogCtrl, str_fullpath_logf.c_str());
    pSharedLog->sync_post();

    /*
     * ■ あと処理
     */
    std::string str_fullpath;
    std::string strdir_logs = sharedObj.mstrCurDir[EPRM_CLIDIR::eORDLOGS];
    std::string strdir_proc = sharedObj.mstrCurDir[EPRM_CLIDIR::ePROC];
    std::string str_ans;                                // answerファイル名

    // ■ NTYファイル名づくり
    sharedObj.sync_wait();                              // セマフォ獲得待ち

    sharedObj.mOrder.getfn(EFOLDER::eORD, str_ordfn[0]/*拡張子あり*/); 
    ord_fname.left(str_ordfn[1]/*拡張子なし*/, str_ordfn[0].c_str(), ".");

    str_updfn = str_ordfn[1] + ".NTY";                  // updateファイル名
    sharedObj.mOrder.setfn(EFOLDER::eNTY, str_updfn);

    LOGTRACE(ECTRL::eYE, ERANK::eDBG, ENAME::eBG_STOR1, "setcmd(ord_buffer::eCMD::eUPLNTY)\n");
    sharedObj.mOrder.setcmd(ord_buffer::eCMD::eUPLNTY);   // 次はNOTIFYフォルダへのupload

    sharedObj.sync_post();                              // セマフォ獲得解放

    // 古いファイルは削除(OrderLogs以下は削除しない)
    utility::findfile::eraser(strdir_proc.c_str(), "*.OKY");
    utility::findfile::eraser(strdir_proc.c_str(), "*.ERR");

    // ローカル保存(*.OKY/ERR)
    sharedObj.mOrder.getfn(EFOLDER::eANS, str_ans/*拡張子あり*/);

    str_fullpath = strdir_logs + "\\" + str_ans;
    utility::file::writer(str_fullpath.c_str(), str.c_str(), str.size());

    str_fullpath.clear();
    str_fullpath = strdir_proc + "\\" + str_ans;
    utility::file::writer(str_fullpath.c_str(), str.c_str(), str.size());

    // ■ フォアグラウンド通知
    //::sem_post(ESEMID::eFGBG);                          // thread exit通知
    LOGTRACE(ECTRL::eYE, ERANK::eDBG, ENAME::eBG_STOR1, "stor_ans_sender()<<<\n");
    return;                                             // 正常終了
}

/*!
 * @file        thr_function.cpp
 * @fn          stor_nty_sender(void* pArguments)
 * @brief       STORメッセージ送信(upload)
 * @details     フォアグラウンドとセマフォで同期をとりながら、データ送信を行う。
 *              セマフォ獲得、解放タイミングはシビアなので、変更時には
 *              FTPサーバー、フォアグラウンド、バックグラウンド、三者まとめて検討が必要(三位一体, Trinity)。
 * @return      void
 * @param[in]	pArguments      ftpsocket_tran オブジェクトポインタ
 * @date        2022/3/28
 * @note        C++メソッドをcallするためのCスタイル関数(LINK対策)
 */
void stor_nty_sender(void* pArguments)
{
    int                 ret_socket;
    ftpsocket*          ptrns = (ftpsocket*)pArguments; // ptrnsは ftpsocket_tran オブジェクト
    ADDRINFOA           ai_tran;                        // the getaddrinfo function(input引数) to hold host address information.
    const char*         pai_tran[2] = { "", "" };
    unsigned short      u16port;
    std::stringstream   ss_port;
    std::string         str_port;
    std::string         str_msg;

    LOGTRACE(ECTRL::eYE, ERANK::eDBG, ENAME::eBG_STOR2, "stor_nty_sender()>>>\n");

    ftpsocket::addrinfo(&ai_tran, SOCPORT_TRAN);
    ss_port << ptrns->mu16PORT;
    ss_port >> str_port;
    pai_tran[1] = str_port.c_str();

    // socket()～release()をサブルーチンにして、共通化するとsem_post()が見えにくくなるので、サブルーチンにはしない。
    /*
     * ■ socket()～listen()
     */
    ret_socket = ptrns->initialize(ai_tran, (void*)&pai_tran[0]);
    ::sem_post(ESEMID::eFGBG);                          // socket()～listen()まで完了通知

    if (ret_socket < 0) {
        goto EXIT_FUNCTION;                             //return;
    }

    /*
     * ■ accept(), 接続待ち
     */
    LOGTRACE(ECTRL::eYE, ERANK::eDBG, ENAME::eBG_STOR2, "sem_post()->connect()\n");

    ret_socket = ptrns->connect(SOCTRAN::eLISTEN);
    ::sem_post(ESEMID::eFGBG);                          // accept()完了通知

    if (ret_socket < 0) {
        goto EXIT_FUNCTION;                             //return;
    }

EXIT_FUNCTION:
    // PORT番号は必ず、更新する。理由はnlst_receiver()参照
    u16port = ptrns->mu16PORT;
    u16port++;
    if (u16port == 0) {                                 // オーバーフローしたなら、
        u16port = SOCPORT_LOCAL;                        // プライベートポート番号の初期値をセット
    }
    ptrns->mu16PORT = u16port;

    // listenソケットは不要
    // ここで ::shutdown()しても失敗する<=マニュアルと違う。
    //ptrns->disconnect(SOCTRAN::eLISTEN);
    ptrns->release(SOCTRAN::eLISTEN);

    if (ret_socket < 0) {
        sharedObj.sync_wait();                          // セマフォ獲得待ち
        sharedObj.mOrder.setcmd(ord_buffer::eCMD::eFAILED);
        sharedObj.sync_post();                          // セマフォ獲得解放
        return;       
    }

    /*
     * ■ データ送信 upload
     */
    sharedObj.sync_wait();                              // セマフォ獲得待ち
    const char* pmsg = (const char*)sharedObj.mOrder.get_pointer();
    size_t      dtsz = sharedObj.mOrder.get_datasize();
    sharedObj.sync_post();                              // セマフォ獲得解放

    LOGTRACE(ECTRL::eYE, ERANK::eDBG, ENAME::eBG_STOR2, "sem_post()->sender()\n");
    ((ftpsocket_tran*)ptrns)->sender(FTP_WAITTIME, pmsg, dtsz);
    ptrns->disconnect(SOCTRAN::eACCEPT);
    ptrns->release(SOCTRAN::eACCEPT);

    // ■ ログファイル
    //   "ログファイル名"は書き換えられることを想定していないため、排他不要
    std::string         str_fullpath_logf;
    str_fullpath_logf = sharedObj.mstrFullPath[EPRM_PATH::eFTPLOG];

    pSharedLog->sync_wait();
    pSharedLog->mvElement[EMSG::ESTOR_UPL]->writer(&gLogCtrl, str_fullpath_logf.c_str());
    pSharedLog->sync_post();

    /*
     * ■ あと処理
     */
    std::string str_fullpath;
    std::string str_compdir = sharedObj.mstrCurDir[EPRM_CLIDIR::eCOMP/*Completed*/];
    std::string str_orddir  = sharedObj.mstrCurDir[EPRM_CLIDIR::eINCOM];
    std::string str_ordfn;                              // ORDファイル名
    std::string str_next;                               // 次にダウンロードするORDファイル名
    std::string str_nty;                                // notifyファイル名
    bool        dl_oky;
    ord_struct  dl_ord;                                 // ORD構造体(downloadデータ1件分)
    std::vector<std::string>::iterator  iter;

    // 排他不要>>>
    // 古いファイルは削除
    utility::findfile::eraser(str_compdir.c_str(), "*.NTY");

    // ローカル保存(*.NTY)
    sharedObj.mOrder.getfn(EFOLDER::eNTY, str_nty);
    str_fullpath = str_compdir + "\\" + str_nty;
    utility::file::writer(str_fullpath.c_str(), pmsg, dtsz);

    // 今回のシーケンス中のダウンロードデータをstring配列で取得
    dl_oky = sharedObj.mOrder.good();                   // ORDはすべてOKY確認
    if (dl_oky == true) {                               // すべてOKY
        // ファイル名とパラメータをvORD構造体にセット
        sharedObj.mOrder.getfn(EFOLDER::eORD, str_ordfn);
        dl_ord.mstrFullpath = str_orddir + "\\" + str_ordfn;

        sharedObj.mOrder.getall(dl_ord.mvParams/*57パラメータ*/);
        csIfObj.vORD.push_back(dl_ord);
    }

    iter = vnList.begin();
    vnList.erase(iter);                                 // 先頭要素削除
    // 排他不要<<<

    sharedObj.sync_wait();                              // セマフォ獲得待ち

    if (vnList.size() > 0) {                            // ファイルリストが空になってない
        LOGTRACE(ECTRL::eYE, ERANK::eDBG, ENAME::eBG_STOR2, "setcmd(ord_buffer::eCMD::eDOWNLOAD)\n");

        str_next = vnList[0];
        sharedObj.mOrder.setfn(EFOLDER::eORD, str_next);
        sharedObj.mOrder.setcmd(ord_buffer::eCMD::eDOWNLOAD);
    }
    else {
#ifdef FTP_ENDLESS
        LOGTRACE(ECTRL::eYE, ERANK::eDBG, ENAME::eBG_STOR2, "setcmd(ord_buffer::eCMD::eNLST)\n");
        sharedObj.mOrder.setcmd(ord_buffer::eCMD::eNLST);        // 次はNLST *.*
#else
        // 日本ペイント仕様
        LOGTRACE(ECTRL::eYE, ERANK::eDBG, ENAME::eBG_STOR2, "setcmd(ord_buffer::eCMD::eABORT)\n");
        sharedObj.mOrder.setcmd(ord_buffer::eCMD::eABORT);    // 終了
#endif  /* #ifdef FTP_ENDLESS */
    }

    sharedObj.sync_post();                              // セマフォ獲得解放

    // ■ フォアグラウンド通知
    //::sem_post(ESEMID::eFGBG);                          // thread exit通知
    LOGTRACE(ECTRL::eYE, ERANK::eDBG, ENAME::eBG_STOR2, "stor_nty_sender()<<<\n");
    return;                                             // 正常終了
}
