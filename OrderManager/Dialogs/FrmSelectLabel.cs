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
using System.Data;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using NipponPaint.NpCommon;
using NipponPaint.NpCommon.FormControls;
#endregion

namespace NipponPaint.OrderManager.Dialogs
{
    /// <summary>
    /// ラベルダイアログ
    /// </summary>
    public partial class FrmSelectLabel : BaseForm
    {
        #region コンストラクタ
        public FrmSelectLabel()
        {
            InitializeComponent();
            InitializeForm();
        }
        #endregion

        #region イベント
        /// <summary>
        /// 保存ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSaveClick(object sender, EventArgs e)
        {
           　try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                MessageBox.Show("設定内容を保存しました。");
                this.Close();
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }

        /// <summary>
        /// 閉じるボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BtnCloseClick(object sender, EventArgs e)
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

        #region 画面の初期化
        /// <summary>
        /// 画面の初期化
        /// </summary>
        private void InitializeForm()
        {
            // イベントの追加
            this.BtnSave.Click += new EventHandler(this.BtnSaveClick);
            this.BtnClose.Click += new EventHandler(this.BtnCloseClick);
            this.TreeViewSelectFolder.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeViewSelectFolder_BeforeExpand);
            this.DropDownSelectFolder.SelectedIndexChanged += new System.EventHandler(this.DropDownSelectFolder_SelectedIndexChanged);
            CreateDataTable();

            //string d = Application.StartupPath;
            ////char[] seps = { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar };
            //char seps = Path.DirectorySeparatorChar;
            //string[] paths = d.Split(seps);
            //TreeNode tn = new TreeNode(paths[0] + "\\");
            //TreeViewSelectFolder.Nodes.Clear();
            //TreeViewSelectFolder.Nodes.Add(tn);//親ノードにドライブを設定
            //int cnt = 0;
            //tn.Nodes.Add("...");//架空の枝を追加
            //foreach (string path in paths)
            //{
            //    if (cnt != 0)
            //    {
            //        TreeNode newNode = new TreeNode(path);
            //        tn.Nodes.Add(newNode);
            //        tn = newNode;
            //        tn.Nodes.Add("...");//架空の枝を追加
            //                            //tn.Nodes.Clear();
            //        tn.Expand();
            //    }
            //    cnt++;
            //}
        }
        #endregion

        private void CreateDataTable()
        {
            //データテーブルを作成
            DataTable dt = new DataTable("drive");
            //データテーブルの列を作成
            DataColumn volume = new DataColumn("Volume");
            DataColumn name = new DataColumn("Value");
            dt.Columns.Add(volume);
            dt.Columns.Add(name);

            //データテーブルの行を作成
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    DataRow dr;
                    dr = dt.NewRow();
                    dr["Volume"] = drive.ToString().Replace("\\", "") + "[" + drive.VolumeLabel + "]";
                    dr["Value"] = drive;

                    dt.Rows.Add(dr);
                }
                else
                {
                    DataRow dr;
                    dr = dt.NewRow();
                    dr["Volume"] = drive.ToString().Replace("\\", "");
                    dr["Value"] = drive;

                    dt.Rows.Add(dr);
                }
            }
            DropDownSelectFolder.DisplayMember = "Volume";
            DropDownSelectFolder.ValueMember = "Value";
            DropDownSelectFolder.DataSource = dt;
            DropDownSelectFolder.SelectedIndex = 0;
        }

        #region ＋ボタン押下時の処理
        /// <summary>
        /// ＋ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeViewSelectFolder_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode tn = e.Node, tn2;
            //展開するノードのフルパスを取得
            string d = tn.FullPath;
            tn.Nodes.Clear();

            //選択したノード以外のノードを削除する
            while (tn.PrevNode != null)
            {
                tn.PrevNode.Remove();
            }
            while(tn.NextNode != null)
            {
                tn.NextNode.Remove();
            }

            //ディレクトリ一覧を取得
            DirectoryInfo di = new DirectoryInfo(d);
            
            foreach (DirectoryInfo d2 in di.GetDirectories("*", SearchOption.TopDirectoryOnly))
            {

                if((d2.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {
                    tn2 = new TreeNode(d2.Name);
                    tn.Nodes.Add(tn2);
                    tn2.Nodes.Add("...");
                }
                
            }

            LabelTextChange(tn);
        }
        #endregion

        #region ドロップダウンリスト選択切り替え毎の処理
        /// <summary>
        /// ドロップタウンリスト選択切り替え毎の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DropDownSelectFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            TreeViewSelectFolder.Nodes.Clear();
            TreeNode tn = new TreeNode(DropDownSelectFolder.SelectedValue.ToString());
            TreeViewSelectFolder.Nodes.Add(tn);//親ノードにドライブを設定
            tn.Nodes.Add("...");//架空の枝を追加

            LabelTextChange(tn);
        }
        #endregion

        #region 
        /// <summary>
        /// Labelコントロールの値を変更する
        /// </summary>
        /// <param name="tn"></param>
        private void LabelTextChange(TreeNode tn)
        {
            string d = tn.FullPath;
            Lbl.Text = d;
        }
        #endregion

        #endregion

        //TreeViewSelectFolder.Nodes[0].Nodes.Clear();
        //TreeNode tn = TreeViewSelectFolder.Nodes[0];

        //string d = Application.StartupPath;

        //if (Directory.Exists(d) == false) return;

        //DirectoryInfo directory = new DirectoryInfo(d);

        //DirectoryInfo[] subDirectories = directory.GetDirectories();
        //foreach (DirectoryInfo subDirectory in subDirectories)
        //{
        //    while(newNode.Parent != null)
        //    {
        //        TreeNode newNode = tn.Nodes.Add(subDirectory.Name);
        //    }
        //    newNode.ImageIndex = 0;
        //    newNode.SelectedImageIndex = 0;
        //}
        //Lbl.Text = d;
    }
}
