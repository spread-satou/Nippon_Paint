using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NipponPaint.NpCommon
{
    public class GridViewSetting
    {
        public enum ColumnModeType
        {
            Numeric,
            String
        }
        /// <summary>
        /// データの種類
        /// </summary>
        public ColumnModeType ColumnType { get; set; }
        /// <summary>
        /// データベース上の列名
        /// </summary>
        public string ColumnName { get; set; }
        /// <summary>
        /// 画面上の列名
        /// （ヘッダテキスト）
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// 列の可視性
        /// </summary>
        public bool Visible { get; set; }
        /// <summary>
        /// 列幅
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// 配置
        /// </summary>
        public DataGridViewContentAlignment alignment { get; set; } = DataGridViewContentAlignment.MiddleLeft;
    }
}
