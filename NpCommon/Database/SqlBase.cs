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
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using NipponPaint.NpCommon.FormControls;
using System.Linq;
#endregion

namespace NipponPaint.NpCommon.Database
{
    /// <summary>
    /// データベース処理クラス
    /// </summary>
    public class SqlBase : IDisposable
    {
        #region 定数
        /// <summary>
        /// トランザクション使用有無
        /// </summary>
        public enum TransactionUse
        {
            /// <summary>
            /// トランザクションを使用する
            /// </summary>
            Yes,
            /// <summary>
            /// トランザクションを使用しない
            /// </summary>
            No
        }

        /// <summary>
        /// データベース種別
        /// </summary>
        public enum DatabaseKind
        {
            /// <summary>
            /// IOS
            /// </summary>
            IOS,
            /// <summary>
            /// IOSSUP
            /// </summary>
            IOSSUP,
            /// <summary>
            /// NPMAIN
            /// </summary>
            NPMAIN,
            /// <summary>
            /// ORDER
            /// </summary>
            ORDER,
            /// <summary>
            /// SupervisionPC
            /// </summary>
            SUPERVISION,
        }

        private const int TIMEOUT_VALUE = 120;
        #endregion

        #region メンバ変数
        private bool _disposed { get; set; } = false;
        private SqlConnection _connection { get; set; } = null;
        private SqlTransaction _transaction { get; set; } = null;
        private int _registCount { get; set; } = 0;
        private Log.ApplicationType _applicationType { get; set; }
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="databaseKind"></param>
        /// <param name="transatctionUse"></param>
        /// <param name="applicationType"></param>
        public SqlBase(DatabaseKind databaseKind, TransactionUse transatctionUse, Log.ApplicationType applicationType)
        {
            // iniファイルからデータベース接続文字列を取得する
            var settings = new IniFile.Settings();
            // データベースを切り替える
            var catalog = string.Empty;
            switch (databaseKind)
            {
                case DatabaseKind.NPMAIN:
                    catalog = settings.Database.NpMain;
                    break;
                case DatabaseKind.IOSSUP:
                    catalog = settings.Database.IosSup;
                    break;
                case DatabaseKind.ORDER:
                    catalog = settings.Database.NpOrder;
                    break;
                case DatabaseKind.SUPERVISION:
                    catalog = settings.Database.SuperVision;
                    break;
            }
            // コネクションを開く
            _connection = new SqlConnection(catalog);
            _connection.Open();
            if (transatctionUse == TransactionUse.Yes)
            {
                _transaction = _connection.BeginTransaction();
            }
            _registCount = 0;
            _applicationType = applicationType;
        }
        #endregion

