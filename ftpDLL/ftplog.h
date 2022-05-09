#pragma once
#include <string>
#include <sstream>
#include <vector>
#include "logmsg.h"

/*!
 * @brief FTPログ(FTPlog.txt)
 * @note  FTPログに特化したオブジェクト(グローバルオブジェクト)
 */

#define ECTRL                   (int)ftplog::eCTRL
#define ERANK                   (int)ftplog::eRANK
#define ENAME                   (int)ftplog::eNAME

#define EPATH                   (int)ftplog::ePATH
#define EMSG                    (int)ftplog::eMSG

#define LOGTRACE(ctrl, rnk, nm, fmt, ...)           \
{                                                   \
    char*   pbuff = (char*)0;                       \
    std::stringstream   ss;                         \
    std::string         str_msg;                    \
    std::string         str_func = __FUNCTION__;    \
                                                    \
    pbuff = new char[DMSG_BUFFSIZE];                \
    memset(pbuff, 0x00, DMSG_BUFFSIZE);             \
    snprintf(pbuff, DMSG_BUFFSIZE, fmt, __VA_ARGS__); \
                                                    \
    ss << str_func << "(): " << pbuff;              \
    str_msg = ss.str();                             \
    ftplog::output(ctrl, rnk, nm, str_msg.c_str()); \
    delete[] pbuff;                                 \
}

class ftplog
{
public:
    enum class eCTRL {                                  //! ログ出力制御
        // ファイル出力
        eFILE,
        // ディスプレイ
        eWH,
        eRE,
        eGR,
        eYE,

        eTBD,
        eNUMB
    };

    // ptRankインデックス
    enum class eRANK {                                  //! ランク名
        eERR,                                           // fatal error
        eDBG,                                           // debug
        eMEMO,                                          // memo/備忘録
        eNUMB
    };

    // ptNameインクデックス
    enum class eNAME {                                  //! 機能名
        eMAIN,
        eXXXX,
        eSIM,                                           // simulator

        eSCKT,                                          // socket
        eBG_NLST,
        eBG_RETR,
        eBG_STOR1,
        eBG_STOR2,

        eCDUP,                                          // cdup

        eCWD_,                                          // cwd
        eUSER,                                          // user
        ePASS,                                          // pass
        eQUIT,                                          // quit

        ePORT,                                          // port
        ePWD_,                                          // pwd

        eNLST,                                          // nlst
        eRSTA,                                          // restart
        eRETR,                                          // retr
        eSTOR,                                          // stor

        eSYST,                                          // syst
        eTYPE,                                          // type

        eTBD,                                           // To Be Determined(未定)
        eNUMB
    };

public:
    enum class ePATH {
        eDIR,
        eFN,
        eEXT,
        eNUMB
    };
    std::string                 mstrPath[EPATH::eNUMB]; //! パス名配列

public:
    // ptMsgインデックス
    enum class eMSG {                                   //! メッセージ一覧 
        // startup
        eSTA_PERFORMED,
        eSTA_CLEANING,
        eSTA_CLOSED,
        eSTA_RF,

        // job xxx message
        eJOB_STARTED,
        eJOB_ABORTED,
        eJOB_TERMINATED,

        // 接続ステータス
        eSTAT_TITLE,

        eSTAT_HOST,
        eSTAT_PORT,
        eSTAT_USER,
        eSTAT_PASS,
        eSTAT_ORDDIR,
        eSTAT_FBDIR,
        eSTAT_NTYDIR,

        eSTATUS,
        eSTAT_CONNECT,
        eSTAT_SUCCESS,
        eSTAT_DISCON,

        // コマンド
        eCOMMAND,                                       // 引数なしコマンド
        eCMD_ARG,                                       // 引数ありコマンド

        // コマンド実行結果
        // NLST
        // 検索
        eNLST_FOUND_ORD,
        eNLST_NOFILES_ORDDIR,

        // RETR
        eNLST_FOUND_FBDIR,
        eNLST_CHECK_FB,
        eRETR_DWL_ORD,
        eRETR_PROCESS_ORD,

        // STOR OKY/ERR, NTY
        ESTOR_UPL,                                      // ANS/NTY共通

        // To Be Determined(未定)
        eTBD,
        eNUMB
    };
    std::vector<logmsg*>        mvElement;              //! ログメッセージ配列 [ftplog::eMSG]

public:
    ftplog();
    ftplog(const char* pFullpath);
    ftplog(const char* pDir, const char* pFn, const char* pExt);
    virtual ~ftplog();

    int initialize(void);

    // デバッグ出力 ファイル/コンソール
    static int output(int siCtrl, int siRank, int siName, const char* pDetailmsg);
    static int text_writer(const char* pFullpath, std::string& strData);

    // 規定のログファイル
    //int get_sta_performed(const char*pAdditional, int siFileFlg = 0); 

    // 同期
    int sync_init(void);
    int sync_wait(void);
    int sync_post(void);
    int sync_close(void);

protected:
    int variables(void);
};

