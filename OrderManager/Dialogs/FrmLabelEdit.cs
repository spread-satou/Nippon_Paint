using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NipponPaint.NpCommon;
using NipponPaint.NpCommon.Database;
using NipponPaint.NpCommon.FormControls;
using Sql = NipponPaint.NpCommon.Database.Sql;

namespace NipponPaint.OrderManager.Dialogs
{
    public partial class FrmLabelEdit : BaseForm
    {
        private static int labelType;
        private static int parameter;
        private static DataTable dt;
        private static DataRow[] variableRows;
        private static DataRow[] fixedRows;
        private static DataRow[] moveRows;
        //picurebox1のパラメータ
        //倍率
        private double zoomRatio = 1.0d;
        //倍率変更後の画像のサイズと位置
        private Rectangle drawRectangle;
        private Bitmap canvas;
        private Bitmap preview;
        private Size previewSize;
        PrintDocument pd;
        #region
        public FrmLabelEdit(ViewModels.LabelEdit vm)
        {
            labelType = vm.LabelType;
            parameter = vm.Parameter;
            InitializeComponent();
            InitializeForm();
        }
        #endregion

        #region イベント
        /// <summary>
        /// ダイアログ表示後
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLabelEditShown(object sender, EventArgs e)
        {
            PutLog(Sentence.Messages.OpenMainForm);
        }

