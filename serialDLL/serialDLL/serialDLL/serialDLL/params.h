#pragma once
#include <string>

/*!
 * @brief グローバルパラメータ
 * @note  CCMクライアントアプリケーション内のグローバルオブジェクト
 */
#define EPRM_CLIDIR             (int)params::eCLIDIR
#define EPRM_PATH               (int)params::ePATH

class params
{
public:
    enum class eCLIDIR {                                //! クライアントディレクトリ
        eDATA,                                          // ORManager\CCMdata\ccmdata.DAT
        eNUMB
    };

    enum class ePATH {                                  //! ログファイル名定義
        eLOG,                                           // ORManager\CCMLog\CCMLog.txt
        eNUMB
    };

public:
    // 排他不要(リードオンリー)
    std::string mstrCurDir[EPRM_CLIDIR::eNUMB];         //! クライアント(カレントPC)
    std::string mstrFullPath[EPRM_PATH::eNUMB];         //! ファイルパス(ログファイル等)

public:
    params();
    virtual ~params();

    int initialize(void);

    // 同期
    //int sync_init(void);
    //int sync_wait(void);
    //int sync_post(void);
    //int sync_close(void);

protected:
    int variables(void);
};

