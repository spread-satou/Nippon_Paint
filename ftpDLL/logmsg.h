#pragma once
#include <string>
#include "def_buffer.h"

/*!
 * @brief ログメッセージ
 * @note  ログメッセージ1行を扱う
 */
class logmsg
{
public:
protected:
    std::string mstrFmt;                                //! 書式化文字列

public:
    logmsg();
    logmsg(const char* pFmt);
    virtual ~logmsg();

    int initialize(void);

    int append_writer(const char* pFullpath, const char* pText);

    int writer(int* pCtrl, const char* pFullpath);
    int writer(int* pCtrl, const char* pFullpath, const char* ps8Value);
    int writer(int* pCtrl, const char* pFullpath, int siValue);

protected:
    int variables(void);
};

