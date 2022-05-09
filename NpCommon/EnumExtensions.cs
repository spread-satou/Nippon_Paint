//*****************************************************************************
//
//  システム名：調色工場用自動計量システム NpCommon
//
//  Copyright 三菱電機エンジニアリング株式会社 2022 All rights reserved.
//
//-----------------------------------------------------------------------------
//  変更履歴:
//  Ver      日付        担当       コメント
//  0.0      2022/04/30  A.Satou    新規作成
#region 更新履歴
#endregion
//*****************************************************************************

#region using defines
using System;
using System.Collections.Generic;
using System.Linq;
#endregion

namespace NipponPaint.NpCommon
{
    public static class EnumExtensions
    {
        /// <summary>
        /// enumに適用されている属性を取得
        /// </summary>
        /// <typeparam name="TAttribute"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IEnumerable<TAttribute> GetApplied<TAttribute>(this Enum value) where TAttribute : Attribute
        {
            return value
                .GetType()
                .GetField(value.ToString())
                .GetCustomAttributes(false)
                .OfType<TAttribute>();
        }
    }
}
