using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SketchVerB
{
    public partial class Form_ForgetPwd : Form
    {
        // Var
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder(); // 資料庫連線字串建立器
        string strDBConnectionString = ""; //資料庫連線字串
        //建構
        public Form_ForgetPwd()
        {
            InitializeComponent();
        }

        private void Form_ForgetPwd_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"."; //伺服器名稱，也可以填入「.」、IP位置、網域名稱，用 @ 不處理字元控制，避免 / 問題。
            scsb.InitialCatalog = "MyDB"; //資料庫名稱
            scsb.IntegratedSecurity = true; //Windows 驗證：True
            strDBConnectionString = scsb.ConnectionString;

            // 訂閱點擊事件
            txt_UserEmail.Click += txt_Input_Click;
            txt_UserPhone.Click += txt_Input_Click;

            // 初始化控制項狀態
            txt_NewPwd.Enabled = false;
            txt_ChkNewPwd.Enabled = false;
            ucIcon_PwdSave.Visible = false;
        }

        private void ucIcon_chkPwd_Click(object sender, EventArgs e)
        {
            // 清除之前的錯誤提示
            txt_UserEmail.BackColor = Color.White;
            txt_UserPhone.BackColor = Color.White;

            // 驗證輸入格式
            const string EMAIL_PATTERN = @"^[a-zA-Z0-9][\w-]*(\.[\w-]+)*@([\w-]+)\.(com|com\.tw)$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_UserEmail.Text.Trim(), EMAIL_PATTERN))
            {
                txt_UserEmail.BackColor = Color.LightPink;
                MessageBox.Show("請輸入有效的電子郵件地址！", "格式錯誤", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            const string PHONE_PATTERN = @"^09\d{8}$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_UserPhone.Text.Trim(), PHONE_PATTERN))
            {
                txt_UserPhone.BackColor = Color.LightPink;
                MessageBox.Show("請輸入有效的手機號碼！（格式：09開頭加8碼數字）", "格式錯誤", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(strDBConnectionString))
                {
                    con.Open();
                    string strSQL = @"SELECT UserName FROM UsersInfo 
                                    WHERE UserEmail = @email AND UserPhone = @phone";

                    using (SqlCommand cmd = new SqlCommand(strSQL, con))
                    {
                        cmd.Parameters.AddWithValue("@email", txt_UserEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txt_UserPhone.Text.Trim());

                        string userName = cmd.ExecuteScalar()?.ToString();
                        
                        if (!string.IsNullOrEmpty(userName))
                        {
                            // 驗證成功，啟用密碼重設功能
                            MessageBox.Show($"身分驗證成功！\n請設定新密碼。", "驗證成功", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ucIcon_chkPwd.Visible = false;
                            // 啟用密碼重設相關控制項
                            txt_NewPwd.Enabled = true;
                            txt_ChkNewPwd.Enabled = true;
                            ucIcon_PwdSave.Visible = true;
                        }
                        else
                        {
                            // 驗證失敗
                            txt_UserEmail.BackColor = Color.LightPink;
                            txt_UserPhone.BackColor = Color.LightPink;
                            MessageBox.Show("電子郵件或手機號碼不正確，請重新確認！", "驗證失敗", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤：{ex.Message}", "錯誤", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 輔助方法：清除錯誤提示
        private void txt_Input_Click(object sender, EventArgs e)
        {
            if (sender is TextBox textBox && textBox.BackColor == Color.LightPink)
            {
                textBox.BackColor = Color.White;
            }
        }
    }
}
