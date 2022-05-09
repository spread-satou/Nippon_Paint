#pragma once
#define RET_GOOD                1
#define RET_NOGOOD              0

namespace utility {
// 数値文字列(10進数)
class digitstr
{
public:
    digitstr();
    ~digitstr();

    static int good(unsigned char* pBuffer, int siBuffSize, int siChkSize);
};

// alphabet numeric kana
class ankstr
{
public:
    ankstr();
    ~ankstr();

    static int good(unsigned char* pBuffer, int siBuffSize, int siChkSize);
};

// multibyte
class mbstr
{
public:
    mbstr();
    ~mbstr();

    static int good(unsigned char* pBuffer, int siBuffSize, int siChkSize);
};

}   // namespace utility {

