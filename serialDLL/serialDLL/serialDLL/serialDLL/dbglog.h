#pragma once
#include <string>
#include <sstream>
#include <vector>
#include "def_buffer.h"

/*!
 * @brief FTPログ(FTPlog.txt)
 * @note  FTPログに特化したオブジェクト(グローバルオブジェクト)
 */

#define ECTRL                   (int)dbglog::eCTRL
#define ERANK                   (int)dbglog::eRANK
#define ENAME                   (int)dbglog::eNAME

#define EPATH                   (int)dbglog::ePATH

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
    dbglog::output(ctrl, rnk, nm, str_msg.c_str()); \
    delete[] pbuff;                                 \
}

class dbglog
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

        eCCM,                                           // CCM

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
    dbglog();
    virtual ~dbglog();

    int initialize(void);

    // デバッグ出力 ファイル/コンソール
    static int output(int siCtrl, int siRank, int siName, const char* pDetailmsg);
    static int text_writer(const char* pFullpath, std::string& strData);
    static int append_writer(const char* pFullpath, std::string& strData);

protected:
    int variables(void);
};