        /// <summary>
        /// フォントボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFont_Click(object sender, EventArgs e)
        {
            //FontDialogクラスの作成
            FontDialog fdlg = new FontDialog();
            //不要なフォント設定「文字飾り」を削除
            fdlg.ShowEffects = false;
            //フォントの選択ダイアログを表示する
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                //選択されたフォントをテキストボックスに設定する
                TxtFlaCaption.ValueTextBox.Font = fdlg.Font;
            }
        }
        /// <summary>
        /// プリントボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            //PrintDialogクラスの作成
            PrintDialog pdlg = new PrintDialog();
            pd = new PrintDocument();
            //PrintPageイベントハンドラの追加
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            
            //PrintDocumentを指定
            pdlg.Document = pd;
            //印刷の選択ダイアログを表示する
            if (pdlg.ShowDialog() == DialogResult.OK)
            {
                //OKがクリックされた時は印刷する
                pd.Print();
            }
        }

        /// <summary>
        /// 保存ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 閉じるボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                this.Close();
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        #endregion
        
        #region private functions

        #region 画面初期化
        /// <summary>
        /// 画面初期化
        /// </summary>
        private void InitializeForm()
        {
            // イベントの追加
            this.Shown += new System.EventHandler(this.FrmLabelEditShown);
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            this.Rbt100.CheckedChanged += new System.EventHandler(this.Rbt_CheckedChanged);
            this.Rbt80.CheckedChanged += new System.EventHandler(this.Rbt_CheckedChanged);
            this.Rbt60.CheckedChanged += new System.EventHandler(this.Rbt_CheckedChanged);
            this.Rbt40.CheckedChanged += new System.EventHandler(this.Rbt_CheckedChanged);
            this.NudVariableFieldID.ValueNumericUpDown.ValueChanged += new System.EventHandler(this.FieldID_ValueChanged);
            this.NudFixedFieldID.ValueNumericUpDown.ValueChanged += new System.EventHandler(this.FieldID_ValueChanged);
            this.NudMoveFieldID.ValueNumericUpDown.ValueChanged += new System.EventHandler(this.FieldID_ValueChanged);
            this.CmbFixedGroupID.DropDown.TextChanged += new System.EventHandler(this.CmbFixedGroupID_TextChanged);
            this.ChkFlaLogo.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            this.ChkToxLogo.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            this.TxtFlaCaption.BtnFont.Click += new EventHandler(this.BtnFont_Click);
            this.TxtToxCaption.BtnFont.Click += new EventHandler(this.BtnFont_Click);
            this.TxtVariableCaption.BtnFont.Click += new EventHandler(this.BtnFont_Click);
            this.TxtFixedCaption.BtnFont.Click += new EventHandler(this.BtnFont_Click);
            this.TxtMoveCaption.BtnFont.Click += new EventHandler(this.BtnFont_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);


            //画像ファイルを読み込んで、Imageオブジェクトとして取得する
            string baseBmpFilePath = Path.Combine(Application.StartupPath, "Product_Label", "Label_ONE.bmp");
            Image img = Image.FromFile(baseBmpFilePath);

            // 描画先とするImageオブジェクトを作成する
            canvas = new Bitmap(img.Width, img.Height);
            //ImageオブジェクトのGraphicsオブジェクトを作成する
            Graphics graphics = Graphics.FromImage(canvas);
            
            //倍率100 % で描画
            drawRectangle = new Rectangle(0, 0, img.Width, img.Height);

            //画像をcanvasの座標(0, 0)の位置に描画する
            graphics.DrawImage(img, drawRectangle);

            PreviewData();

            //Imageオブジェクトのリソースを解放する
            img.Dispose();
            //Graphicsオブジェクトのリソースを解放する
            graphics.Dispose();

            Rbt40.Checked = true;
        }
        #endregion

        /// <summary>
        /// 前ページラベルタイプIDに紐づくデータを取得してDataTableを作成する
        /// </summary>
        private void PreviewData()
        {
            using (var db = new SqlBase(SqlBase.DatabaseKind.ORDER, SqlBase.TransactionUse.No, Log.ApplicationType.OrderManager))
            {
                // ラベルタイプに紐づくデータ取得のSQLを作成
                var parameter = new List<ParameterItem>()
                {
                    new ParameterItem("labelType", labelType),
                };
                dt = db.Select(Sql.Order.LabelEdit.GetPreview(), parameter);
                dt.PrimaryKey = new DataColumn[] { dt.Columns["Field_Name"] };

                // フォームで定義された、取得値設定先のコントロールへ値を設定する
                //DataTableの値を各コントロールへ初期値として設定
                //ラベル詳細
                TxtLabel.Value = dt.Rows[0][TxtLabel.DatabaseColumnName].ToString().Trim();
                //日本ペイントロゴ
                bool npcLogo = (bool)dt.Rows[0]["NPC_Logo"];
                if (npcLogo)
                {
                    ChkNpLogo.Checked = true;
                }
                else
                {
                    ChkNpLogo.Checked = false;
                }
                //JISマーク
                bool jisLogo = (bool)dt.Rows[0]["JIS_Logo"];
                if (jisLogo)
                {
                    ChkJisLogo.Checked = true;
                }
                else
                {
                    ChkJisLogo.Checked = false;
                }
                //引火性
                string strFla = "FLA";
                int intFlaX = 0;
                int intFlaY = 0;
                DataRow[] flaRows = dt.Select("Field_Name = '" + strFla + "'");
                TxtFlaCaption.Value = flaRows[0][TxtFlaCaption.DatabaseColumnName].ToString().Trim();
                bool flaLogo = (bool)flaRows[0]["FLA_Logo"];
                if (flaLogo)
                {
                    ChkFlaLogo.Checked = true;
                    TxtFlaCaption.Visible = true;

                    bool bFlaX = int.TryParse(flaRows[0]["Position_X"].ToString(), out intFlaX);
                    bool bflaY = int.TryParse(flaRows[0]["Position_Y"].ToString(), out intFlaY);
                    //ImageオブジェクトのGraphicsオブジェクトを作成する
                    Graphics graphics = Graphics.FromImage(canvas);
                    //画像ファイルを読み込んで、Imageオブジェクトとして取得する
                    string bmpFilePath = Path.Combine(Application.StartupPath, "Product_Label", "FLA_Logo.bmp");
                    Image img = Image.FromFile(bmpFilePath);
                    //倍率100%で描画
                    Rectangle rectangle = new Rectangle(intFlaX, intFlaY, img.Width, img.Height);
                    ////倍率40%で描画
                    //Rectangle rectangle = new Rectangle(10, 10, (int)Math.Round(img.Width * zoomRatio), (int)Math.Round(img.Height * zoomRatio));
                    //画像をcanvasの指定座標の位置に描画する
                    graphics.DrawImage(img, rectangle);
                    //Imageオブジェクトのリソースを解放する
                    img.Dispose();
                    //Graphicsオブジェクトのリソースを解放する
                    graphics.Dispose();

                }
                else
                {
                    ChkFlaLogo.Checked = false;
                    TxtFlaCaption.Visible = false;
                }
                //可変フィールド
                string strTox = "TOX";
                DataRow[] toxRows = dt.Select("Field_Name = '" + strTox + "'");
                TxtToxCaption.Value = toxRows[0][TxtToxCaption.DatabaseColumnName].ToString().Trim();
                bool toxLogo = (bool)toxRows[0]["TOX_Logo"];
                if (toxLogo)
                {
                    ChkToxLogo.Checked = true;
                    TxtToxCaption.Visible = true;
                }
                else
                {
                    ChkToxLogo.Checked = false;
                    TxtToxCaption.Visible = false;
                }
                //Variable fields
                string strVariable = "V";
                variableRows = dt.Select("Field_Name Like '" + strVariable + "%'");
                decimal variableDec = Convert.ToDecimal(variableRows.Count());
                NudVariableFieldID.Maximum = variableDec;
                foreach (DataRow row in variableRows)
                {
                    if (row["Field_Name"].ToString() == strVariable + NudVariableFieldID.Value.ToString())
                    {
                        TxtVariableCaption.Value = row[TxtVariableCaption.DatabaseColumnName].ToString();
                    }
                }
                //固定グループ
                string[] strFixed = { "F", "G", "H", "L", "P", "S", "T" } ;
                CmbFixedGroupID.DropDown.Items.AddRange(strFixed);
                CmbFixedGroupID.DropDown.SelectedIndex = 0;

                //移動可能グループ
                string strMove = "A";
                moveRows = dt.Select("Field_Name Like '" + strMove + "%'");
                decimal decMove = Convert.ToDecimal(moveRows.Count());
                NudMoveFieldID.Maximum = decMove;
                foreach (DataRow row in moveRows)
                {
                    if(row["Field_Name"].ToString() == strMove + NudMoveFieldID.Value.ToString())
                    {
                        TxtMoveCaption.Value = row[TxtMoveCaption.DatabaseColumnName].ToString();
                        TxtMoveX.Value = row[TxtMoveX.DatabaseColumnName].ToString();
                        TxtMoveY.Value = row[TxtMoveY.DatabaseColumnName].ToString();
                    }
                }
            }
        }

        #region 印刷するページをPrintDocumentに描画する
        /// <summary>
        ///  印刷するページをPrintDocumentに描画する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {            
            //画像を描画する
            e.Graphics.DrawImage(canvas,e.PageBounds);
            
            //次のページがないことを通知する
            e.HasMorePages = false;
            //後始末をする
            canvas.Dispose();
        }
        #endregion

        #region ラベルボタンチェックでBitMap画像の倍率を変更する
        /// <summary>
        /// ラベルボタンチェックでBitMap画像の倍率を変更する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rbt_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                zoomRatio = 1d;
                //ソート順(LabelRadioBUttons)のグループ内のチェックされているラジオボタン(rbtCheckNum)を取得する
                var rbtCheckInGroup = GbxZoom.Controls.OfType<RadioButton>()
                    .SingleOrDefault(rb => rb.Checked == true);
                bool rbtCheck = int.TryParse(rbtCheckInGroup.Text, out int rbtCheckNum);
                switch (rbtCheckInGroup.Name)
                {
                    case "Rbt40":
                        zoomRatio *= 0.4d;
                        break;
                    case "Rbt60":
                        zoomRatio *= 0.6d;
                        break;
                    case "Rbt80":
                        zoomRatio *= 0.8d;
                        break;
                    case "Rbt100":
                        zoomRatio *= 1.0d;
                        break;
                    default:
                        zoomRatio *= 0.4d;
                        break;
                }
                previewSize = new Size((int)Math.Round(canvas.Width * zoomRatio), (int)Math.Round(canvas.Height * zoomRatio));
                //倍率100 % で描画
                drawRectangle.Width = (int)Math.Round(canvas.Width * zoomRatio);
                drawRectangle.Height = (int)Math.Round(canvas.Height * zoomRatio);

                preview = new Bitmap(canvas, previewSize);
                ////画像を 無効化して再表示する
                pictureBox1.Invalidate();
                    //画像を表示する
                    //pictureBox1.Image = preview;
            }
        }
        #endregion

        #region Numericコントロールのフィールド数値変更
        /// <summary>
        /// Numericコントロールのフィールド数値変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FieldID_ValueChanged(object sender, EventArgs e)
        {
            string strfField = string.Empty;
            DataRow[] rows = null;
            DataRow selectRow = null;
            string controlName = string.Empty;
            var numericUpDown = sender as NumericUpDown;
            switch (numericUpDown.Parent.Name)
            {
                case "NudVariableFieldID":
                    strfField = "V";
                    rows = variableRows;
                    controlName = "TxtVariableCaption";
                    break;
                case "NudFixedFieldID":
                    strfField = CmbFixedGroupID.DropDown.Text;
                    rows = fixedRows;
                    controlName = "TxtFixedCaption";
                    break;
                case "NudMoveFieldID":
                    strfField = "A";
                    rows = moveRows;
                    controlName = "TxtMoveCaption";
                    break;
                default:
                    break;
            }
            // Field_Nameを用いて一行を取得する
            foreach (DataRow row in rows)
            {
                if (row["Field_Name"].ToString() == strfField + numericUpDown.Value.ToString())
                {
                    selectRow = row;
                }
            }
            // LabelTextButtonコントロールを探す処理
            var controls = new List<Control>();
            Funcs.FindControls(this.Controls, controls);
            foreach (Control control in controls)
            {
                switch (control)
                {
                    case LabelTextButton labelTextButton:
                        //指定のコントロール選択されているか
                        if(labelTextButton.Name != controlName)
                        {
                            break;
                        }
                        //指定のFieldNameがDataRow[]に存在するか
                        if (selectRow == null)
                        {
                            labelTextButton.Value = string.Empty;
                            break;
                        }
                        //DatabaseColumnNameが指定されているか
                        if (!string.IsNullOrEmpty(labelTextButton.DatabaseColumnName))
                        {
                            labelTextButton.Value = selectRow[labelTextButton.DatabaseColumnName].ToString().Trim();
                        }
                        break;
                    case LabelTextBox labelTextBox:
                        //移動可能グループのNumericUpDownコントロールの値が変更された時
                        if (numericUpDown.Parent.Name != "NudMoveFieldID")
                        {
                            break;
                        }
                        //指定のFieldNameがDataRow[]に存在するか
                        if (selectRow == null)
                        {
                            labelTextBox.Value = string.Empty;
                            break;
                        }
                        //DatabaseColumnNameが指定されているか
                        if(string.IsNullOrEmpty(labelTextBox.DatabaseColumnName))
                        {
                            break;
                        }
                        if(labelTextBox.Name == "TxtMoveX" || labelTextBox.Name == "TxtMoveY")
                        {
                            labelTextBox.Value = selectRow[labelTextBox.DatabaseColumnName].ToString().Trim();
                        }
                        break;
                    default:
                        break;
                }
            }
            
        }
        #endregion

        #region　ComboBoxコントロールのグループID変更
        /// <summary>
        /// ComboBoxコントロールのグループID変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbFixedGroupID_TextChanged(object sender, EventArgs e)
        {
            var regex = new Regex(CmbFixedGroupID.DropDown.Text + "[0-9]{1,}");
            //グループIDの毎のFieldNameの数量を取得
            fixedRows = dt.AsEnumerable().Where(Item => regex.IsMatch(Item["Field_Name"].ToString())).ToArray();
            decimal decFixed = Convert.ToDecimal(fixedRows.Count());
            NudFixedFieldID.Maximum = decFixed;
            NudFixedFieldID.Value = NudFixedFieldID.Minimum;

            //FieldNameがグループID + 1(Minimum)のであるCaptionの値を取得する
            foreach (DataRow row in fixedRows)
            {
                if (row["Field_Name"].ToString() == CmbFixedGroupID.DropDown.Text + NudFixedFieldID.Value.ToString())
                {
                    TxtFixedCaption.Value = row[TxtFixedCaption.DatabaseColumnName].ToString();
                }
            }
        }
        #endregion

        #region 引火性CheckBox,可変フィールドCheckBoxのチェック時
        /// <summary>
        /// 引火性CheckBox,可変フィールドCheckBoxのチェック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;
            switch (checkBox.Name)
            {
                //引火性CheckBoxをチェックした場合
                case "ChkFlaLogo":
                    if (ChkFlaLogo.Checked)
                    {
                        TxtFlaCaption.Visible = true;
                    }
                    else
                    {
                        TxtFlaCaption.Visible = false;
                    }
                    break;
                //可変フィールドCheckBoxをチェックした場合
                case "ChkToxLogo":
                    if (ChkToxLogo.Checked)
                    {
                        TxtToxCaption.Visible = true;
                    }
                    else
                    {
                        TxtToxCaption.Visible = false;
                    }
                    break;
            }
        }

        #endregion

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (preview != null)
            {
                //画像を指定された位置、サイズで描画する
                pictureBox1.Size = previewSize;
                e.Graphics.DrawImage(preview, drawRectangle);
            }
        }

        #endregion



    }
}
