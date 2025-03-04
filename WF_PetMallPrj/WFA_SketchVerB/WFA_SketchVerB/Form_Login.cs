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
    public partial class Form_Login : Form
    {
        // Var
        // 新增標記變數
        private bool isSignInSelected = false;  // 預設登入被選中

        // 建構 -----------------------------
        public Form_Login()
        {
            InitializeComponent();
            GlobalVar.LoginForm = this;
        }
        // ------------------------------------

        // Method

        // 提供給 UC_SingUp 調用的方法
        public void BacktoLogin()
        {
            uC_SingUp1.Visible= false;
            lbl_ChooseSingUp.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            isSignInSelected = true;
            lbl_Actual.Location = new Point(95, 92);
            lbl_Title.Text = "會員登入";
            uC_SingUp1.Visible = false;
            
        }

        // EVENT
        private void Form_Login_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MyDB";
            scsb.IntegratedSecurity = true;

            GlobalVar.strDBConnection = scsb.ConnectionString.ToString();
            uC_SingUp1.Visible = false;
        }


        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_UserID.Text.Trim();
            string password = txt_Password.Text.Trim();

            // 使用 ADO.NET 來查詢資料庫
            if (username != "" && password != "")
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnection);
                con.Open();

                string query = @"SELECT * FROM UsersInfo 
                                WHERE UserEmail = @UserEmail AND UserPassword = @UserPassword";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@UserEmail", username);
                    command.Parameters.AddWithValue("@UserPassword", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            GlobalVar.CurrentUser = new User
                            {
                                UserID = reader.GetInt32(reader.GetOrdinal("Id")),
                                UserName = reader.GetString(reader.GetOrdinal("UserName")),
                                UserPhone = reader.GetString(reader.GetOrdinal("UserPhone")),
                                UserEmail = reader.GetString(reader.GetOrdinal("UserEmail")),
                                UserPassword = reader.GetString(reader.GetOrdinal("UserPassword")),
                                CreateDate = reader.GetDateTime(reader.GetOrdinal("CreateDate")),
                                UserRole = reader.GetInt32(reader.GetOrdinal("UserRole")),
                                UserAddress = reader.GetString(reader.GetOrdinal("UserAddress"))
                            };
                            //string userName = reader["UserName"].ToString();
                            //GlobalVar.MainForm.uC_DownUserMenu1.ucIcon_ShowUName.Text = userName;
                            GlobalVar.MainForm.uC_DownUserMenu1.ucIcon_ShowUName.Text = GlobalVar.CurrentUser.UserName;

                            MessageBox.Show("登入成功！");
                            //MessageBox.Show(GlobalVar.CurrentUser.UserAddress);

                            int userRole = Convert.ToInt32(reader["UserRole"]);
                            if (userRole >= 0 && userRole <= 2)   // 根據您的資料庫欄位調整
                            {
                                GlobalVar.IsAdmin = true;
                                if (GlobalVar.MainForm != null)
                                {
                                    GlobalVar.MainForm.ShowAdminMenu();
                                }
                            }

                            // 調用 TopPnl 的按鈕位置調整方法
                            if (GlobalVar.MainForm != null && GlobalVar.MainForm.Controls["user_TopPnl1"] is User_TopPnl topPanel)
                            {
                                topPanel.AdjustButtonsPosition(true);
                            }
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("帳號或密碼錯誤！");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("請輸入帳號和密碼！");
            }
        }

        private void lbl_SingUp_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ChooseSingin_MouseEnter(object sender, EventArgs e)
        {
            if (((Label)sender).Name == lbl_ChooseSingin.Name)
            {
                
                lbl_ChooseSingin.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                
            }

            else if (((Label)sender).Name == lbl_ChooseSingUp.Name)
            {
               
                lbl_ChooseSingUp.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                
            }
        }

        private void lbl_ChooseSingin_MouseLeave(object sender, EventArgs e)
        {
            if (((Label)sender).Name == lbl_ChooseSingin.Name && !isSignInSelected)
            {
                lbl_ChooseSingin.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            }
            else if (((Label)sender).Name == lbl_ChooseSingUp.Name && isSignInSelected)
            {
                lbl_ChooseSingUp.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            }
        }

        private void lbl_ChooseSingin_Click(object sender, EventArgs e)
        {
            
            if (((Label)sender).Name == lbl_ChooseSingin.Name)
            {
                lbl_ChooseSingUp.ForeColor = System.Drawing.SystemColors.AppWorkspace;
                isSignInSelected = true;
                lbl_Actual.Location = new Point(95, 92);
                lbl_Title.Text = "會員登入";
                uC_SingUp1.Visible = false;
            }
            else if ( ((Label)sender).Name == lbl_ChooseSingUp.Name || ((Label)sender).Name == lbl_SingUp.Name )
            {
                lbl_ChooseSingin.ForeColor = System.Drawing.SystemColors.AppWorkspace;
                isSignInSelected = false;
                lbl_Actual.Location = new Point(216, 92);
                lbl_Title.Text = "會員註冊";
                uC_SingUp1.Visible = true;
            }
        }

        private void lbl_SingUp_MouseEnter(object sender, EventArgs e)
        {
            lbl_SingUp.ForeColor = Color.Blue;

        }

        private void lbl_SingUp_MouseLeave(object sender, EventArgs e)
        {
            lbl_SingUp.ForeColor = System.Drawing.SystemColors.AppWorkspace;
        }

        private void ucIcon_Forget_Click(object sender, EventArgs e)
        {
            Form_ForgetPwd myForgetPwd = new Form_ForgetPwd();

            myForgetPwd.ShowDialog();
        }
    }
}
