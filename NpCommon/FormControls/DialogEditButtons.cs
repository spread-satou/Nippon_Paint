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
using System.Windows.Forms;
#endregion

namespace NipponPaint.NpCommon.FormControls
{
    public partial class DialogEditButtons : UserControl
    {
        public enum Mode
        {
            /// <summary>
            /// 表示中
            /// </summary>
            View,
            /// <summary>
            /// 新規作成
            /// </summary>
            Create,
            /// <summary>
            /// 修正
            /// </summary>
            Modify,
            /// <summary>
            /// 削除
            /// </summary>
            Delete,
        }

        public Mode EditMode { get; set; } = Mode.View;

        //新規作成
        public Button Create
        {
            get { return BtnCreate; }
        }

        //修正
        public Button Modify
        {
            get { return BtnModify; }
        }

        //削除
        public Button Delete
        {
            get { return BtnDelete; }
        }

        //終了
        public Button Exit
        {
            get { return BtnExit; }
        }

        //OK
        public Button Regist
        {
            get { return BtnOk; }
        }

        //キャンセル
        public Button Cancel
        {
            get { return BtnCancel; }
        }
        
        public delegate void Func();

        public Func InsertMethod { get; set; } = null;
        public Func UpdateMethod { get; set; } = null;
        //public Func DeleteMethod { get; set; } = null;

        public Func<bool> ValidationMethod { get; set; } = null;

        public Func<bool> MsgMethod { get; set; } = null;

        public DialogEditButtons()
        {
            InitializeComponent();
            BtnOk.Location = BtnDelete.Location;
            BtnCancel.Location = BtnExit.Location;
            ChangeMode(Mode.View);
            ChangeButton();
        }

        //新規作成ボタン
        private void BtnCreate_Click(object sender, System.EventArgs e)
        {
            ChangeMode(Mode.Create);
            ChangeButton();
        }

        //修正ボタン
        private void BtnModify_Click(object sender, System.EventArgs e)
        {
            ChangeMode(Mode.Modify);
            ChangeButton();
        }

        //削除ボタン
        private void BtnDelete_Click(object sender, System.EventArgs e)
        {
            ChangeMode(Mode.View);
            ChangeButton();
        }

        //終了ボタン
        private void BtnExit_Click(object sender, System.EventArgs e)
        {
        }

        //OKボタン
        private void BtnOk_Click(object sender, System.EventArgs e)
        {
            bool result = false;
            bool modeChangeFlg = false;
            if (ValidationMethod != null)
            { 
                result = ValidationMethod(); 
            }

            if (result)
            {
                switch (EditMode)
                {
                    case Mode.Create:
                        if (InsertMethod != null) { InsertMethod(); }
                        break;
                    case Mode.Modify:
                        if (UpdateMethod != null) { UpdateMethod(); }
                        break;
                    default:
                        break;
                }
                modeChangeFlg = true;
            }
            else
            {
                if (MsgMethod != null) 
                {
                    modeChangeFlg = MsgMethod(); 
                }
            }

            if (modeChangeFlg)
            {
                ChangeMode(Mode.View);
                ChangeButton();
            }
        }

        //キャンセルボタン
        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            ChangeMode(Mode.View);
            ChangeButton();
        }

        private void ChangeMode(Mode editMode)
        {
            EditMode = editMode;
        }

        private void ChangeButton()
        {
            switch (EditMode)
            {
                case Mode.View:
                    BtnCreate.Visible = true;
                    BtnModify.Visible = true;
                    BtnDelete.Visible = true;
                    BtnExit.Visible = true;
                    BtnOk.Visible = false;
                    BtnCancel.Visible = false;
                    break;
                default:
                    BtnCreate.Visible = false;
                    BtnModify.Visible = false;
                    BtnDelete.Visible = false;
                    BtnExit.Visible = false;
                    BtnOk.Visible = true;
                    BtnCancel.Visible = true;
                    break;
            }
        }

    }
}
