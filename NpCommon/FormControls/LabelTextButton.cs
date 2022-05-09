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
    public partial class LabelTextButton : UserControl
    {
        public string Id { get; set; }

        public TextBox ValueTextBox
        {
            get { return TxtData; }
        }

        public string TitleControlName
        {
            get { return LblTitle.Name; }
            set { LblTitle.Name = value; }
        }

        public string Title
        {
            get { return LblTitle.Text; }
            set { LblTitle.Text = value; }
        }

        public Size TitleSize
        {
            get { return LblTitle.Size; }
            set { LblTitle.Size = value; }
        }

        public Point DataTextLocation
        {
            get { return TxtData.Location; }
            set { TxtData.Location = value; }
        }

        public Size DataTextSize
        {
            get { return TxtData.Size; }
            set { TxtData.Size = new Size(value.Width, value.Height); }
        }

        public Point BtnLocation
        {
            get { return BtnFontChange.Location; }
            set { BtnFontChange.Location = value; }
        }

        public Size BtnSize
        {
            get { return BtnFontChange.Size; }
            set { BtnFontChange.Size = new Size(value.Width, value.Height); }
        }

        public string DataControlName
        {
            get { return TxtData.Name; }
            set { TxtData.Name = value; }
        }

        

        public string BtnName
        {
            get { return BtnFontChange.Text; }
            set { BtnFontChange.Text = value; }
        }

        public string Value
        {
            get { return TxtData.Text; }
            set { TxtData.Text = value; }
        }

        public Button BtnFont
        {
            get { return BtnFontChange; }
        }

        public string DatabaseColumnName { get; set; } = string.Empty;

        public LabelTextButton()
        {
            InitializeComponent();
        }
    }
}
