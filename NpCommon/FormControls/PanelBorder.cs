using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NipponPaint.NpCommon.FormControls
{
    public partial class PanelBorder : UserControl
    {

        /// <summary>
        /// 枠線。
        /// </summary>
        private Color _borderColor = SystemColors.Control;

        /// <summary>
        /// 枠線
        /// </summary>
        public Color BorderColor
        {
            get { return this._borderColor; }
            set
            {
                this._borderColor = value;
            }
        }

        /// <summary>
        /// OnPaintイベント
        /// </summary>
        /// <param name="e">イベントデータ</param>
        protected override void OnPaint(PaintEventArgs e)
        {

            int right = this.ClientRectangle.Right - 1;
            int bottom = this.ClientRectangle.Bottom - 1;

            Pen pen = new Pen(this._borderColor,10);

            // 四角を描画
            Graphics g = this.CreateGraphics();
            g.DrawLine(pen, 0, 0, right, 0); // 上辺
            g.DrawLine(pen, 0, 0, 0, bottom); // 左辺
            g.DrawLine(pen, right, 0, right, bottom); // 右辺
            g.DrawLine(pen, 0, bottom, right, bottom); // 下辺
        }

        /// <summary>
        /// OnSizeChangedイベント
        /// </summary>
        /// <param name="e">イベントデータ</param>
        protected override void OnSizeChanged(EventArgs e)
        {
            // 描画をクリア
            this.Refresh();

            base.OnSizeChanged(e);
        }
        public PanelBorder()
        {
            InitializeComponent();
        }
    }
}
