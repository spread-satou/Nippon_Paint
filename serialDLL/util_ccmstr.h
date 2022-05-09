#pragma once
#define RET_GOOD                1
#define RET_NOGOOD              0

/*
    case PROPERTY_ATTR_KAN:     // 缶種チェック
    case PROPERTY_ATTR_PROCODE: // 製品コードチェック
    case PROPERTY_ATTR_3POINT:  // 小数点3桁未満チェック
    case PROPERTY_ATTR_END:     // ENDチェック
    case PROPERTY_ATTR_ALPHA:   // 半角英数チェック
    case PROPERTY_ATTR_NUMERIC: // 数値文字列チェック
*/

namespace utility {
// 缶種
class canstr
{
public:
    canstr();
    ~canstr();

    static int good(unsigned char* pBuffer, size_t szMsgLength, int siChkSize, bool bFixSize = false);
};

// 製品コード
class productstr
{
public:
    productstr();
    ~productstr();

    static int good(unsigned char* pBuffer, size_t szMsgLength, int siChkSize, bool bFixSize = false);
};

// 小数点3桁未満チェック
class pointstr
{
public:
    pointstr();
    ~pointstr();

    static int good(unsigned char* pBuffer, size_t szMsgLength, int siChkSize, bool bFixSize = false);
};

// ENDチェック
class endstr
{
public:
    endstr();
    ~endstr();

    static int good(unsigned char* pBuffer, size_t szMsgLength, int siChkSize, bool bFixSize = false);
};

// 数値文字列(10進数)
class digitstr
{
public:
    digitstr();
    ~digitstr();

    static int good(unsigned char* pBuffer, size_t szMsgLength, int siChkSize, bool bFixSize = false);
};

// alphabet numeric kana
class ankstr
{
public:
    ankstr();
    ~ankstr();

    static int good(unsigned char* pBuffer, size_t szMsgLength, int siChkSize, bool bFixSize = false);
};

// multibyte(未使用)
class mbstr
{
public:
    mbstr();
    ~mbstr();

    static int good(unsigned char* pBuffer, size_t szMsgLength, int siChkSize, bool bFixSize = false);
};
}   // namespace utility {

