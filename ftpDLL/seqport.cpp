#include "pch.h"
#include "seqport.h"
#include "params.h"
#include "ftplog.h"
#include "def_dbg.h"

#include "winec.h"
#include "ecode.h"
#include "reply.h"
#include "ftpcmd.h"
#include "seqpasv.h"

#include <sstream>
#include <iostream>

extern params   sharedObj;

//#include "instant_thread.h"
//  https://atmarkit.itmedia.co.jp/ait/articles/0105/15/news004.html

/*
    0x0000 ～ 0x03FF     0 ～  1023 WELL KNOWN PORT NUMBERS      ウェルノウンポート番号
    0x1000 ～ 0xBFFF  1024 ～ 49151 REGISTERED PORT NUMBERS      登録ポート番号
    0xc000 ～ 0xFFFF 49152 ～ 65535 DYNAMIC AND/OR PRIVATE PORTS ダイナミック/プライベートポート番号
*/
/*  PADDRINFOA		result
    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    typedef struct addrinfo
    {
        int                 ai_flags;       // AI_PASSIVE, AI_CANONNAME, AI_NUMERICHOST
        int                 ai_family;      // PF_xxx
        int                 ai_socktype;    // SOCK_xxx
        int                 ai_protocol;    // 0 or IPPROTO_xxx for IPv4 and IPv6
        size_t              ai_addrlen;     // Length of ai_addr
        char *              ai_canonname;   // Canonical name for nodename
        _Field_size_bytes_(ai_addrlen) struct sockaddr *   ai_addr;        // Binary address
        struct addrinfo *   ai_next;        // Next structure in linked list
    }
    ADDRINFOA, *PADDRINFOA;
*/
/*  struct sockaddr
    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    struct sockaddr {
            ushort  sa_family;
            char    sa_data[14];                    // struct sockaddr_inと同等
    };

    struct sockaddr_in {
            short   sin_family;
            u_short sin_port;                       // 2byte
            struct  in_addr sin_addr;               // 4byte(union)
            char    sin_zero[8];                    // 8byte
    };
*/

extern int wait_hthr_release(HANDLE hThread);

seqport::seqport()
{
    this->initialize();
}

seqport::seqport(ftpsocket* ptranSOCKET, ftpsocket* pSOCKET)
{
	int                 rc = RET_SUCCESS;
	// new. delete
	ecode*              pec= (ecode*)0;

    if (pSOCKET == (ftpsocket*)0) {
		pec = new ecode(ecode::eVALUE::eARG_NULL, __FUNCTION__, "pSOCKET == 0");
		pec->output();
		rc = pec->rc();						            // 戻り値に変換
        delete pec;
        throw rc;                                       // コンストラクタは戻り値がないので。
    }

    this->initialize();
    mpSOCKET[ESOCK::eCTRL] = pSOCKET;
    mpSOCKET[ESOCK::eTRAN] = ptranSOCKET;
}

seqport::~seqport()
{

}

/*!
 * @file		seqport.cpp
 * @fn			int seqport::initialize(void)
 * @brief		メンバ変数初期化
 * @details		デフォルト値設定
 * @return		0 <  Return value: TBD
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	void
 * @date		2022/4/8
 * @note		initialize()は制御系の初期化
 */
int seqport::initialize(void)
{
    this->variables();
    this->mmyState = ESTATE::ePORT;
    return RET_SUCCESS;
}

/*!
 * @file		seqport.cpp
 * @fn			int seqport::variables(void)
 * @brief		メンバ変数を初期化する
 * @details		メンバ変数を初期化する
 * @return		0 <  Return value: TBD
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	void
 * @date		2022/3/16
 * @note		initialize()は制御系の初期化
 */
int seqport::variables(void)
{
    //ftpseq::variables();                              // コンストラクタでcall済
    return RET_SUCCESS;
}

/*!
 * @file            seqport.cpp
 * @fn              seqport::enter(void* pArgs)
 * @brief           シーケンスまえ処理
 * @details         TBD
 * @return          0 <  VALUE: TBD
 *                  0 == VALUE: TBD
 *                  0 >  VALUE: 状態遷移コード
 * @date            2022/3/9
 * @note            ***
 */
int seqport::enter(void* pArgs)
{
	int rc = (int)this->mmyState;
    return rc;
}

