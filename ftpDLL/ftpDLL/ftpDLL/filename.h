#pragma once
#include <string>
#include <vector>

/*!
 * @brief ファイル名文字列操作
 * @note RFORDER2009091500017.ORD
 */
#define FN_PREFIX           7                           //! プレフィックス
#define FN_DATE             8                           //! 年月日
#define FN_SEQNO            5                           //! 通番
#define FN_EXT              3                           //! 拡張子
#define FN_LENGTH           (FN_PREFIX + FN_DATE + FN_SEQNO + 1 + FN_EXT)

#define EFN_ID              (int)filename::eINDEX

class filename
{
public:
    enum class eINDEX {
        ePREFIX,
        eDATE,
        eSEQNO,
        eNUMB
    };

protected:
    std::string mstrTarget;                             //! 操作対象文字列
    std::string mstrSepa;                               //! 区切り文字列

public:
    filename();
    filename(const char* pTarget, const char* pSepa);
    virtual ~filename();

    int initialize(const char* pTarget, const char* pSepa);

    bool operator==(const char* pCmp) const;
    bool operator==(std::string& rCmp) const;

    int splitter(std::vector<std::string>& vString);
    int left(std::string& rString);
    int left(std::string& rString, const char* pTarget, const char* pSepa);
    int right(std::string& rString);

    static int cmp_time(const char* pDate1, const char* pDate2);
    static int cmp_seqno(const char* pSeqNo1, const char* pSeqNo2);
    static int make(std::string& rFullpath, int siSeqNo);

protected:
    void valiables(void);
};
