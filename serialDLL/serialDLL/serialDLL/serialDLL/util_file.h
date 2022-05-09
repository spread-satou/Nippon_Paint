#pragma once
#include <string>

namespace utility {
    class file
    {
    public:
        file();
        virtual ~file(void);

        static int writer(const char* pFullpath, const char* pBuff, size_t bufSize);
        static int writer(const char* pFullpath, std::string& rString);
    };
};

