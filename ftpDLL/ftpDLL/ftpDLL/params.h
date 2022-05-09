#pragma once
#include <string>
#include "order.h"

/*!
 * @brief グローバルパラメータ
 * @note  FTPクライアントアプリケーション内のグローバルオブジェクト
 */

#define EPRM_PORT               (int)params::ePORT
#define EPRM_ACCT               (int)params::eACCT
#define EPRM_SRVDIR             (int)params::eSRVDIR
#define EPRM_CLIDIR             (int)params::eCLIDIR
#define EPRM_PATH               (int)params::ePATH
#define EPRM_SITE               (int)params::eSITE

class params
{
public:
    enum class ePORT {                                  //! ポートenum定義
        eCTRL,
        eTRNS,
        eNUMB
    };

    enum class eACCT {                                  //! アカウント定義
        eIPv4,
        eUSER,
        ePASS,
        eNUMB
    };

    enum class eSRVDIR {                                //! サーバーディレクトリ
        eORDER,                                         // SND/ORDER
        eFEEDBACK,                                      // SND/ANSWER
        eNOTIFY,                                        // RCV/NOTIFY
        eNUMB
    };

    enum class eCLIDIR {                                //! クライアントディレクトリ
        eINCOM,                                         //! Incoming
        eORDLOGS,                                       //! OrderLogs
        ePROC,                                          //! Processed
        eCOMP,                                          //! Completed
        eNUMB
    };

    enum class ePATH {                                  //! ログファイル名定義
        eFTPLOG,
        eNUMB
    };

    enum class eSITE {
        eUNKNOWN,

        eRF1,

        eRF7 = 7,
        eRF8,
        eRF9,
        eRF10,
        eNUMB
    };

public:
    // 排他不要(リードオンリー)
    std::string mstrSrvPort[EPRM_PORT::eNUMB];          //! サーバー制御ポート番号
    std::string mstrSrvAcct[EPRM_ACCT::eNUMB];          //! サーバーアカウント情報(IP,USER,PASS)
    std::string mstrSrvDir[EPRM_SRVDIR::eNUMB];         //! サーバーディレクトリ(RF1～RF10)
    std::string mstrCurDir[EPRM_CLIDIR::eNUMB];         //! クライアント(カレントPC)
    std::string mstrFullPath[EPRM_PATH::eNUMB];         //! ファイルパス(ログファイル等)

    int         msiSite;                                //! RF1～RF10

    // 排他要(一部のみ)
    ord_buffer  mOrder;

public:
    params();
    virtual ~params();

    int initialize(void);

    // 同期
    int sync_init(void);
    int sync_wait(void);
    int sync_post(void);
    int sync_close(void);

protected:
    int variables(void);
};

