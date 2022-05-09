#include "pch.h"
#include "util_file.h"
#include "ecode.h"
#include <iostream>
#include <fstream>
#include <algorithm>

//using namespace std;

namespace utility {
file::file()
{

}

file::~file()
{

}

int file::writer(const char* pFullpath, const char* pBuff, size_t bufSize)
{
    std::ofstream ofs(pFullpath, std::ios::out, std::ios::binary);
    ofs.write(pBuff, bufSize);
    ofs.close();
    return RET_SUCCESS;
}

int file::writer(const char* pFullpath, std::string& rString)
{
    std::ofstream ofs(pFullpath, std::ios::out, std::ios::binary);

    std::copy(rString.begin(), rString.end(), std::ostreambuf_iterator<char>(ofs));
    ofs.close();
    return RET_SUCCESS;
}
};
