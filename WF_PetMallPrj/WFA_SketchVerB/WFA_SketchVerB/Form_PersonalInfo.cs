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
    public partial class Form_PersonalInfo : Form
    {
        // Var
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder(); // 資料庫連線字串建立器
        string strDBConnectionString = ""; //資料庫連線字串
        List<int> searchResult = new List<int>(); // 用於存搜尋結果。 Hint：用 int 存，因為 SQL 的 ID PK
        int DGVtotNum = 0; // DGV 會員資料列表筆數

        //--- 拖曳用----
        private bool beginMove = false;
        private int currentXPos; private int currentYPos;
        WFA_SketchVerB.UserControl_ItemsShow U1 = new WFA_SketchVerB.UserControl_ItemsShow();

        // 建構
        public Form_PersonalInfo()
        {
            InitializeComponent();
        }

        private void Form_PersonalInfo_Load(object sender, EventArgs e)
        {
            lbl_UserName.Text = GlobalVar.CurrentUser.UserName;
            lbl_UserID.Text = GlobalVar.CurrentUser.UserID.ToString();
            txt_UserName.Text = GlobalVar.CurrentUser.UserName;
            txt_Email.Text = GlobalVar.CurrentUser.UserEmail;
            txt_Phone.Text = GlobalVar.CurrentUser.UserPhone;
            txt_Address.Text = GlobalVar.CurrentUser.UserAddress;

            scsb.DataSource = @"."; //伺服器名稱，也可以填入「.」、IP位置、網域名稱，用 @ 不處理字元控制，避免 / 問題。
            scsb.InitialCatalog = "MyDB"; //資料庫名稱
            scsb.IntegratedSecurity = true; //Windows 驗證：True
            strDBConnectionString = scsb.ConnectionString;

        }

        private void ucIcon_Modify_Click(object sender, EventArgs e)
        {
            //ucIcon_ChkName.Visible = true; ucIcon_ChkEmail.Visible = true; ucIcon_ChkPhone.Visible = true;

            txt_UserName.Enabled = true; txt_UserName.BorderStyle = BorderStyle.FixedSingle;
            txt_Phone.Enabled = true; txt_Phone.BorderStyle = BorderStyle.FixedSingle;
            txt_Email.Enabled = true; txt_Email.BorderStyle = BorderStyle.FixedSingle;
            txt_Address.Enabled = true; txt_Address.BorderStyle = BorderStyle.FixedSingle;

            txt_UserName.BackColor = Color.White; txt_Phone.BackColor = Color.White;
            txt_Email.BackColor = Color.White; txt_Address.BackColor = Color.White;

            ucIcon_ModiSave.Visible = true;
            ucIcon_Cancel.Visible = true;
        }


        private void ucIcon_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // WinForm Move ----------------------------
        private void lbl_TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXPos = MousePosition.X; currentYPos = MousePosition.Y;

            }
        }

        private void lbl_TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove)
            {
                this.Left += MousePosition.X - currentXPos;
                this.Top += MousePosition.Y - currentYPos;
                currentXPos = MousePosition.X;
                currentYPos = MousePosition.Y;
            }
        }

        private void lbl_TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentXPos = 0; currentYPos = 0;
                beginMove = false;
            }
        }
        private void txt_Input_Click(object sender, EventArgs e)
        {
            TextBox clickedTextBox = sender as TextBox;
            if (clickedTextBox != null && clickedTextBox.BackColor == Color.LightPink)
            {
                clickedTextBox.BackColor = Color.White;
            }
        }
        // -------------------------------------------

        private void ucIcon_ModiSave_Click(object sender, EventArgs e)
        {
            bool canUpdate = true;

            // 驗證電子郵件格式
            const string EMAIL_PATTERN = @"^[a-zA-Z0-9][\w-]*(\.[\w-]+)*@([\w-]+)\.(com|com\.tw)$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_Email.Text, EMAIL_PATTERN))
            {
                txt_Email.BackColor = Color.LightPink;
                MessageBox.Show("請輸入有效的電子郵件地址！", "格式錯誤", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 驗證手機格式
            const string PHONE_PATTERN = @"^09\d{8}$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_Phone.Text, PHONE_PATTERN))
            {
                txt_Phone.BackColor = Color.LightPink;
                MessageBox.Show("請輸入有效的手機號碼！（格式：09開頭加8碼數字）", "格式錯誤", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(strDBConnectionString))
            {
                con.Open();
                string strSQL = "SELECT UserName, UserEmail, UserPhone FROM UsersInfo WHERE Id != @SearchID";
                using (SqlCommand cmd = new SqlCommand(strSQL, con))
                {
                    cmd.Parameters.AddWithValue("@SearchID", GlobalVar.CurrentUser.UserID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (txt_UserName.Text == reader["UserName"].ToString())
                        {
                            txt_UserName.BackColor = Color.LightPink;
                            canUpdate = false;
                        }
                        if (txt_Email.Text == reader["UserEmail"].ToString())
                        {
                            txt_Email.BackColor = Color.LightPink;
                            canUpdate = false;
                        }
                        if (txt_Phone.Text == reader["UserPhone"].ToString())
                        {
                            txt_Phone.BackColor = Color.LightPink;
                            canUpdate = false;
                        }
                    }
                }

                if (canUpdate)
                {
                    string updateSQL = "UPDATE UsersInfo SET UserName=@name, UserEmail=@email, UserPhone=@phone WHERE Id=@id";
                    using (SqlCommand cmd = new SqlCommand(updateSQL, con))
                    {
                        cmd.Parameters.AddWithValue("@name", txt_UserName.Text);
                        cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                        cmd.Parameters.AddWithValue("@phone", txt_Phone.Text);
                        cmd.Parameters.AddWithValue("@id", GlobalVar.CurrentUser.UserID);
                        cmd.ExecuteNonQuery();

                        // 更新成功後的UI處理
                        ucIcon_ChkName.Visible = false;
                        ucIcon_ChkEmail.Visible = false;
                        ucIcon_ChkPhone.Visible = false;
                        ucIcon_Modify.Visible = false;
                        ucIcon_Cancel.Visible = false;

                        txt_UserName.Enabled = false;
                        txt_Phone.Enabled = false;
                        txt_Email.Enabled = false;
                        txt_Address.Enabled = false;

                        txt_UserName.BorderStyle = BorderStyle.Fixed3D;
                        txt_Phone.BorderStyle = BorderStyle.Fixed3D;
                        txt_Email.BorderStyle = BorderStyle.Fixed3D;
                        txt_Address.BorderStyle = BorderStyle.Fixed3D;

                        txt_UserName.BackColor = Color.FromArgb(224, 224, 224);
                        txt_Phone.BackColor = Color.FromArgb(224, 224, 224);
                        txt_Email.BackColor = Color.FromArgb(224, 224, 224);
                        txt_Address.BackColor = Color.FromArgb(224, 224, 224);

                        MessageBox.Show("資料更新成功！");
                    }
                }
                else
                {
                    MessageBox.Show("部分資料已存在，請修改後重試！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ucIcon_Cancel_Click(object sender, EventArgs e)
        {
            // 恢復原始資料
            txt_UserName.Text = GlobalVar.CurrentUser.UserName;
            txt_Email.Text = GlobalVar.CurrentUser.UserEmail;
            txt_Phone.Text = GlobalVar.CurrentUser.UserPhone;
            txt_Address.Text = "";

            // 隱藏檢查圖示
            ucIcon_ChkName.Visible = false;
            ucIcon_ChkEmail.Visible = false;
            ucIcon_ChkPhone.Visible = false;
            ucIcon_ModiSave.Visible = false;
            ucIcon_Cancel.Visible = false;

            // 禁用輸入框
            txt_UserName.Enabled = false;
            txt_Phone.Enabled = false;
            txt_Email.Enabled = false;
            txt_Address.Enabled = false;

            // 恢復邊框樣式
            txt_UserName.BorderStyle = BorderStyle.Fixed3D;
            txt_Phone.BorderStyle = BorderStyle.Fixed3D;
            txt_Email.BorderStyle = BorderStyle.Fixed3D;
            txt_Address.BorderStyle = BorderStyle.Fixed3D;

            // 恢復背景顏色
            Color defaultColor = Color.FromArgb(224, 224, 224);
            txt_UserName.BackColor = defaultColor;
            txt_Phone.BackColor = defaultColor;
            txt_Email.BackColor = defaultColor;
            txt_Address.BackColor = defaultColor;

            

        }

        private void ucIcon_chkPwd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strDBConnectionString))
                {
                    con.Open();
                    string strSQL = "SELECT UserPassword FROM UsersInfo WHERE Id = @SearchID";
                    
                    using (SqlCommand cmd = new SqlCommand(strSQL, con))
                    {
                        cmd.Parameters.AddWithValue("@SearchID", GlobalVar.CurrentUser.UserID);
                        
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            string dbPassword = result.ToString();
                            
                            // 確認輸入的密碼是否與資料庫中的密碼相符
                            if (txt_OldPwd.Text == dbPassword)
                            {
                                txt_OldPwd.BackColor = Color.LightGreen;
                                ucIcon_chkPwd.Visible = false;

                                // 密碼正確，啟用新密碼輸入
                                txt_NewPwd.Enabled = true;
                                txt_NewPwd.BackColor = Color.White;
                                txt_NewPwd.BorderStyle = BorderStyle.FixedSingle;
                                
                              
                                
                                // 顯示確認按鈕（假設有一個確認按鈕叫做 ucIcon_PwdSave）
                                ucIcon_PwdSave.Visible = true;
                                
                                MessageBox.Show("密碼驗證成功，請於下欄輸入新密碼", "驗證成功", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                txt_OldPwd.BackColor = Color.LightPink;
                                MessageBox.Show("密碼不正確，請重新輸入", "驗證失敗", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
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

        // 建議也加入以下事件處理方法
        private void txt_OldPwd_Click(object sender, EventArgs e)
        {
            if (txt_OldPwd.BackColor == Color.LightPink)
            {
                txt_OldPwd.BackColor = Color.White;
            }
        }

        private void ucIcon_ResetPwd_Click(object sender, EventArgs e)
        {
            ucIcon_ResetPwd.Visible = false;
            txt_OldPwd.Visible = true;
            txt_NewPwd.Visible = true;
            ucIcon_chkPwd.Visible = true;
        }

        private void ucIcon_PwdSave_Click(object sender, EventArgs e)
        {
            string password = txt_NewPwd.Text.Trim();
            // 驗證密碼格式 大小寫字母 + 數字 共 8 ~ 16 碼
            const string PASSWORD_PATTERN = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,16}$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(password, PASSWORD_PATTERN))
            {
                txt_NewPwd.BackColor = Color.LightPink;
                MessageBox.Show("密碼格式不符合要求！\n" +
                              "須符合以下條件：\n" +
                              "- 至少包含一個小寫字母\n" +
                              "- 至少包含一個大寫字母\n" +
                              "- 至少包含一個數字\n" +
                              "- 長度為8-16個字元");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(strDBConnectionString))
                {
                    con.Open();
                    string strSQL = "UPDATE UsersInfo SET UserPassword = @NewPassword WHERE Id = @SearchID";

                    using (SqlCommand cmd = new SqlCommand(strSQL, con))
                    {
                        cmd.Parameters.AddWithValue("@NewPassword", password);
                        cmd.Parameters.AddWithValue("@SearchID", GlobalVar.CurrentUser.UserID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("密碼更新成功！", "成功",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // 重置所有控制項
                            txt_OldPwd.Text = "";
                            txt_NewPwd.Text = "";
                           

                            
                            txt_NewPwd.Enabled = false;
                            

                            txt_OldPwd.BackColor = Color.White;
                            txt_NewPwd.BackColor = Color.FromArgb(224, 224, 224);
                            

                            txt_OldPwd.BorderStyle = BorderStyle.FixedSingle;
                            txt_NewPwd.BorderStyle = BorderStyle.Fixed3D;
                            
                            // 隱藏相關按鈕
                            ucIcon_PwdSave.Visible = false;
                            ucIcon_chkPwd.Visible = false;
                            txt_NewPwd.Visible = false;
                            txt_OldPwd.Visible = false;

                            ucIcon_ResetPwd.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("密碼更新失敗，請稍後再試！", "錯誤",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
