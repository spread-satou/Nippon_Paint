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
using System.Text;
using System.Threading.Tasks;
#endregion

namespace NipponPaint.NpCommon.Attributes
{
    public static class AttributeUtility
    {
        //
        // T で指定したプロパティを1つだけ取得
        //

        // 型を指定して Public プロパティの属性を取得する
        public static object GetPropertyAttribute(Type type, string name)
        {
            var prop = type.GetProperty(name);
            if (prop == null)
            {
                //Trace.WriteLine($"Property is not found. {name}");
                return default; // 指定したプロパティが見つからない
            }
            //var att = prop.GetCustomAttribute<T>();
            var att = prop.GetCustomAttributes(false);
            if (att == null || !att.Any())
            {
                //Trace.WriteLine($"Attribute is not found. {name}");
                return default; // 指定した属性が付与されていない
            }
            return att[0];
        }

        //
        // プロパティについている属性を全部取得
        //

        //// インスタンスを指定して Public プロパティの属性を取得します。
        //public static T GetPropertyAttribute<T>(object instance, string name) where T : Attribute
        //{
        //    return GetPropertyAttribute<T>(instance.GetType(), name);
        //}

        // 型を指定して Public プロパティに付与されているすべてのプロパティを取得する
        public static object[] GetPropertyAttributes(Type type, string name)
        {
            var prop = type.GetProperty(name);
            if (prop == null)
            {
                //Trace.WriteLine($"Property is not found. {name}");
                return default;
            }

            return prop.GetCustomAttributes(false);
        }

        //// インスタンスを指定して Public プロパティに付与されているすべてのプロパティを取得する
        //public static IEnumerable<Attribute> GetPropertyAttributes(object instance, string name)
        //{
        //    return GetPropertyAttributes(instance.GetType(), name);
        //}

        public static string DatabaseField(Type type, string name)
        {
            var attribute = GetPropertyAttribute(type, name);
            return ((DatabaseFieldAttribute)attribute).DatabaseField;
        }
    }
}
