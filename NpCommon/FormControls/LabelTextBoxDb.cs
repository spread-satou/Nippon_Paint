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
    public partial class LabelTextBoxDb : UserControl
    {
        public TextBox ValueTextBox
        {
            get { return TxtValue; }
        }

        public string Code
        {
            get { return LblCode.Text; }
            set { LblCode.Text = value; }
        }
        public string Value
        {
            get { return TxtValue.Text; }
            set { TxtValue.Text = value; }
        }
        public int MaxByteLength
        {
            get { return TxtValue.MaxByteLength; }
            set { TxtValue.MaxByteLength = value; }
        }

        public string DatabaseColumnName { get; set; } = string.Empty;

        public LabelTextBoxDb()
        {
            InitializeComponent();
        }

        private void TxtValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtValue_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
