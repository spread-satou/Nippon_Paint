//*****************************************************************************
//
//  システム名：調色工場用自動計量システム NpCommon
//
//  Copyright 三菱電機エンジニアリング株式会社 2022 All rights reserved.
//
//-----------------------------------------------------------------------------
//  変更履歴:
//  Ver      日付        担当       コメント
//  0.0      2022/04/30  M.Nakai    新規作成
#region 更新履歴
#endregion
//*****************************************************************************

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
    /// ---------------------------------------------------------------------------------------
    /// <summary>
    ///     入力できる文字バイト数を制限できる TextBox コントロールを表します。
    /// </summary>
    /// ---------------------------------------------------------------------------------------
    public partial class TextBoxEx : System.Windows.Forms.TextBox
    {
        public int Id { get; set; }

        public string DatabaseColumnName { get; set; } = string.Empty;
        #region　コンストラクタ

        /// ---------------------------------------------------------------------------------------
        /// <summary>
        ///     MaxByteLengthTextBox コントロールの新しいインスタンスを初期化します。
        /// </summary>
        /// ---------------------------------------------------------------------------------------
        public TextBoxEx()
        {
            InitializeComponent();
            this.MaxByteLength = 65535;
        }

        #endregion

        #region　MaxByteLength プロパティ (virtual)

        private int _MaxByteLength;


        /// ---------------------------------------------------------------------------------------
        /// <summary>
        ///     ユーザーがテキスト ボックス コントロールに、
        ///     入力または貼り付けできる最大文字バイト数を取得または設定します。
        /// </summary>
        /// ---------------------------------------------------------------------------------------

        [Category("動作")]
        [DefaultValue(65535)]
        [Description("エディット コントロールに入力できる最大文字バイト数を指定します。")]
        public virtual int MaxByteLength
        {
            get
            {
                return this._MaxByteLength;
            }

            set
            {
                if (this._MaxByteLength != value)
                {
                    this._MaxByteLength = value;
                }
            }
        }

        #endregion


        #region　WndProc メソッド (override)

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            const int WM_CHAR = 0x0102;
            const int WM_PASTE = 0x0302;

            switch (m.Msg)
            {
                case WM_CHAR:
                    KeyPressEventArgs eKeyPress = new KeyPressEventArgs((char)(m.WParam.ToInt32()));
                    this.OnChar(eKeyPress);

                    if (eKeyPress.Handled)
                    {
                        return;
                    }

                    break;
                case WM_PASTE:
                    if (this.MaxLength * 2 > this.MaxByteLength)
                    {
                        this.OnPaste(new System.EventArgs());
                        return;
                    }

                    break;
            }

            base.WndProc(ref m);
        }

        #endregion


        #region　OnChar メソッド (virtual)

        protected virtual void OnChar(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            System.Text.Encoding sjisEncoding = System.Text.Encoding.GetEncoding("Shift_JIS");
            int textByteCount = sjisEncoding.GetByteCount(this.Text);
            int inputByteCount = sjisEncoding.GetByteCount(e.KeyChar.ToString());
            int selectedTextByteCount = sjisEncoding.GetByteCount(this.SelectedText);

            if ((textByteCount + inputByteCount - selectedTextByteCount) > this.MaxByteLength)
            {
                e.Handled = true;
            }
        }

        #endregion


        #region　OnPaste メソッド (virtual)

        protected virtual void OnPaste(System.EventArgs e)
        {
            object clipboardText = Clipboard.GetDataObject().GetData(System.Windows.Forms.DataFormats.Text);

            if (clipboardText == null)
            {
                return;
            }

            System.Text.Encoding sjisEncoding = System.Text.Encoding.GetEncoding("Shift_JIS");
            string inputText = clipboardText.ToString();
            int textByteCount = sjisEncoding.GetByteCount(this.Text);
            int inputByteCount = sjisEncoding.GetByteCount(inputText);
            int selectedTextByteCount = sjisEncoding.GetByteCount(this.SelectedText);
            int remainByteCount = this.MaxByteLength - (textByteCount - selectedTextByteCount);

            if (remainByteCount <= 0)
            {
                return;
            }

            if (remainByteCount >= inputByteCount)
            {
                this.SelectedText = inputText;
            }
            else
            {
                this.SelectedText = inputText.Substring(0, remainByteCount);
            }
        }

        #endregion

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