/*!
 * @file          seqport.cpp
 * @fn            seqport::exec(void* pArgs)
 * @brief         コマンド処理
 * @details       PORTコマンド送信
 * @return        0 <  VALUE: 異常終了(再起動シーケンス)
 *                0 >= VALUE: 状態遷移コード(0～n)
 * @date          1970/3/4
 * @note          TBD: RFC959 failure時のリトライ処理
 */
int seqport::exec(void* pArgs)
{
/* RFC959   // https://datatracker.ietf.org/doc/html/rfc959#section-6
    If　this command is used,
    the argument is the concatenation of a　32-bit internet host address and a 16-bit TCP port address.
    This address information is broken into 8-bit fields and the　value of each field is transmitted as a decimal number
    (in character string representation).
    The fields are separated by commas.
    A port command would be:
    PORT h1,h2,h3,h4,p1,p2 where h1 is the high ord_buffer 8 bits of the internet host address.
*/
	int				    rc	= RET_SUCCESS;
	int				    ret_wlib;                       // Winライブり用戻り値
	int				    ret_ec;
	std::wstring	    wstr_emsg = L"";

    int                 bufsize = 1024;
    std::string         str_rsp = "";

    std::stringstream   ss_port;
    std::string         str_port;
    unsigned short      u16port;
    unsigned char       u8port[2] = {0,0};

    struct sockaddr_in* paddr;
    PADDRINFOA          result = 0;
    ADDRINFOA           ai_tran;                        // the getaddrinfo function(input引数) to hold host address information.
	// new. delete
	ecode*			    pec   = (ecode*)0;
    char*               pbuff = (char*)0;
	ftpcmd*             pport = (ftpcmd*)0;

    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::ePORT, ">>>\n");
    //
    // ■ まえ処理
    //
	pbuff = new char[bufsize];
	if (pbuff == (char*)0) {
		ecode	retobj(ecode::eVALUE::eNEW, __FUNCTION__, "0 = new char[bufSize]");
		retobj.output();
		rc = retobj.rc();								// 戻り値に変換
		goto EXIT_FUNCTION;
	}

    // 非推奨   ::gethostbyname(pbuff);
	// getaddrinfo() <- gethostbyname()	// https://docs.microsoft.com/en-us/windows/win32/api/wsipv6ok/nf-wsipv6ok-gethostbyname
    //ret_wlib = ::gethostname(pbuff, bufsize);

    // NULL文字列を渡して、ローカルホスト名文字列取得(IPアドレスでない)
    memset(pbuff, 0x00, bufsize);
    ret_wlib = ::gethostname(pbuff, bufsize); 
    if (ret_wlib == SOCKET_ERROR) {
		ret_ec = winec::get_sock_emsg(wstr_emsg);       // Winエラーコード取得

		std::wstring wstr_tmp = L"Failed gethostname()..,";
		wstr_tmp += wstr_emsg;

		pec = new ecode(ecode::eVALUE::eGETHOSTNAME, __FUNCTIONW__, wstr_tmp);
		pec->output();
		rc = pec->rc();
		goto EXIT_FUNCTION;
    }

    // データ転送用ポート
    u16port   = mpSOCKET[ESOCK::eTRAN]->mu16PORT;       // 現在値参照
    u8port[0] = (unsigned char)((u16port >> 8) & 0x00ff);
    u8port[1] = (unsigned char)(u16port & 0x00ff);

    ss_port << u16port;
    ss_port >> str_port;
    ftpsocket::addrinfo(&ai_tran, u16port);
    ret_wlib = ::getaddrinfo(pbuff, str_port.c_str(), &ai_tran, &result);
    if (ret_wlib != 0) {
		::WSACleanup();                                 // https://docs.microsoft.com/en-us/windows/win32/api/ws2tcpip/nf-ws2tcpip-getaddrinfo

		pec = new ecode(ecode::eVALUE::eGETADDRINFO, __FUNCTION__, "Failed getaddrinfo()..");
		pec->output();
		rc = pec->rc();
		goto EXIT_FUNCTION;
	}

    // %hu 1byte符号なし10進数
    memset(pbuff, 0x00, bufsize);
    paddr = (struct sockaddr_in*)result->ai_addr;
    snprintf(pbuff, bufsize, "PORT %hu,%hu,%hu,%hu,%hu,%hu\x0d\x0a",
                            paddr->sin_addr.S_un.S_un_b.s_b1,
                            paddr->sin_addr.S_un.S_un_b.s_b2,
                            paddr->sin_addr.S_un.S_un_b.s_b3,
                            paddr->sin_addr.S_un.S_un_b.s_b4,
                            u8port[0],                  // 上位8ビット
                            u8port[1]);                 // 下位8ビット
    //
    // ■コマンド送信
    //
    pport = new ftpcmd(mpSOCKET, pbuff);
	if (pport == (ftpcmd*)0) {
		ecode	retobj(ecode::eVALUE::eNEW, __FUNCTION__, "0 = new ftpcmd(mpSOCKET, pbuff)");
		retobj.output();
		rc = retobj.rc();                               // 戻り値に変換
		goto EXIT_FUNCTION;
	}

    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::ePORT, "PORT\n");
	rc = pport->group1(str_rsp, (void*)0);              // PORT
	if (rc < 0) {
		goto EXIT_FUNCTION;
	}

