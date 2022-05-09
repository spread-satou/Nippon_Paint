#pragma once
#include <vector>
#include <string>

namespace utility {
    class strtok
    {
    public:
        strtok();
        virtual ~strtok();

        static size_t splitter(std::vector<std::string>& rOutput, const char* pTarget, size_t siLength, const char* pSepa);
    };

    class strparam
    {
    public:
        strparam();
        virtual ~strparam();

        static size_t splitter(std::vector<std::string>& rOutput, const char* pTarget, size_t siLength, const char* pSepa);
    };
}
