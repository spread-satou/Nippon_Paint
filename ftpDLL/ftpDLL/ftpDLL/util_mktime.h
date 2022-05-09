#pragma once
#include <time.h>
#include "filename.h"

namespace utility {
    class mktime
    {
    public:
        mktime();
        virtual ~mktime();

        static __time64_t conv(const char* pString);
        static int cmp(filename& rF1, filename& rF2);
    };
}