        #region ディスポーザ
        /// <summary>
        /// ディスポーザ
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        /// <summary>
        /// ディスポーザ
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (_transaction != null)
                {
                    // 更新処理を行った後、commitもrollbackもされていない時はrollbackする
                    if (_registCount > 0)
                    {
                        _transaction.Rollback();
                    }
                    _transaction.Dispose();
                    _transaction = null;
                }
                if (disposing)
                {
                    _connection.Close();
                }
                _disposed = true;
            }
        }
        #endregion

        #region デストラクタ
        /// <summary>
        /// デストラクタ
        /// </summary>
        ~SqlBase()
        {
            Dispose(false);
        }
        #endregion

        #region public functions

        #region トランザクション処理
        /// <summary>
        /// トランザクションのコミット
        /// </summary>
        public void Commit()
        {
            if (_transaction != null)
            {
                _transaction.Commit();
                _registCount = 0;
            }
        }

        /// <summary>
        /// トランザクションのロールバック
        /// </summary>
        public void Rollback()
        {
            if (_transaction != null)
            {
                _transaction.Rollback();
                _registCount = 0;
            }
        }
        #endregion

        #region Sqlパラメータ作成
        /// <summary>
        /// Sqlパラメータを作成する
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static SqlParameter ToSqlParam(ParameterItem item)
        {
            return new SqlParameter(item.Key, item.Value);
        }
        #endregion

        public static List<SqlParameter> ToSqlParams(List<ParameterItem> SqlParameters)
        {
            var result = new List<SqlParameter>();
            foreach (var item in SqlParameters)
            {
                result.Add(ToSqlParam(item));
            }
            return result;
        }

        #region 更新系クエリ実行
        /// <summary>
        /// クエリ実行
        /// （更新系）
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public int Execute(string sql, List<ParameterItem> parameters = null)
        {
            return Execute(sql, ToSqlParams(parameters));
        }
        #endregion

        #region 更新系クエリ実行
        /// <summary>
        /// クエリ実行
        /// （更新系）
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public int Execute(string sql, List<SqlParameter> parameters = null)
        {
            var result = -1;
            using (SqlCommand cmd = new SqlCommand(sql, _connection, _transaction))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                }
                result = cmd.ExecuteNonQuery();
            }
            _registCount += result;
            return result;
        }
        #endregion

        #region 参照クエリ実行
        /// <summary>
        /// Select SQL 実行
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable Select(string sql, List<ParameterItem> parameters = null)
        {
            var dt = new DataTable();
            //using (var command = _connection.CreateCommand())
            //{
            //    command.CommandText = sqlString;
            //    var adapter = new SqlDataAdapter(command);
            //    adapter.Fill(dt);
            //}
            using (var cmd = new SqlCommand(sql, _connection))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }
                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            Log.Write(Sentence.Messages.SelectedDatabase, _applicationType, sql);
            return dt;
        }

        /// <summary>
        /// Select SQL 実行
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable Select(StringBuilder sql, List<ParameterItem> parameters = null)
        {
            return Select(sql.ToString(), parameters);
        }
        #endregion

        #endregion

        #region データベースから画面コントロールへの反映処理

        #region データベースから取得した値を、画面上のLabelTextBoxコントロールにセットする
        /// <summary>
        /// データベースから取得した値を、画面上のLabelTextBoxコントロールにセットする
        /// </summary>
        /// <param name="formControls"></param>
        /// <param name="rows"></param>
        public void ToLabelTextBox(Control.ControlCollection formControls, DataRowCollection rows)
        {
            // データベースから取得した値を、画面上のLabelTextBoxコントロールにセットする
            var controls = new List<Control>();
            Funcs.FindControls(formControls, controls);
            foreach (var control in controls)
            {
                switch (control)
                {
                    case LabelTextBox labelTextBox:
                        // LabelTextBoxコントロールへの設定
                        if (!string.IsNullOrEmpty(labelTextBox.DatabaseColumnName))
                        {
                            labelTextBox.Value = rows[0][labelTextBox.DatabaseColumnName].ToString().Trim();
                        }
                        break;
                    case LabelCodeText labelCodeText:
                        // LabelCodeTextコントロールへの設定
                        if (!string.IsNullOrEmpty(labelCodeText.DatabaseColumnCode))
                        {
                            labelCodeText.CodeText = rows[0][labelCodeText.DatabaseColumnCode].ToString().Trim();
                        }
                        if (!string.IsNullOrEmpty(labelCodeText.DatabaseColumnName))
                        {
                            labelCodeText.Text = rows[0][labelCodeText.DatabaseColumnName].ToString().Trim();
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region データベースから取得した値を、画面上のLabelDropDownコントロールにセットする
        /// <summary>
        /// データベースから取得した値を、画面上のLabelDropDownコントロールにセットする
        /// </summary>
        /// <param name="formControls"></param>
        /// <param name="rows"></param>
        public void ToLabelDropDown(Control.ControlCollection formControls, DataRowCollection rows)
        {
            // データベースから取得した値を、画面上のLabelTextBoxコントロールにセットする
            var controls = new List<Control>();
            Funcs.FindControls(formControls, controls);
            foreach (var control in controls)
            {
                switch (control)
                {
                    case LabelDropDown labelDropDown:
                        // LabelTextBoxコントロールへの設定
                        if (!string.IsNullOrEmpty(labelDropDown.DatabaseColumnName))
                        {
                            if (labelDropDown.DropDown.SelectedValue != null)
                            {
                                labelDropDown.DropDown.SelectedValue = rows[0][labelDropDown.DatabaseColumnName].ToString().Trim();
                            }
                            else
                            {
                                labelDropDown.DropDown.SelectedItem = rows[0][labelDropDown.DatabaseColumnName].ToString().Trim();
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region データベースから取得した値を、画面上のLabelNumericUpDownコントロールにセットする
        /// <summary>
        /// データベースから取得した値を、画面上のLabelNumericUpDownコントロールにセットする
        /// </summary>
        /// <param name="formControls"></param>
        /// <param name="rows"></param>
        public void ToLabelNumericUpDown(Control.ControlCollection formControls, DataRowCollection rows)
        {
            // データベースから取得した値を、画面上のLabelTextBoxコントロールにセットする
            var controls = new List<Control>();
            Funcs.FindControls(formControls, controls);
            foreach (var control in controls)
            {
                switch (control)
                {
                    case LabelNumericUpDown labelNumericUpDown:
                        // LabelTextBoxコントロールへの設定
                        if (!string.IsNullOrEmpty(labelNumericUpDown.DatabaseColumnName))
                        {
                            decimal.TryParse(rows[0][labelNumericUpDown.DatabaseColumnName].ToString().Trim(), out decimal decResult);
                            labelNumericUpDown.Value = decResult;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #endregion

        #region 画面コントロールからデータベースへの反映処理

        #region 画面上のLabelTextBoxDbコントロールの値をデータベースへ登録する
        /// <summary>
        /// 画面上のLabelTextBoxDbコントロールの値をデータベースへ登録する
        /// </summary>
        /// <param name="formControls"></param>
        /// <param name="tableName"></param>
        /// <param name="dataColumnName"></param>
        /// <param name="keyColumnName"></param>
        public void FromLabelTextBoxDb(Control.ControlCollection formControls,
                                       string tableName,
                                       string dataColumnName,
                                       string keyColumnName)
        {
            // フォームで定義された、取得値設定先のコントロールを抽出する
            var controls = new List<Control>();
            Funcs.FindControls(formControls, controls);
            foreach (var control in controls)
            {
                switch (control)
                {
                    case LabelTextBoxDb labelTextBoxDb:
                        if (!string.IsNullOrEmpty(labelTextBoxDb.Code))
                        {
                            var parameters = new List<ParameterItem>()
                            {
                                new ParameterItem("Text", labelTextBoxDb.Value),
                                new ParameterItem("Code", labelTextBoxDb.Code),
                            };
                            // 更新のSQLを作成
                            Execute($"UPDATE {tableName} SET {dataColumnName} = @Text WHERE {keyColumnName} = @Code", ToSqlParams(parameters));
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region 画面上のLabelColorDiaLogコントロールの値をデータベースへ登録する
        /// <summary>
        /// 画面上のLabelColorDiaLogコントロールの値をデータベースへ登録する
        /// </summary>
        /// <param name="formControls"></param>
        /// <param name="tableName"></param>
        /// <param name="dataColumnName"></param>
        /// <param name="keyColumnName"></param>
        public void FromLabelColorsDiaLog(Control.ControlCollection formControls,
                                       string tableName,
                                       string dataColumnName,
                                       string keyColumnName)
        {
            // フォームで定義された、取得値設定先のコントロールを抽出する
            var controls = new List<Control>();
            Funcs.FindControls(formControls, controls);
            foreach (var control in controls)
            {
                switch (control)
                {
                    case LabelColorDiaLog labelColorDiaLog:
                        if (!string.IsNullOrEmpty(labelColorDiaLog.Code))
                        {
                            var parameters = new List<ParameterItem>()
                            {
                                new ParameterItem("ColorCode", labelColorDiaLog.ColorCode),
                                new ParameterItem("Code", labelColorDiaLog.Code),
                            };
                            // 更新のSQLを作成
                            Execute($"UPDATE {tableName} SET {dataColumnName} = @ColorCode WHERE {keyColumnName} = @Code", ToSqlParams(parameters));
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region 画面上のDeliveryClassificationコントロールの値をデータベースへ登録する
        /// <summary>
        /// 画面上のDeliveryClassificationコントロールの値をデータベースへ登録する
        /// </summary>
        /// <param name="formControls"></param>
        /// <param name="tableName"></param>
        /// <param name="dataColumnName1"></param>
        /// <param name="dataColumnName2"></param>
        /// <param name="dataColumnName3"></param>
        /// <param name="dataColumnName4"></param>
        /// <param name="keyColumnName"></param>
        public void FromDeliveryClassification(Control.ControlCollection formControls,
                                       string tableName,
                                       string dataColumnName1,
                                       string dataColumnName2,
                                       string dataColumnName3,
                                       string dataColumnName4,
                                       string keyColumnName
            )
        {
            // フォームで定義された、取得値設定先のコントロールを抽出する
            var controls = new List<Control>();
            Funcs.FindControls(formControls, controls);
            foreach (var control in controls)
            {
                switch (control)
                {
                    case DeliveryClassification deliveryClassification:
                        if (!string.IsNullOrEmpty(deliveryClassification.PanelNumber.ToString()))
                        {
                            StringBuilder query = new StringBuilder();
                            query.AppendLine($"UPDATE");
                            query.AppendFormat($" {tableName}");
                            query.AppendLine($" SET");
                            query.AppendFormat($" {dataColumnName1} = @Text");
                            query.AppendFormat($",{dataColumnName2} = @DTP");
                            query.AppendFormat($",{dataColumnName3} = @RbtCheckState");
                            query.AppendFormat($",{dataColumnName4} = @CheckState");
                            query.AppendLine($" WHERE");
                            query.AppendFormat($" {keyColumnName} = @PanelNum");

                            #region Sqlパラメータにセットする変数を準備
                            //配送モード(LabelTextBox)の値を変数(strText)にセットする
                            string strText = deliveryClassification.LblTxtBoxValue;

                            //出荷時間(LabelDateTimePicker)からDBにセットする日時(settinfDate)を準備する
                            DateTime now = DateTime.Now;
                            DateTime ValueDtp = deliveryClassification.LblDTPValue;
                            DateTime settingDate = new DateTime(now.Year, now.Month, now.Day, ValueDtp.Hour, ValueDtp.Minute, ValueDtp.Second);

                            //ソート順(LabelRadioBUttons)のグループ内のチェックされているラジオボタン(rbtCheckNum)を取得する                           
                            var rbtCheckInGroup = deliveryClassification.labelRadioButtons.Controls.OfType<RadioButton>()
                                .SingleOrDefault(rb => rb.Checked == true);
                            bool rbtCheck = int.TryParse(rbtCheckInGroup.Text, out int rbtCheckNum);

                            //ASK対象(LabelCheckBoxSingle)のチェックボックスの状態を変数(chkBoxCheckState)にセットする
                            bool chkBoxCheckState = deliveryClassification.CheckState.Checked;

                            //グループボックスの番号(PabelNumber)を変数(strPanelNum)にセットする
                            int PanelNum = deliveryClassification.PanelNumber;
                            #endregion

                            var parameters = new List<ParameterItem>()
                            {
                                new ParameterItem("Text", strText),
                                new ParameterItem("DTP", settingDate),
                                new ParameterItem("RbtCheckState", rbtCheckNum),
                                new ParameterItem("CheckState", chkBoxCheckState),
                                new ParameterItem("PanelNum", PanelNum),
                            };
                            string sql = query.ToString();
                            // 更新のSQLを作成
                            Execute(sql, ToSqlParams(parameters));
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region 画面上のTabCtrlPagePlantsコントロールの値をデータベースへ登録する
        /// <summary>
        /// 画面上のTabCtrlPagePlantsコントロールの値をデータベースへ登録する
        /// </summary>
        /// <param name="formControls"></param>
        /// <param name="tableName"></param>
        /// <param name="dataColumnName1"></param>
        /// <param name="dataColumnName2"></param>
        /// <param name="dataColumnName3"></param>
        /// <param name="dataColumnName4"></param>
        /// <param name="keyColumnName"></param>
        public void FromTabCtrlPagePlants(Control.ControlCollection formControls,
                                       string tableName,
                                       string dataColumnName1,
                                       string dataColumnName2,
                                       string dataColumnName3,
                                       string dataColumnName4,
                                       string keyColumnName
            )
        {
            // フォームで定義された、取得値設定先のコントロールを抽出する
            var controls = new List<Control>();
            Funcs.FindControls(formControls, controls);
            foreach (var control in controls)
            {
                switch (control)
                {
                    case TabCtrlPagePlants tabCtrlPagePlants:
                        if (!string.IsNullOrEmpty(tabCtrlPagePlants.PanelNumber.ToString()))
                        {
                            StringBuilder query = new StringBuilder();
                            query.AppendLine($"UPDATE");
                            query.AppendFormat($" {tableName}");
                            query.AppendLine($" SET");
                            query.AppendFormat($" {dataColumnName1} = @Text");
                            query.AppendFormat($",{dataColumnName2} = @Nud1");
                            query.AppendFormat($",{dataColumnName3} = @Nud2");
                            query.AppendFormat($",{dataColumnName4} = @DTP");
                            query.AppendLine($" WHERE");
                            query.AppendFormat($" {keyColumnName} = @PanelNum");

                            #region Sqlパラメータにセットする変数を準備
                            //工場名(LabelTextBox)の値を変数(strText)にセットする
                            string strText = tabCtrlPagePlants.LblTxtBoxValue;

                            //1日の製造可能缶数(数)(LabelNumericUpDown)の値を変数()にセットする。
                            decimal Nud1 = tabCtrlPagePlants.LblNud1Value;

                            //1日の製造時間(分)(LabelNumericUpDown)の値を変数()にセットする。                            
                            decimal Nud2 = tabCtrlPagePlants.LblNud2Value;

                            //開始時間(LabelDateTimePicker)からDBにセットする日時(settinfDate)を準備する
                            DateTime now = DateTime.Now;
                            DateTime ValueDtp = tabCtrlPagePlants.LblDTPValue;
                            DateTime settingDate = new DateTime(now.Year, now.Month, now.Day, ValueDtp.Hour, ValueDtp.Minute, ValueDtp.Second);

                            //ユーザーコントロールの番号(PabelNumber)を変数(strPanelNum)にセットする
                            int PanelNum = tabCtrlPagePlants.PanelNumber;
                            #endregion

                            var parameters = new List<ParameterItem>()
                            {
                                new ParameterItem("Text", strText),
                                new ParameterItem("Nud1", Nud1),
                                new ParameterItem("Nud2", Nud2),
                                new ParameterItem("DTP", settingDate),
                                new ParameterItem("PanelNum", PanelNum),
                            };
                            string sql = query.ToString();
                            // 更新のSQLを作成
                            Execute(sql, ToSqlParams(parameters));
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region  画面上のTabCtrlPagePlantsSettingコントロールの値をデータベースへ登録する
        /// <summary>
        /// 画面上のTabCtrlPagePlatsSettingコントロールの値をデータベースへ登録する
        /// </summary>
        /// <param name="formControls"></param>
        /// <param name="tableName"></param>
        /// <param name="dataColumnName1"></param>
        /// <param name="dataColumnName2"></param>
        /// <param name="dataColumnName3"></param>
        /// <param name="dataColumnName4"></param>
        /// <param name="dataColumnName5"></param>
        /// <param name="dataColumnName6"></param>
        /// <param name="dataColumnName7"></param>
        /// <param name="dataColumnName8"></param>
        /// <param name="dataColumnName9"></param>
        /// <param name="dataColumnName10"></param>
        /// <param name="dataColumnName11"></param>
        /// <param name="dataColumnName12"></param>
        /// <param name="dataColumnName13"></param>
        /// <param name="dataColumnName14"></param>
        /// <param name="keyColumnName"></param>
        public void FromTabCtrlPagePlantsSetting(Control.ControlCollection formControls,
                                       string tableName,
                                       string dataColumnName1,
                                       string dataColumnName2,
                                       string dataColumnName3,
                                       string dataColumnName4,
                                       string dataColumnName5,
                                       string dataColumnName6,
                                       string dataColumnName7,
                                       string dataColumnName8,
                                       string dataColumnName9,
                                       string dataColumnName10,
                                       string dataColumnName11,
                                       string dataColumnName12,
                                       string dataColumnName13,
                                       string dataColumnName14,
                                       string keyColumnName
            )
        {
            // フォームで定義された、取得値設定先のコントロールを抽出する
            var controls = new List<Control>();
            Funcs.FindControls(formControls, controls);
            foreach (var control in controls)
            {
                switch (control)
                {
                    case TabCtrlPagePlantsSetting tabCtrlPagePlantsSetting:

                        if (!string.IsNullOrEmpty(tabCtrlPagePlantsSetting.PanelNumber.ToString()))
                        {
                            StringBuilder query = new StringBuilder();
                            query.AppendLine($"UPDATE");
                            query.AppendFormat($" {tableName}");
                            query.AppendLine($" SET");
                            query.AppendFormat($" {dataColumnName1} = @Text1");
                            query.AppendFormat($",{dataColumnName2} = @Text2");
                            query.AppendFormat($",{dataColumnName3} = @Text3");
                            query.AppendFormat($",{dataColumnName4} = @Nud1");
                            query.AppendFormat($",{dataColumnName5} = @Text4");
                            query.AppendFormat($",{dataColumnName6} = @Text5");
                            query.AppendFormat($",{dataColumnName7} = @Text6");
                            query.AppendFormat($",{dataColumnName8} = @Chk");
                            query.AppendFormat($",{dataColumnName9} = @Text7");
                            query.AppendFormat($",{dataColumnName10} = @Text8");
                            query.AppendFormat($",{dataColumnName11} = @Text9");
                            query.AppendFormat($",{dataColumnName12} = @Text10");
                            query.AppendFormat($",{dataColumnName13} = @Text11");
                            query.AppendFormat($",{dataColumnName14} = @Text12");
                            query.AppendLine($" WHERE");
                            query.AppendFormat($" {keyColumnName} = @PanelNum");

                            #region Sqlパラメータにセットする変数を準備
                            //FTPホスト名(LabelTextBox)の値を変数(strText1)にセットする
                            string strText1 = tabCtrlPagePlantsSetting.LblTxtBox1Value;

                            //ユーザー名(LabelTextBox)の値を変数(strText2)にセットする
                            string strText2 = tabCtrlPagePlantsSetting.LblTxtBox2Value;

                            //ユーザー名(LabelTextBox)の値を変数(strText3)にセットする
                            string strText3 = tabCtrlPagePlantsSetting.LblTxtBox3Value;

                            //ユーザー名(LabelTextBox)の値を変数(strText4)にセットする
                            string strText4 = tabCtrlPagePlantsSetting.LblTxtBox4Value;

                            //ユーザー名(LabelTextBox)の値を変数(strText5)にセットする
                            string strText5 = tabCtrlPagePlantsSetting.LblTxtBox5Value;

                            //ユーザー名(LabelTextBox)の値を変数(strText6)にセットする
                            string strText6 = tabCtrlPagePlantsSetting.LblTxtBox6Value;

                            //ユーザー名(LabelTextBox)の値を変数(strText7)にセットする
                            string strText7 = tabCtrlPagePlantsSetting.LblTxtBox7Value;

                            //ユーザー名(LabelTextBox)の値を変数(strText8)にセットする
                            string strText8 = tabCtrlPagePlantsSetting.LblTxtBox8Value;

                            //ユーザー名(LabelTextBox)の値を変数(strText9)にセットする
                            string strText9 = tabCtrlPagePlantsSetting.LblTxtBox9Value;

                            //ユーザー名(LabelTextBox)の値を変数(strText10)にセットする
                            string strText10 = tabCtrlPagePlantsSetting.LblTxtBox10Value;

                            //ユーザー名(LabelTextBox)の値を変数(strText11)にセットする
                            string strText11 = tabCtrlPagePlantsSetting.LblTxtBox11Value;

                            //ユーザー名(LabelTextBox)の値を変数(strText12)にセットする
                            string strText12 = tabCtrlPagePlantsSetting.LblTxtBox12Value;

                            //1日の製造可能缶数(数)(LabelNumericUpDown)の値を変数()にセットする。
                            decimal decNud1 = tabCtrlPagePlantsSetting.LblNud1Value;

                            //ASK対象(LabelCheckBoxSingle)のチェックボックスの状態を変数(chkBoxCheckState)にセットする
                            bool boolChk = tabCtrlPagePlantsSetting.CheckState.Checked;

                            //ユーザーコントロールの番号(PabelNumber)を変数(strPanelNum)にセットする
                            int PanelNum = tabCtrlPagePlantsSetting.PanelNumber;
                            #endregion

                            var parameters = new List<ParameterItem>()
                            {
                                new ParameterItem("Text1", strText1),
                                new ParameterItem("Text2", strText2),
                                new ParameterItem("Text3", strText3),
                                new ParameterItem("Nud1", decNud1),
                                new ParameterItem("Text4", strText4),
                                new ParameterItem("Text5", strText5),
                                new ParameterItem("Text6", strText6),
                                new ParameterItem("Chk", boolChk),
                                new ParameterItem("Text7", strText7),
                                new ParameterItem("Text8", strText8),
                                new ParameterItem("Text9", strText9),
                                new ParameterItem("Text10", strText10),
                                new ParameterItem("Text11", strText11),
                                new ParameterItem("Text12", strText12),
                                new ParameterItem("PanelNum", PanelNum),

                            };
                            string sql = query.ToString();
                            // 更新のSQLを作成
                            Execute(sql, ToSqlParams(parameters));
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region 画面上のLabelTextBoxコントロールの値をデータベースへ登録する
        /// <summary>
        /// 画面上のLabelTextBoxコントロールの値をデータベースへ登録する
        /// </summary>
        /// <param name="formControls"></param>
        /// <param name="tableName"></param>
        /// <param name="keyColumnName"></param>
        public void FromLabelTextBox(Control.ControlCollection formControls,
                                      string tableName,
                                      string keyColumnName)
        {
            // フォームで定義された、取得値設定先のコントロールを抽出する
            var controls = new List<Control>();
            Funcs.FindControls(formControls, controls);
            foreach (var control in controls)
            {
                switch (control)
                {
                    case LabelTextBox labelTextBox:
                        if (!string.IsNullOrEmpty(labelTextBox.Id))
                        {
                            string dataColumnName = labelTextBox.DatabaseColumnName;
                            var parameters = new List<ParameterItem>()
                            {
                                new ParameterItem("Text", labelTextBox.Value),
                                new ParameterItem("Code", labelTextBox.Id),
                            };
                            // 更新のSQLを作成
                            Execute($"UPDATE {tableName} SET {dataColumnName} = @Text WHERE {keyColumnName} = @Code", ToSqlParams(parameters));
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region 画面上のTextBoxExコントロールの値をデータベースへ登録する
        /// <summary>
        /// 画面上のTextBoxExコントロールの値をデータベースへ登録する
        /// </summary>
        /// <param name="formControls"></param>
        /// <param name="tableName"></param>
        /// <param name="keyColumnName"></param>
        public void FromTextBoxEx(Control.ControlCollection formControls,
                                      string tableName,
                                      string keyColumnName)
        {
            // フォームで定義された、取得値設定先のコントロールを抽出する
            var controls = new List<Control>();
            Funcs.FindControls(formControls, controls);
            foreach (var control in controls)
            {
                switch (control)
                {
                    case TextBoxEx textBoxEx:
                        if (!string.IsNullOrEmpty(textBoxEx.Id.ToString()))
                        {
                            string dataColumnName = textBoxEx.DatabaseColumnName;
                            var parameters = new List<ParameterItem>()
                            {
                                new ParameterItem("Text", textBoxEx.Text),
                                new ParameterItem("Code", textBoxEx.Id),
                            };
                            // 更新のSQLを作成
                            Execute($"UPDATE {tableName} SET {dataColumnName} = @Text WHERE {keyColumnName} = @Code", ToSqlParams(parameters));
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region 画面上のLabelNumericUpDownコントロールの値をデータベースへ登録する
        /// <summary>
        /// 画面上のLabelNumericUpDownコントロールの値をデータベースへ登録する
        /// </summary>
        /// <param name="formControls"></param>
        /// <param name="tableName"></param>
        /// <param name="keyColumnName"></param>
        public void FromLabelNumericUpDown(Control.ControlCollection formControls,
                                        string tableName,
                                        string keyColumnName)
        {
            // フォームで定義された、取得値設定先のコントロールを抽出する
            var controls = new List<Control>();
            Funcs.FindControls(formControls, controls);
            foreach (var control in controls)
            {
                switch (control)
                {
                    case LabelNumericUpDown labelNumericUpDown:
                        if (!string.IsNullOrEmpty(labelNumericUpDown.Id))
                        {
                            string dataColumnName = labelNumericUpDown.DatabaseColumnName;
                            var parameters = new List<ParameterItem>()
                            {
                                new ParameterItem("Text", labelNumericUpDown.Value),
                                new ParameterItem("Code", labelNumericUpDown.Id),
                            };
                            // 更新のSQLを作成
                            Execute($"UPDATE {tableName} SET {dataColumnName} = @Text WHERE {keyColumnName} = @Code", ToSqlParams(parameters));
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region 画面上のLabelNumericUpDownMultiコントロールの値をデータベースへ登録する
        /// <summary>
        /// 画面上のLabelNumeircUpDownMultiコントロールの値をデータベースへ登録する
        /// </summary>
        /// <param name="formControls"></param>
        /// <param name="tableName"></param>
        /// <param name="keyColumnName"></param>
        public void FromLabelNumericUpDownMulti(Control.ControlCollection formControls,
                                        string tableName,
                                        string keyColumnName)
        {
            // フォームで定義された、取得値設定先のコントロールを抽出する
            var controls = new List<Control>();
            Funcs.FindControls(formControls, controls);
            foreach (var control in controls)
            {
                switch (control)
                {
                    case LabelNumericUpDownMulti labelNumericUpDownMulti:
                        if (!string.IsNullOrEmpty(labelNumericUpDownMulti.Id.ToString()))
                        {
                            string dataColumnNameLeft = labelNumericUpDownMulti.DatabaseColumnNameLeft;
                            string dataColumnNameRight = labelNumericUpDownMulti.DatabaseColumnNameRight;
                            var parameters = new List<ParameterItem>()
                            {
                                new ParameterItem("TextLeft", labelNumericUpDownMulti.ValueLeft),
                                new ParameterItem("TextRight", labelNumericUpDownMulti.ValueRight),
                                new ParameterItem("Code", labelNumericUpDownMulti.Id),
                            };
                            // 更新のSQLを作成
                            Execute($"UPDATE {tableName} SET {dataColumnNameLeft} = @TextLeft, {dataColumnNameRight} = @TextRight WHERE {keyColumnName} = @Code", ToSqlParams(parameters));
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region 画面上のLabelCheckBoxSingleコントロールの値をデータベースへ登録する
        /// <summary>
        /// 画面上のLabelCheckBoxSingleコントロールの値をデータベースへ登録する
        /// </summary>
        /// <param name="formControls"></param>
        /// <param name="tableName"></param>
        /// <param name="keyColumnName"></param>
        public void FromLabelCheckBoxSingle(Control.ControlCollection formControls,
                                        string tableName,
                                        string keyColumnName)
        {
            // フォームで定義された、取得値設定先のコントロールを抽出する
            var controls = new List<Control>();
            Funcs.FindControls(formControls, controls);
            foreach (var control in controls)
            {
                switch (control)
                {
                    case LabelCheckBoxSingle labelCheckBoxSingle:
                        if (!string.IsNullOrEmpty(labelCheckBoxSingle.Id.ToString()))
                        {
                            string dataColumnName = labelCheckBoxSingle.DatabaseColumnName;

                            var parameters = new List<ParameterItem>()
                            {
                                new ParameterItem("Chk", labelCheckBoxSingle.CheckState.Checked),
                                new ParameterItem("Code", labelCheckBoxSingle.Id),
                            };
                            // 更新のSQLを作成
                            Execute($"UPDATE {tableName} SET {dataColumnName} = @Chk WHERE {keyColumnName} = @Code", ToSqlParams(parameters));
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region 画面上のLabelDateTimePickerコントロールの値をデータベースへ登録する
        /// <summary>
        /// 画面上のLabelDateTimePickerコントロールの値をデータベースへ登録する
        /// </summary>
        /// <param name="formControls"></param>
        /// <param name="tableName"></param>
        /// <param name="keyColumnName"></param>
        public void FromLabelDateTimePicker(Control.ControlCollection formControls,
                                        string tableName,
                                        string keyColumnName)
        {
            // フォームで定義された、取得値設定先のコントロールを抽出する
            var controls = new List<Control>();
            Funcs.FindControls(formControls, controls);
            foreach (var control in controls)
            {
                switch (control)
                {
                    case LabelDateTimePicker labelDateTimePicker:
                        if (!string.IsNullOrEmpty(labelDateTimePicker.Id.ToString()))
                        {
                            string dataColumnName = labelDateTimePicker.DatabaseColumnName;
                            //開始時間(LabelDateTimePicker)からDBにセットする日時(settinfDate)を準備する
                            DateTime now = DateTime.Now;
                            DateTime ValueDtp = labelDateTimePicker.Value;
                            DateTime settingDate = new DateTime(now.Year, now.Month, now.Day, ValueDtp.Hour, ValueDtp.Minute, ValueDtp.Second);
                            var parameters = new List<ParameterItem>()
                            {
                                new ParameterItem("DTP", settingDate),
                                new ParameterItem("Code", labelDateTimePicker.Id),
                            };
                            // 更新のSQLを作成
                            Execute($"UPDATE {tableName} SET {dataColumnName} = @DTP WHERE {keyColumnName} = @Code", ToSqlParams(parameters));
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region 画面上のLabelDropDownコントロールの値をデータベースへ登録する
        /// <summary>
        /// 画面上のLabelDropDownコントロールの値をデータベースへ登録する
        /// </summary>
        /// <param name="formControls"></param>
        /// <param name="tableName"></param>
        /// <param name="keyColumnName"></param>
        public void FromLabelDropDown(Control.ControlCollection formControls,
                                      string tableName,
                                      string keyColumnName)
        {
            // フォームで定義された、取得値設定先のコントロールを抽出する
            var controls = new List<Control>();
            Funcs.FindControls(formControls, controls);
            foreach (var control in controls)
            {
                switch (control)
                {
                    case LabelDropDown labelDropDown:
                        if (!string.IsNullOrEmpty(labelDropDown.Id))
                        {
                            string dataColumnName = labelDropDown.DatabaseColumnName;
                            var parameters = new List<ParameterItem>();
                            switch (labelDropDown.DropDown.DataSource)
                            {
                                case null:
                                    parameters = new List<ParameterItem>()
                                    {
                                        new ParameterItem("Text", labelDropDown.DropDown.Text),
                                        new ParameterItem("Code", labelDropDown.Id),
                                    };
                                    break;
                                default:
                                    parameters = new List<ParameterItem>()
                                    {
                                        new ParameterItem("Text", labelDropDown.DropDown.SelectedValue),
                                        new ParameterItem("Code", labelDropDown.Id),
                                    };
                                    break;
                            }
                            // 更新のSQLを作成
                            Execute($"UPDATE {tableName} SET {dataColumnName} = @Text WHERE {keyColumnName} = @Code", ToSqlParams(parameters));
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region 新規作成処理
        /// <summary>
        /// 新規作成処理
        /// </summary>
        /// <param name="formControls"></param>
        public void Insert(Control.ControlCollection formControls, string tableName)
        {
            var fields = new List<string>();
            var param = new List<SqlParameter>();
            var values = new List<string>();
            var controls = new List<Control>();
            string column = string.Empty;
            string value = string.Empty;
            // フォームで定義された、取得値設定先のコントロールを抽出する
            Funcs.FindControls(formControls, controls);
            foreach (var control in controls)
            {
                switch (control)
                {
                    // LabelTextBoxコントロールから設定
                    case LabelTextBox labelTextBox:
                        //コントロールのIdプロパティに値が入っていることを確認(データ更新に用いるコントロールか調べる)
                        if (!string.IsNullOrEmpty(labelTextBox.Id))
                        {
                            //値が入っていることを確認
                            if (!string.IsNullOrEmpty(labelTextBox.Value))
                            {
                                column = labelTextBox.DatabaseColumnName;
                                value = labelTextBox.Value;

                                fields.Add(column);
                                values.Add("@" + column);

                                param.Add(new SqlParameter(column, value));

                            }
                        }
                        break;
                    // LabelDropDownコントロールから設定
                    case LabelDropDown labelDropDown:
                        //コントロールのIdプロパティに値が入っていることを確認(データ更新に用いるコントロールか調べる)
                        if (!string.IsNullOrEmpty(labelDropDown.Id))
                        {
                            //datasorceを持つプルダウンか調べる
                            if (labelDropDown.DropDown.DataSource != null)
                            {
                                //値が入っていることを確認
                                if (!string.IsNullOrEmpty(labelDropDown.DropDown.SelectedValue.ToString()))
                                {
                                    column = labelDropDown.DatabaseColumnName;
                                    value = labelDropDown.DropDown.SelectedValue.ToString();

                                    fields.Add(column);
                                    values.Add("@" + column);

                                    param.Add(new SqlParameter(column, value));
                                }
                            }
                            else
                            {
                                if (!string.IsNullOrEmpty(labelDropDown.DropDown.Text))
                                {
                                    column = labelDropDown.DatabaseColumnName;
                                    value = labelDropDown.DropDown.Text;

                                    fields.Add(column);
                                    values.Add("@" + column);

                                    param.Add(new SqlParameter(column, value));
                                }
                            }
                        }
                        break;
                    // LabelNumericUpDownコントロールから設定
                    case LabelNumericUpDown labelNumericUpDown:
                        //コントロールのIdプロパティに値が入っていることを確認(データ更新に用いるコントロールか調べる)
                        if (!string.IsNullOrEmpty(labelNumericUpDown.Id))
                        {
                            //値が入っていることを確認
                            if (!string.IsNullOrEmpty(labelNumericUpDown.Value.ToString()))
                            {
                                column = labelNumericUpDown.DatabaseColumnName;
                                value = labelNumericUpDown.Value.ToString();

                                fields.Add(column);
                                values.Add("@" + column);

                                param.Add(new SqlParameter(column, value));
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            // 更新のSQLを作成
            var sql = $"INSERT INTO {tableName}  ({string.Join(",", fields)}) VALUES ({string.Join(",", values)})";
            Execute(sql, param);
            Commit();
        }
        #endregion

        #region 削除処理
        public void Delete(string value, string tableName, string keyName)
        {
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter("Code", value));

            var sql = $"Delete from {tableName} Where {keyName} = @Code";

            Execute(sql, param);
            Commit();
        }

        #endregion


        #endregion
    }
}
