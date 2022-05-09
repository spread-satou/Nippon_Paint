#pragma once
#include <string>

/*!
 * @brief ローカルタイム取得
 * @note  ロケール設定はしていない
 */

 //class util_localtime
 //{
 //};
namespace utility {
    class localtime
    {
    public:
        localtime();
        virtual ~localtime();

        static int getstring(std::string& rString, const char* pFmt = 0);
    };
}

