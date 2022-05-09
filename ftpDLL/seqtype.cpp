#include "pch.h"
#include "seqtype.h"
#include "ftplog.h"

#include "winec.h"
#include "ecode.h"
#include "reply.h"
#include "ftpcmd.h"

#include <sstream>

seqtype::seqtype()
{
    this->initialize();
}

seqtype::seqtype(ftpsocket* pSOCKET)
{
	int		rc = RET_SUCCESS;
	ecode*	pec= (ecode*)0;

    if (pSOCKET == (ftpsocket*)0) {
		pec = new ecode(ecode::eVALUE::eARG_NULL, __FUNCTION__, "pSOCKET == 0");
		pec->output();
		rc = pec->rc();						            // 戻り値に変換
        delete pec;
        throw rc;                                       // コンストラクタは戻り値がないので。
    }

	this->initialize();
	mpSOCKET[ESOCK::eCTRL] = pSOCKET;
}

seqtype::~seqtype()
{

}

/*!
 * @file		seqtype.cpp
 * @fn			int seqtype::initialize(void)
 * @brief		メンバ変数初期化
 * @details		デフォルト値設定
 * @return		0 <  Return value: TBD
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	void
 * @date		2022/4/8
 * @note		initialize()は制御系の初期化
 */
int seqtype::initialize(void)
{
    this->variables();
    this->mmyState = ESTATE::eTYPE;
    return RET_SUCCESS;
}
/*!
 * @file        seqtype.cpp
 * @fn          int seqtype::variables(void)
 * @brief       パラメータ初期化
 * @details     パラメータ初期化
 * @return      0 <  VALUE: TBD
 *              0 == VALUE: 成功
 *              0 >  VALUE: TBD
 * @date        2022/3/16
 * @note		initialize()は制御系の初期化
 */
int seqtype::variables(void)
{
    //ftpseq::variables();                              // コンストラクタでcall済
    return RET_SUCCESS;
}

/*!
 * @file            seqtype.cpp
 * @fn              seqtype::enter(void* pArgs)
 * @brief           シーケンスまえ処理
 * @details         TBD
 * @return          0 <  VALUE: TBD
 *                  0 == VALUE: TBD
 *                  0 >  VALUE: 状態遷移コード
 * @date            2022/3/9
 * @note            ***
 */
int seqtype::enter(void* pArgs)
{
	int rc = (int)this->mmyState;
	return rc;
}

/*!
 * @file          seqtype.cpp
 * @fn            seqtype::exec(void* pArgs)
 * @brief         コマンド処理
 * @details       TYPEコマンド送信
 * @return        0 <  VALUE: 異常終了(再起動シーケンス)
 *                0 >= VALUE: 状態遷移コード(0～n)
 * @date          1970/3/4
 * @note          TBD: RFC959 failure時のリトライ処理
 */
int seqtype::exec(void* pArgs)
{
	int			rc;
	std::string str_rsp;
	// new. delete
	ftpcmd*		pcmd = (ftpcmd*)0;

    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eTYPE, ">>>\n");

    pcmd = new ftpcmd(mpSOCKET, "TYPE I\x0d\x0a");
	if (pcmd == (ftpcmd*)0) {
		ecode	retobj(ecode::eVALUE::eNEW, __FUNCTION__, "0 = new ftpcmd(mpSOCKET, TYPE I)");
		retobj.output();
		rc = retobj.rc();								// 戻り値に変換
		goto EXIT_FUNCTION;
	}

    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eTYPE, "TYPE I\n");
	rc = pcmd->group1(str_rsp, (void*)0);
    if (rc < 0) {
		goto EXIT_FUNCTION;
    }

#if 0
// 実験
	int ip[4];
	int port[2];
	command_pasiv(mpSOCKET, &ip[0], &port[0]);
#endif

EXIT_FUNCTION:
	if (pcmd) {delete pcmd;} 

    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eTYPE, "<<< %d\n", rc);
    if (rc < 0) {throw rc;}
    return (int)this->mmyState;							// 自分自身のexit()へ
}

/*!
 * @file          seqtype.cpp
 * @fn            int seqtype::exec(void* pArgs)
 * @brief         シーケンスあと処理
 * @details       TBD
 * @return        0 <  VALUE: シーケンス中断(TBD)
 *                0 == VALUE: 状態遷移コード(TBD)
 *                0 >  VALUE: 状態遷移コード
 * @date          2022/3/15
 * @note          ***
 */
int seqtype::exit(void* pArgs)
{
	return ESTATE::eSYST;
}

/*!
 * @file          seqtype.cpp
 * @fn            seqtype::command_pasiv(void)
 * @brief         PASVコマンド送信
 * @details       PORTコマンドに指定するPOT番号を取得することが目的
 * @return        0 <  VALUE: 異常終了(再起動シーケンス??)
 *                0 >= VALUE: 状態遷移コード(0～n)
 * @date          1970/3/4
 * @note          ***
 */
#if 0
int seqtype::command_pasiv(ftpsocket** pSOCKET, int *psiIP, int* psiPORT)
{
	int		        	rc;
	std::string         str_cmd;
	std::string         str_rsp;
	std::stringstream   ss;
	std::stringstream   ss2;
	std::string         str_left[3];                    // Entering Passive Mode
	std::string         str_ipport;                     // (192,168,11,37,154,146).
	int			        code;                           // 227
	int			        leng;
	char		        delim;

	ftpcmd*             ppasv = (ftpcmd*)0;

    ppasv = new ftpcmd(mpSOCKET, "PASV\x0d\x0a");
	if (ppasv == (ftpcmd*)0) {
		ecode	retobj(ecode::eVALUE::eNEW, __FUNCTION__, "0 = new ftpcmd(mpSOCKET, PASV)");
		retobj.output();
		rc = retobj.rc();								// 戻り値に変換
		return rc;
	}
	rc = ppasv->group1(str_rsp, (void*)0);              // PORT


	// str_rsp: 227 Entering Passive Mode (192,168,11,37,154,146).
	ss << str_rsp;
	ss >> code >> str_left[0] >> str_left[1] >> str_left[2] >> str_ipport;
														// Entering Passive Mode
	leng = str_ipport.size();							// (192,168,11,37,154,146).
	str_ipport.replace(0, 1, ",");						// ,192,168,11,37,154,146).
	str_ipport.replace(leng - 2, 2, ",");				// ,192,168,11,37,154,146,,

	// ipアドレスとportをint配列へ
	ss2 << str_ipport;
	ss2 >> delim >> *(psiIP  +0)
		>> delim >> *(psiIP  +1)
		>> delim >> *(psiIP  +2)
		>> delim >> *(psiIP  +3)
		>> delim >> *(psiPORT+0)
		>> delim >> *(psiPORT+1);
	return rc;
}
#endif
