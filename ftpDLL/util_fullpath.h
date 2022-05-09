#pragma once
#include <string>
#include <vector>

/*!
 * @brief フルパス名
 * @note  フルパスを加工する
 */
namespace utility {
    class fullpath
    {
    public:
        fullpath();
        virtual ~fullpath();

        static int sepa(std::vector<std::string>& rvPath, std::string& rFullpath);
    };
}   // namespace utility
