using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SketchVerB
{
    public partial class Form_ManageUserInfo : Form
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



        // Method
        void F_ClearField()
        {
            txt_ID.Clear();
            txt_Name.Clear();
            txt_Address.Clear();
            txt_Phone.Clear();
            txt_Email.Clear();
            txt_Pwd.Clear();
            txt_UserRole.Clear();
        }

        void F_ShowDetail(int myId)
        {
            if (myId > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = $"SELECT * FROM UsersInfo WHERE Id = @SearchId; "; // 雖然""內的SQL語法不分大小寫，但 @ 參數區分大小寫
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", $"{myId}");
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    txt_ID.Text = reader["Id"].ToString();
                    txt_Name.Text = reader["UserName"].ToString();
                    txt_Phone.Text = reader["UserPhone"].ToString();
                    //txt_Address.Text = reader["Address"].ToString();
                    txt_Email.Text = reader["UserEmail"].ToString();
                    txt_UserRole.Text = reader["UserRole"].ToString();
                    
                }
                else
                {
                    MessageBox.Show("查無此人");

                }
                reader.Close();
                con.Close();
            }
        }


        // 建構
        public Form_ManageUserInfo()
        {
            InitializeComponent();
            
            

            // 註冊滾動事件
            dGV_membersRow.Scroll += DGV_membersRow_Scroll;
            dGV_membersRow.CellPainting += DGV_membersRow_CellPainting;
        }

        

        // 新增選擇變更事件處理
        private void DGV_membersRow_SelectionChanged(object sender, EventArgs e)
        {
            bool hasSelection = dGV_membersRow.SelectedRows.Count > 0;

            if (hasSelection)
            {
                DataGridViewRow row = dGV_membersRow.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["會員編號"].Value);
                F_ShowDetail(id);
            }
        }

        // 修改按鈕點擊事件
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dGV_membersRow.SelectedRows.Count > 0)
            {
                // 已經在 SelectionChanged 事件中處理了顯示詳細資料
                // 這裡可以加入其他編輯相關的邏輯
            }
        }

        
        // 方法
        private void F_CustomizeDataGridView() //客製化表格樣式
        {
            
            // 設定整個 DataGridView 為唯讀模式
            dGV_membersRow.ReadOnly = true;

            // 基本樣式設定
            dGV_membersRow.BorderStyle = BorderStyle.None;
            dGV_membersRow.BackgroundColor = Color.White;
            dGV_membersRow.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dGV_membersRow.GridColor = Color.FromArgb(240, 240, 240);
            dGV_membersRow.RowHeadersVisible = false;

            // 設定選取樣式
            dGV_membersRow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGV_membersRow.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 200, 255);
            dGV_membersRow.DefaultCellStyle.SelectionForeColor = Color.Black;

            // 設定標題列樣式
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.BackColor = Color.FromArgb(240, 240, 255);
            headerStyle.ForeColor = Color.Black;
            headerStyle.Font = new Font("微軟正黑體", 10, FontStyle.Regular);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.Padding = new Padding(10, 0, 0, 0);
            dGV_membersRow.ColumnHeadersDefaultCellStyle = headerStyle;
            dGV_membersRow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dGV_membersRow.ColumnHeadersHeight = 40;

            // 設定資料列樣式
            DataGridViewCellStyle rowStyle = new DataGridViewCellStyle();
            rowStyle.BackColor = Color.White;
            rowStyle.ForeColor = Color.Black;
            rowStyle.Font = new Font("微軟正黑體", 9, FontStyle.Regular);
            rowStyle.Padding = new Padding(10, 0, 0, 0);
            dGV_membersRow.DefaultCellStyle = rowStyle;
            dGV_membersRow.RowTemplate.Height = 35;

            // 設定交替列顏色
            foreach (DataGridViewRow row in dGV_membersRow.Rows)
            {
                if (row.Index % 2 == 1) // 針對奇數列
                {
                    for (int i = 2; i < dGV_membersRow.Columns.Count; i++) // 從第3欄開始（跳過編輯和刪除按鈕）
                    {
                        row.Cells[i].Style.BackColor = Color.FromArgb(240, 240, 255);
                        row.Cells[i].Style.ForeColor = Color.Black;
                        row.Cells[i].Style.Font = new Font("微軟正黑體", 9, FontStyle.Regular);
                        row.Cells[i].Style.Padding = new Padding(10, 0, 0, 0);
                    }
                }
            }

            
            // 修改欄位寬度設定
            if (dGV_membersRow.Columns["編輯"] != null)
                dGV_membersRow.Columns["編輯"].Width = 60;
            if (dGV_membersRow.Columns["刪除"] != null)
                dGV_membersRow.Columns["刪除"].Width = 60;
            if (dGV_membersRow.Columns["會員編號"] != null)
                dGV_membersRow.Columns["會員編號"].Width = 80;
            if (dGV_membersRow.Columns["UserName"] != null)
                dGV_membersRow.Columns["UserName"].Width = 120;
            if (dGV_membersRow.Columns["UserPhone"] != null)
                dGV_membersRow.Columns["UserPhone"].Width = 100;
            if (dGV_membersRow.Columns["電子郵件"] != null)
                dGV_membersRow.Columns["電子郵件"].Width = 180;
            if (dGV_membersRow.Columns["UserRole"] != null)
            {
                // 設定 UserRole 欄位自動調整大小
                dGV_membersRow.Columns["UserRole"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        

        // 刪除使用者的方法
        private void F_DeleteUser(int userId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strDBConnectionString))
                {
                    con.Open();
                    string strSQL = "DELETE FROM UsersInfo WHERE Id = @DeleteID";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@DeleteID", userId);
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("刪除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"刪除失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        
       

        private void F_ResetGridViewButtonsAndStyles()
        {
            try
            {
                // 添加操作欄位
                if (!dGV_membersRow.Columns.Contains("編輯") && !dGV_membersRow.Columns.Contains("刪除"))
                {
                    // 添加編輯按鈕欄位
                    DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
                    editColumn.HeaderText = "編輯";
                    editColumn.Name = "編輯";
                    editColumn.Text = "編輯";
                    editColumn.UseColumnTextForButtonValue = true;
                    editColumn.Width = 60;
                    editColumn.FlatStyle = FlatStyle.Flat;
                    editColumn.DefaultCellStyle.BackColor = Color.FromArgb(200, 220, 255);
                    editColumn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(150, 180, 255);
                    editColumn.DefaultCellStyle.Padding = new Padding(0);
                    editColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    // 設定按鈕填滿模式
                    editColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                    dGV_membersRow.Columns.Insert(0, editColumn);

                    // 添加刪除按鈕欄位
                    DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
                    deleteColumn.HeaderText = "刪除";
                    deleteColumn.Name = "刪除";
                    deleteColumn.Text = "刪除";
                    deleteColumn.UseColumnTextForButtonValue = true;
                    deleteColumn.Width = 60;
                    deleteColumn.FlatStyle = FlatStyle.Flat;
                    deleteColumn.DefaultCellStyle.BackColor = Color.FromArgb(255, 200, 200);
                    deleteColumn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 150, 150);
                    deleteColumn.DefaultCellStyle.Padding = new Padding(0);
                    deleteColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    // 設定按鈕填滿模式
                    deleteColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                    dGV_membersRow.Columns.Insert(1, deleteColumn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"重設表格樣式時發生錯誤：{ex.Message}", "錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 編輯按鈕點擊事件
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (sender is UCIcon_RoundBtn btn)
            {
                int memberId = (int)btn.Tag;
                F_ShowDetail(memberId);
            }
        }

        

        // EVENT
        private void Form_ManageUserInfo_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"."; //伺服器名稱，也可以填入「.」、IP位置、網域名稱，用 @ 不處理字元控制，避免 / 問題。
            scsb.InitialCatalog = "MyDB"; //資料庫名稱
            scsb.IntegratedSecurity = true; //Windows 驗證：True

            strDBConnectionString = scsb.ConnectionString.ToString();
            cBox_QueryFieldChoose.Items.Add("姓名");
            cBox_QueryFieldChoose.Items.Add("電話");
            //cBox_QueryFieldChoose.Items.Add("Address");
            cBox_QueryFieldChoose.Items.Add("信箱");
            cBox_QueryFieldChoose.Items.Add("權限");
            cBox_QueryFieldChoose.SelectedIndex = 0;

            // 基本的 DataGridView 設定
            dGV_membersRow.BorderStyle = BorderStyle.None;
            dGV_membersRow.BackgroundColor = Color.White;
            dGV_membersRow.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dGV_membersRow.GridColor = Color.FromArgb(240, 240, 240);
            dGV_membersRow.RowHeadersVisible = false;
            dGV_membersRow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            //讓編輯與刪除按鈕佈滿
            dGV_membersRow.ColumnHeadersDefaultCellStyle.Padding = new Padding(0);
            dGV_membersRow.DefaultCellStyle.Padding = new Padding(0);

            F_CustomizeDataGridView();

            // 註冊 DataGridView 事件
            dGV_membersRow.CellPainting += DGV_membersRow_CellPainting;
            dGV_membersRow.CellClick += DGV_membersRow_CellClick;

            //// 確保所有按鈕都在最上層
            //foreach (var buttons in rowButtons.Values)
            //{
            //    buttons.EditBtn.BringToFront();
            //    buttons.DeleteBtn.BringToFront();
            //}

            F_SetTextBoxesReadOnly();
        }

        

        private void btn_LinkTest_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open(); // 開啟資料庫連線
            string strSQL = "SELECT TOP 100 * FROM UsersInfo; ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string strMsg = ""; int count = 0;

            while (reader.Read() == true)
            {
                int id = (int)reader["Id"]; //
                string name = (string)reader["UserName"];
                string phone = (string)reader["UserPhone"];
                //string address = (string)reader["Address"];
                string email = (string)reader["UserEmail"];              
                int role = (int)reader["UserRole"];

                strMsg += $"{id} {name} {phone} {email} {role} \n";
                count++;
                
            }

            strMsg += "--------------------------";
            strMsg += $"資料筆數:{count}";

            // memory 釋放
            reader.Close(); //先關讀取器
            con.Close(); //再關連線
            MessageBox.Show(strMsg);

        }   

        private void btn_QuerySearch_Click(object sender, EventArgs e)
        {
            if (txt_Query.Text != "")
            {
                
                searchResult.Clear();

                string strFieldName = "";
                switch (cBox_QueryFieldChoose.SelectedItem.ToString())
                {
                    case "姓名":
                        strFieldName = "UserName";
                        break;
                    case "電話":
                        strFieldName = "UserPhone";
                        break;
                    case "信箱":
                        strFieldName = "UserEmail";
                        break;
                    case "權限":
                        strFieldName = "UserRole";
                        break;
                    
                    default:
                        MessageBox.Show("請選擇項目");
                        break;
                }

                
             
                
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "";
                SqlCommand cmd = new SqlCommand();

                if (strFieldName == "UserRole")
                {
                    strSQL = $@"SELECT 
                                    Id as [會員編號], 
                                    UserName, 
                                    UserPhone, 
                                    UserEmail as [電子郵件], 
                                    UserRole 
                                FROM UsersInfo 
                                WHERE {strFieldName} = @SearchQuery;";
                    

                    try
                    {
                        cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@SearchQuery", Convert.ToInt32(txt_Query.Text));
                        
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("請輸入有效的數字！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                { 
                    strSQL = $@"SELECT 
                                    Id as [會員編號], 
                                    UserName, 
                                    UserPhone, 
                                    UserEmail as [電子郵件], 
                                    UserRole 
                                FROM UsersInfo 
                                WHERE {strFieldName} LIKE @SearchQuery;";
                    cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchQuery", $"%{txt_Query.Text.Trim()}%");
                    

                }

                
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    DGVtotNum = dt.Rows.Count;
                    dGV_membersRow.DataSource = null; // 先清空資料源
                    dGV_membersRow.DataSource = dt;
                    F_ResetGridViewButtonsAndStyles();
                }
                else
                {
                    MessageBox.Show("查無此人");
                    // 重新執行查詢以填充 DataGridView
                    reader.Close();
                    cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    DGVtotNum = dt.Rows.Count;

                    dGV_membersRow.DataSource = null; // 先清空資料源


                    
                }

                reader.Close();
                con.Close();
            }
        }


        private void DGV_membersRow_CellClick(object sender, DataGridViewCellEventArgs e) //寫 編輯 與 刪除按鈕的觸發事件
        {
            

            if (e.RowIndex >= 0)
            {
                var row = dGV_membersRow.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["會員編號"].Value);
                string userName = row.Cells["UserName"].Value.ToString();

                if (e.ColumnIndex == dGV_membersRow.Columns["編輯"].Index) // 編輯按鈕的觸發
                {
                    gBox_DetailInfo.Text = "詳細資料(編輯)";
                    ucIcon_SaveInfo.Visible = true;
                    ucIcon_CancelEdit.Visible = true;
                    F_ShowDetail(id);
                    F_SetTextBoxesEditable();

                }
                else if (e.ColumnIndex == dGV_membersRow.Columns["刪除"].Index) //刪除按鈕的觸發
                {
                    DialogResult result = MessageBox.Show(
                        $"確定要刪除使用者 {userName} 嗎？",
                        "確認刪除",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        F_DeleteUser(id);
                        ucIcon_ShowAll_Click(null, null);
                    }
                }
            }

        } 


        private void ucIcon_ShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                // 檢查當前用戶是否存在
                if (GlobalVar.CurrentUser == null)
                {
                    MessageBox.Show("請先登入系統", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "";

                // 根據用戶權限設定查詢語句
                switch (GlobalVar.CurrentUser.UserRole)
                {
                    case 0: // 最高管理員，可以查看所有資料
                        strSQL = @"SELECT 
                                    Id as [會員編號], 
                                    UserName, 
                                    UserPhone, 
                                    UserEmail as [電子郵件], 
                                    UserRole 
                                 FROM UsersInfo";
                        break;

                    case 1: // 管理員，可以查看除了最高管理員(Role=0)以外的資料
                        strSQL = @"SELECT 
                                    Id as [會員編號], 
                                    UserName, 
                                    UserPhone, 
                                    UserEmail as [電子郵件], 
                                    UserRole 
                                 FROM UsersInfo 
                                 WHERE UserRole > 0";
                        break;

                    case 2: // 一般員工，只能查看比自己權限低的資料
                        strSQL = @"SELECT 
                                    Id as [會員編號], 
                                    UserName, 
                                    UserPhone, 
                                    UserEmail as [電子郵件], 
                                    UserRole 
                                 FROM UsersInfo 
                                 WHERE UserRole > 2";
                        break;

                    default: // 其他角色，限制查看
                        MessageBox.Show("您沒有權限查看會員資料", "權限不足", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

                // 加入額外的安全性檢查
                if (string.IsNullOrEmpty(strSQL))
                {
                    MessageBox.Show("查詢條件無效", "錯誤", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlCommand cmd = new SqlCommand(strSQL, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            DGVtotNum = dt.Rows.Count;
                            dGV_membersRow.DataSource = null; // 先清空資料源
                            dGV_membersRow.DataSource = dt;
                            F_ResetGridViewButtonsAndStyles();
                            F_CustomizeDataGridView();

                            // 根據權限設定介面元素
                            ConfigureInterfaceByRole(GlobalVar.CurrentUser.UserRole);
                        }
                        else
                        {
                            MessageBox.Show("沒有符合條件的資料", "提示", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入資料時發生錯誤：{ex.Message}", "錯誤", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 根據用戶角色配置介面
        private void ConfigureInterfaceByRole(int userRole)
        {
            switch (userRole)
            {
                case 0: // 最高管理員
                    // 允許所有操作
                    break;

                case 1: // 管理員
                    // 可能需要隱藏某些功能按鈕
                    break;

                case 2: // 一般員工
                    // 限制編輯和刪除功能
                    foreach (DataGridViewRow row in dGV_membersRow.Rows)
                    {
                        if (row.Cells["UserRole"].Value != null)
                        {
                            int rowRole = Convert.ToInt32(row.Cells["UserRole"].Value);
                            if (rowRole <= 2) // 如果資料列的角色權限大於等於當前用戶
                            {
                                // 禁用該列的編輯和刪除按鈕
                                if (row.Cells["編輯"] is DataGridViewButtonCell editCell)
                                {
                                    //editCell.Visible = false;
                                    editCell.Style.BackColor = Color.LightGray;
                                }
                                if (row.Cells["刪除"] is DataGridViewButtonCell deleteCell)
                                {
                                    //deleteCell.Visible = false;
                                    deleteCell.Style.BackColor = Color.LightGray;
                                }
                            }
                        }
                    }
                    break;
            }
        }

        private void DGV_membersRow_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // 移除原本的按鈕繪製程式碼
            // 如果不需要特殊的儲存格繪製，可以完全移除這個事件處理器
        }

       

        private void DGV_membersRow_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateButtonPositions();
        }

        private void UpdateButtonPositions()
        {
            // 獲取 DataGridView 的可視區域
            Rectangle visibleRect = dGV_membersRow.ClientRectangle;
            // 考慮垂直滾動的位置
            visibleRect.Y = dGV_membersRow.VerticalScrollingOffset;

          
        }

        private void dGV_membersRow_CellClick_ShowtoBox(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // 確保點擊的是資料列而不是標題列
            {
                try
                {
                    DataGridViewRow row = dGV_membersRow.Rows[e.RowIndex];

                    // 填充各個文字框
                    txt_ID.Text = row.Cells["會員編號"].Value?.ToString() ?? "";
                    txt_Name.Text = row.Cells["UserName"].Value?.ToString() ?? "";
                    txt_Phone.Text = row.Cells["UserPhone"].Value?.ToString() ?? "";
                    // txt_Address.Text = ""; // 如果之後需要顯示地址，可以在這裡加入
                    txt_Email.Text = row.Cells["電子郵件"].Value?.ToString() ?? "";
                    txt_Pwd.Text = "未知"; // 密碼欄位顯示為"未知"
                    txt_UserRole.Text = row.Cells["UserRole"].Value?.ToString() ?? "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"讀取資料時發生錯誤：{ex.Message}", "錯誤",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ucIcon_SaveInfo_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txt_ID.Text, out intID);

            if (ucIcon_SaveInfo.Tag?.ToString() == "Add")
            {
                // "新增"資料 邏輯
                if (txt_Name.Text != "" && txt_Phone.Text != "" && txt_Email.Text != "")
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(strDBConnectionString);
                        con.Open();

                        string strSQL = @"INSERT INTO UsersInfo 
                                (UserName, UserPhone, UserEmail, UserPassword, UserRole) 
                                VALUES 
                                (@newName, @newPhone, @newEmail, @newPwd, @newRole);";

                        SqlCommand cmd = new SqlCommand(strSQL, con);

                        cmd.Parameters.AddWithValue("@newName", txt_Name.Text);
                        cmd.Parameters.AddWithValue("@newPhone", txt_Phone.Text);
                        cmd.Parameters.AddWithValue("@newEmail", txt_Email.Text);
                        cmd.Parameters.AddWithValue("@newPwd", txt_Pwd.Text);

                        int intRole = 0;
                        Int32.TryParse(txt_UserRole.Text, out intRole);
                        cmd.Parameters.AddWithValue("@newRole", intRole);

                        int rows = cmd.ExecuteNonQuery();
                        con.Close();

                        if (rows > 0)
                        {
                            MessageBox.Show("資料新增成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // 重置表單
                            F_SetTextBoxesReadOnly();
                            ucIcon_SaveInfo.Visible = false;
                            ucIcon_CancelEdit.Visible = false;
                            gBox_DetailInfo.Text = "詳細資料(唯讀)";
                            ucIcon_SaveInfo.Tag = null; // 重設tag
                            txt_UserRole.Enabled = false;
                            // 重新載入資料表
                            ucIcon_ShowAll_Click(null, null);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"資料新增失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("請確認所有必填欄位都已填寫！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (intID > 0 && txt_Name.Text != "" && txt_Phone.Text != "" && txt_Email.Text != "")
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(strDBConnectionString);
                        con.Open();

                        string strSQL = "UPDATE UsersInfo SET UserName = @newName, UserPhone = @newPhone, UserEmail = @newEmail WHERE Id = @searchId;";
                        SqlCommand cmd = new SqlCommand(strSQL, con);

                        cmd.Parameters.AddWithValue("@searchId", intID);
                        cmd.Parameters.AddWithValue("@newName", txt_Name.Text);
                        cmd.Parameters.AddWithValue("@newPhone", txt_Phone.Text);
                        cmd.Parameters.AddWithValue("@newEmail", txt_Email.Text);

                        int rows = cmd.ExecuteNonQuery();
                        con.Close();

                        if (rows > 0)
                        {
                            MessageBox.Show("資料修改成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            F_SetTextBoxesReadOnly(); // 回到唯讀模式
                            ucIcon_SaveInfo.Visible = false; // 隱藏儲存按鈕
                            ucIcon_CancelEdit.Visible = false; // 隱藏取消按鈕

                            // 重新載入資料表
                            ucIcon_ShowAll_Click(null, null);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"資料修改失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("請確認所有必填欄位都已填寫！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            
        }

        private void ucIcon_CancelEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定要取消編輯嗎？未儲存的修改將會遺失。", 
                "確認取消", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 重新載入原始資料
                int intID = 0;
                Int32.TryParse(txt_ID.Text, out intID);
                if (intID > 0)
                {
                    F_ShowDetail(intID);
                }

                F_SetTextBoxesReadOnly(); // 回到唯讀模式
                ucIcon_SaveInfo.Visible = false; // 隱藏儲存按鈕
                ucIcon_CancelEdit.Visible = false; // 隱藏取消按鈕
                gBox_DetailInfo.Text = "詳細資料(唯讀)";
                gBox_DetailInfo.BackColor = Color.FromArgb(211,236,250);
            }
        }

        // 設定所有 TextBox 為唯讀模式
        private void F_SetTextBoxesReadOnly()
        {
            // 設定唯讀狀態
            txt_ID.Enabled = false;
            txt_Name.Enabled = false;
            txt_Phone.Enabled = false;
            txt_Email.Enabled = false;
            txt_Pwd.Enabled = false;
            //txt_UserRole.Enabled = false;

            
            txt_ID.BorderStyle = BorderStyle.None;
            txt_Name.BorderStyle = BorderStyle.None;
            txt_Phone.BorderStyle = BorderStyle.None;
            txt_Email.BorderStyle = BorderStyle.None;
            txt_Pwd.BorderStyle = BorderStyle.None;
            txt_UserRole.BorderStyle = BorderStyle.None;

            // 設定背景色為淺灰色
            Color ForBack = Color.White;
            txt_ID.BackColor = ForBack;
            txt_Name.BackColor = ForBack;
            txt_Phone.BackColor = ForBack;
            txt_Email.BackColor = ForBack;
            txt_Pwd.BackColor = ForBack;
            txt_UserRole.BackColor = ForBack;

            //設定字體顏色
            // 設定背景色為淺灰色
            Color ForFore = Color.Black;
            txt_ID.ForeColor = ForFore;
            txt_Name.ForeColor = ForFore;
            txt_Phone.ForeColor = ForFore;
            txt_Email.ForeColor = ForFore;
            txt_Pwd.ForeColor = ForFore;
            txt_UserRole.ForeColor = ForFore;
        }

        // 設定所有 TextBox 為可編輯模式
        private void F_SetTextBoxesEditable()
        {
            // 設定可編輯狀態
            txt_ID.Enabled = false; // ID 保持唯讀
            txt_Name.Enabled = true;
            txt_Phone.Enabled = true;
            txt_Email.Enabled = true;
            txt_Pwd.Enabled = true;
            //txt_UserRole.Enabled = true;

            // 設定邊框為淺藍色加粗
            Color lightBlue = Color.FromArgb(100, 181, 246);
            txt_Name.BorderStyle = BorderStyle.FixedSingle;
            txt_Phone.BorderStyle = BorderStyle.FixedSingle;
            txt_Email.BorderStyle = BorderStyle.FixedSingle;
            txt_Pwd.BorderStyle = BorderStyle.FixedSingle;
            //txt_UserRole.BorderStyle = BorderStyle.FixedSingle;

            // 設定背景色為白色
            txt_Name.BackColor = Color.White;
            txt_Phone.BackColor = Color.White;
            txt_Email.BackColor = Color.White;
            txt_Pwd.BackColor = Color.White;
            txt_UserRole.BackColor = Color.White;
        }

        private void ucIcon_AddMember_Click(object sender, EventArgs e)
        {
            // 清空所有欄位
            txt_ID.Clear();
            txt_ID.Text = " - 1 ";
            txt_Name.Clear();
            txt_Phone.Clear();
            txt_Email.Clear();
            txt_Pwd.Clear();
            txt_UserRole.Clear();

            // 設定欄位為可編輯狀態
            F_SetTextBoxesEditable();

            // 修改群組框標題
            gBox_DetailInfo.Text = "詳細資料(新增)";
            gBox_DetailInfo.BackColor = Color.LightGreen;

            // 顯示儲存和取消按鈕
            ucIcon_SaveInfo.Visible = true;
            ucIcon_CancelEdit.Visible = true;

            // 修改儲存按鈕的 Tag 來標識這是新增操作
            ucIcon_SaveInfo.Tag = "Add";

            txt_UserRole.Enabled = true;
            txt_UserRole.BorderStyle = BorderStyle.FixedSingle;
        }

        private void ucIcon_Refresh_Click(object sender, EventArgs e)
        {
            F_ClearField();

            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = @"SELECT 
                                Id as [會員編號], 
                                UserName, 
                                UserPhone, 
                                UserEmail as [電子郵件], 
                                UserRole 
                             FROM UsersInfo";  // 移除 TOP 500，因為我們的資料表只有 10 筆

            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                DGVtotNum = dt.Rows.Count;
                dGV_membersRow.DataSource = null; // 先清空資料源
                dGV_membersRow.DataSource = dt;
                F_ResetGridViewButtonsAndStyles();
            }

            reader.Close();
            con.Close();
        }


        private void ucIcon_RoundBtn1_Click(object sender, EventArgs e)
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
        // -------------------------------------------

    }
}