EXIT_FUNCTION:
	if (pec)   {delete pec;}
	if (pport) {delete pport;}
    if (pbuff) {delete[] pbuff;}

    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::ePORT, "<<< %d\n", rc);
    if (rc < 0) {throw rc;}
    return (int)this->mmyState;
}

/*!
 * @file          seqport.cpp
 * @fn            int seqport::exit(void* pArgs)
 * @brief         シーケンスあと処理
 * @details       TBD
 * @return        0 <  VALUE: シーケンス中断(TBD)
 *                0 == VALUE: 状態遷移コード(TBD)
 *                0 >  VALUE: 状態遷移コード
 * @date          2022/3/15
 * @note          ***
 */
//static int flg_sw = 0;
int seqport::exit(void* pArgs)
{
#if 0
/*
    portあと処理でリングバッファチェック
    download/uploadファイルなし -> nlstシーケンス
    downloadファイル名あり -> downlaodシーケンス(RETR)
    uploadファイル名あり -> uplaodシーケンス(STOR)

    ※ seqport::exec()終了時、homeディレクトリにいてる。
*/
    flg_sw ^= 1;
    if (flg_sw) {
        return ESTATE::eDOWNLOAD;   // RETR debug
    }
    else {
        return ESTATE::eUPLOAD;     // STOR debug
    }
#else
/*  PORT & コマンド一覧
    PORT & NLST     バックグラウンドでdownloadファイル名取得/setcmd(eDOWNLOAD)
    PORT & RETR     バックグラウンドでファイル解析/setcmd(eUPLOAD)
    PORT & STOR     バックグラウンドでsetcmd(eUPLOAD)
    PORT & STOR     バックグラウンドでsetcmd(eNLST)

    バックグラウンドでは、
        NLST/RETR/STORのreplyメッセージを判定して、
        setcmd()にeCMD::eNLST/eDOWNLOAD/eUPLOADをセットすみ
    フォグラウンドでは、シーケンスを継続してPORTシーケンスに戻り、
    seqport::exit()で、eCMD::eNLST/eDOWNLOAD/eUPLOADをgetcmd()で取得、
    次のシーケンスに遷移する。
*/
    int cmd;
    int status;

    sharedObj.sync_wait();                              // セマフォ獲得待ち
    cmd = sharedObj.mOrder.getcmd();                    // 前回のPORT & コマンド結果取得
    sharedObj.mOrder.setcmd(ord_buffer::eCMD::eUNKNOWN);
    sharedObj.sync_post();                              // セマフォ解放

    switch((ord_buffer::eCMD)cmd) {
#ifndef FTP_ENDLESS
    // 日本ペイント仕様
    case ord_buffer::eCMD::eABORT:   status = RET_FAILED; break;
#endif
    case ord_buffer::eCMD::eNLST:     status = ESTATE::eNLST; break;
    case ord_buffer::eCMD::eDOWNLOAD: status = ESTATE::eDOWNLOAD; break;
    case ord_buffer::eCMD::eUPLANS:   status = ESTATE::eUPLANS; break;
    case ord_buffer::eCMD::eUPLNTY:   status = ESTATE::eUPLNTY; break;
    case ord_buffer::eCMD::eFAILED:   status = ESTATE::eLOGOUT; break;
    default: status = ESTATE::eNLST; break;
    }

    return status;
#endif
}
