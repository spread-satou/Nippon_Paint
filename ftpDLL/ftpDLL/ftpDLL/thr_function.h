#pragma once

//!	ORDファイル名サイズ
//	Ex. RFORDER2021100700382.OKY

//		プレフィックス	7byte		RFORDER
//		年月日			4+2+2byte	2021 10 07
//		通番			5byte		00382
//		ピリオド		1byte
//		拡張子			3byte
// -------------------------------------------------
//      合計			24byte
#define ORD_FNAMEEXT_SIZE		24
#define ORD_FNAME_SIZE			7+(4+2+2)+5

//class ftptest2
//{
//};
