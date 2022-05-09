using NipponPaint.OrderManager.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NipponPaint.OrderManager.ViewModels
{
    /// <summary>
    /// ビューモデル
    /// ラベルタイプダイアログ
    /// </summary>
    public class LabelEdit
    {
        /// <summary>
        /// ラベルタイプ
        /// </summary>
        public int LabelType { get; set; }

        // FrmLabelEditの処理切替用Parameter
        // 新規作成         0 を設定すること
        // 複製して新規作成 1 を設定すること
        // 修正             2 を設定すること
        public int Parameter{ get; set; }


        public LabelEdit()
        {
            
            //FrmLabelSelection frmLabelSelection = new FrmLabelSelection();
            //int.TryParse(frmLabelSelection.TxtLabelType.Value, out int labelType);
            //LabelType = labelType;
            //新規作成
            //複写して新規作成
            //修正

        }
    }
}
