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
    public partial class UC_SingUp : UserControl
    {
        public UC_SingUp()
        {
            InitializeComponent();
        }

        private void txt_UserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

        }

        private void btn_SingUp_Click(object sender, EventArgs e)
        {
            if (chk_Agree.Checked)
            {

                string email = txt_UserID.Text.Trim();
                string password = txt_Password.Text.Trim();
                string phone = txt_UserPhone.Text.Trim();

                // 基本驗證
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password)) 
                {
                    MessageBox.Show("請輸入電子郵件和密碼！");
                    return;
                }

                

                if (string.IsNullOrEmpty(phone))
                {
                    MessageBox.Show("請輸入手機號碼！");
                    return;
                }

                // 驗證電子郵件格式
                const string EMAIL_PATTERN = @"^[a-zA-Z0-9][\w-]*(\.[\w-]+)*@([\w-]+)\.(com|com\.tw)$"; // .com .com.tw結尾 且到 @ 之前必須有英數字

                if (!System.Text.RegularExpressions.Regex.IsMatch(email, EMAIL_PATTERN))
                {
                    MessageBox.Show("請輸入有效的電子郵件地址！");
                    return;
                }

                const string PHONE_PATTERN = @"^09\d{8}$"; // 手機格式
                if (!System.Text.RegularExpressions.Regex.IsMatch(phone, PHONE_PATTERN))
                {
                    MessageBox.Show("請輸入有效的手機號碼！（格式：09開頭加8碼數字）");
                    return;
                }

                // 驗證密碼格式 大小寫字母 + 數字 共 8 ~ 16 碼
                const string PASSWORD_PATTERN = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,16}$";
                if (!System.Text.RegularExpressions.Regex.IsMatch(password, PASSWORD_PATTERN))
                {
                    MessageBox.Show("密碼格式不符合要求！\n" +
                                  "須符合以下條件：\n" +
                                  "- 至少包含一個小寫字母\n" +
                                  "- 至少包含一個大寫字母\n" +
                                  "- 至少包含一個數字\n" +
                                  "- 長度為8-16個字元");
                    return;
                }

                using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnection))
                {
                    try
                    {
                        con.Open();

                        // 檢查電子郵件是否已存在
                        string checkQuery = "SELECT COUNT(*) FROM UsersInfo WHERE UserEmail = @UserEmail";
                        using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                        {
                            checkCmd.Parameters.AddWithValue("@UserEmail", email);
                            int count = (int)checkCmd.ExecuteScalar();

                            if (count > 0)
                            {
                                MessageBox.Show("此電子郵件已被註冊！");
                                return;
                            }
                        }

                        // 新增會員
                        string insertQuery = @"INSERT INTO UsersInfo (UserName, UserPhone, UserEmail, UserPassword, UserRole) 
                                 VALUES (@UserName, @UserPhone, @UserEmail, @UserPassword, @UserRole)";

                        using (SqlCommand command = new SqlCommand(insertQuery, con))
                        {
                            command.Parameters.AddWithValue("@UserName", email); // 暫定會員名稱為信箱
                            command.Parameters.AddWithValue("@UserPhone", phone);
                            command.Parameters.AddWithValue("@UserEmail", email);
                            command.Parameters.AddWithValue("@UserPassword", password);
                            command.Parameters.AddWithValue("@UserRole", 5);  // 預設為一般會員
                            

                            command.ExecuteNonQuery();
                            //MessageBox.Show("註冊成功！");
                            MessageBox.Show("註冊成功！，將跳轉登入");
                            GlobalVar.LoginForm.BacktoLogin();
                            txt_Password.Text = "";
                            txt_UserID.Text = "";
                            txt_UserPhone.Text = "";
                            txt_Password2.Text = "";
                            chk_Agree.Checked = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"註冊過程發生錯誤：{ex.Message}");
                    }
                }
                //MessageBox.Show("註冊成功！，將跳轉登入");
                //GlobalVar.LoginForm.BacktoLogin();
                //txt_Password.Text = "";
                //txt_UserID.Text = "";
                //txt_UserPhone.Text = "";
                //txt_Password2.Text = "";
                //chk_Agree.Checked = false;
            }
            else
            {
                MessageBox.Show("請先勾選同意條款政策！");
            }

        }
    }
}
