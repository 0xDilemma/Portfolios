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
using System.IO;
using System.Web;
using System.Security.Cryptography;

namespace WFA_SketchVerB
{
    public partial class Form_NewGoods : Form
    {
        // Var
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder(); // 資料庫連線字串建立器
        List<int> searchResult = new List<int>(); // 用於存搜尋結果。 Hint：用 int 存，因為 SQL 的 ID PK
        int DGVtotNum = 0; // 總筆數
        // 設定基礎路徑（使用使用者文件資料夾）
        string documentsPath = GlobalVar.image_dir; // 直接套用 GV 路徑
        bool isModifyImage = false;


        //--- 拖曳用----
        private bool beginMove = false;
        private int currentXPos; private int currentYPos;
        WFA_SketchVerB.UserControl_ItemsShow U1 = new WFA_SketchVerB.UserControl_ItemsShow();

        private bool isAddMode = false; // 用於追蹤��前模式

        // Method
        private void F_ResetGridViewButtonsAndStyles() // 添加編輯與刪除
        {
            try
            {
                // 添加操作欄位
                if (!dGV_ItemsRow.Columns.Contains("編輯") && !dGV_ItemsRow.Columns.Contains("刪除"))
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

                    dGV_ItemsRow.Columns.Insert(0, editColumn);

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

                    dGV_ItemsRow.Columns.Insert(1, deleteColumn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"重設表格樣式時發生錯誤：{ex.Message}", "錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void F_CustomizeDataGridView() // 客製化表格樣式
        {

            // 設定整個 DataGridView 為唯讀模式
            dGV_ItemsRow.ReadOnly = true;

            // 基本樣式設定
            dGV_ItemsRow.BorderStyle = BorderStyle.None;
            dGV_ItemsRow.BackgroundColor = Color.White;
            dGV_ItemsRow.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dGV_ItemsRow.GridColor = Color.FromArgb(240, 240, 240);
            dGV_ItemsRow.RowHeadersVisible = false;

            // 設定選取樣式
            dGV_ItemsRow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGV_ItemsRow.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 200, 255);
            dGV_ItemsRow.DefaultCellStyle.SelectionForeColor = Color.Black;

            // 設定標題列樣式
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.BackColor = Color.FromArgb(240, 240, 255);
            headerStyle.ForeColor = Color.Black;
            headerStyle.Font = new Font("微軟正黑體", 10, FontStyle.Regular);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.Padding = new Padding(10, 0, 0, 0);
            dGV_ItemsRow.ColumnHeadersDefaultCellStyle = headerStyle;
            dGV_ItemsRow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dGV_ItemsRow.ColumnHeadersHeight = 40;

            // 設定資料列樣式
            DataGridViewCellStyle rowStyle = new DataGridViewCellStyle();
            rowStyle.BackColor = Color.White;
            rowStyle.ForeColor = Color.Black;
            rowStyle.Font = new Font("微軟正黑體", 9, FontStyle.Regular);
            rowStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            rowStyle.Padding = new Padding(10, 0, 0, 0);
            dGV_ItemsRow.DefaultCellStyle = rowStyle;
            dGV_ItemsRow.RowTemplate.Height = 35;

            // 設定交替列顏色
            foreach (DataGridViewRow row in dGV_ItemsRow.Rows)
            {
                if (row.Index % 2 == 1) // 針對奇數列
                {
                    for (int i = 2; i < dGV_ItemsRow.Columns.Count; i++) // 從第3欄開始（跳過編輯和刪除按鈕）
                    {
                        row.Cells[i].Style.BackColor = Color.FromArgb(240, 240, 255);
                        row.Cells[i].Style.ForeColor = Color.Black;
                        row.Cells[i].Style.Font = new Font("微軟正黑體", 9, FontStyle.Regular);
                        row.Cells[i].Style.Padding = new Padding(10, 0, 0, 0);
                    }
                }
            }


            // 修改欄位寬度設定
            if (dGV_ItemsRow.Columns["編輯"] != null)
                dGV_ItemsRow.Columns["編輯"].Width = 60;
            if (dGV_ItemsRow.Columns["刪除"] != null)
                dGV_ItemsRow.Columns["刪除"].Width = 60;
            if (dGV_ItemsRow.Columns["ID"] != null)
                dGV_ItemsRow.Columns["ID"].Width = 60;
            if (dGV_ItemsRow.Columns["品名"] != null)
                dGV_ItemsRow.Columns["品名"].Width = 120;
            if (dGV_ItemsRow.Columns["庫存"] != null)
                dGV_ItemsRow.Columns["庫存"].Width = 60;
            if (dGV_ItemsRow.Columns["單價"] != null)
                dGV_ItemsRow.Columns["單價"].Width = 80;
            if (dGV_ItemsRow.Columns["品牌"] != null)
                dGV_ItemsRow.Columns["品牌"].Width = 80;
            if (dGV_ItemsRow.Columns["補貨"] != null)
                dGV_ItemsRow.Columns["補貨"].Width = 60;
            if (dGV_ItemsRow.Columns["上架時間"] != null)
                dGV_ItemsRow.Columns["上架時間"].Width = 100;
            if (dGV_ItemsRow.Columns["更新時間"] != null)
                dGV_ItemsRow.Columns["更新時間"].Width = 100;
            if (dGV_ItemsRow.Columns["上下架"] != null)
            {
                // 設定 UserRole 欄位自動調整
                dGV_ItemsRow.Columns["上下架"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        // 建構
        public Form_NewGoods()
        {
            InitializeComponent();
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

        private void ucIcon_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucIcon_ShowAll_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnection))
            {
                con.Open();
                string strSQL = @"SELECT  
                                ProductID as ID,
                                ProductName as 品名,
                                QuantityInStock as 庫存,
                                UnitPrice as 單價,
                                Brand as 品牌,
                                ReorderLevel as 補貨,
                                DateAdded as 上架時間,
                                LastUpdated as 更新時間,
                                IsActive as 上下架
                             FROM FoodProducts";

                using (SqlCommand cmd = new SqlCommand(strSQL, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        DGVtotNum = dt.Rows.Count;
                        dGV_ItemsRow.DataSource = null; // 先清空資料源
                        dGV_ItemsRow.DataSource = dt;
                        F_ResetGridViewButtonsAndStyles();
                        F_CustomizeDataGridView();
                    }

                }// expose reader & cmd
            }// expose con
            ResetForm();
         }

        private void dGV_ItemsRow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 清空圖片
            pBox_Primary.Image = null;
            pBox_Content1.Image = null;
            pBox_Content2.Image = null;
            SwitchToDisplayMode();
            if (e.RowIndex >= 0) // 確保點擊的是資料列而不是標題列
            {
                // 檢查是否點擊了編輯或刪除按鈕
                if (e.ColumnIndex == dGV_ItemsRow.Columns["編輯"].Index)
                {
                    using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnection))
                    {
                        con.Open();
                        // 針對資料表 ProductImages 讀圖
                        string strSQLImages = @"SELECT 
                                    ImageFilename, 
                                    IsPrimary 
                                FROM ProductImages 
                                WHERE ProductID = @ProductID";

                        using (SqlCommand cmdImages = new SqlCommand(strSQLImages, con))
                        {
                            cmdImages.Parameters.AddWithValue("@ProductID", lbl_ID.Text);
                            using (SqlDataReader readerImages = cmdImages.ExecuteReader())
                            {
                                int primaryCount = 0;
                                while (readerImages.Read())
                                {
                                    string imagePath = Path.Combine(documentsPath, readerImages["ImageFilename"]?.ToString());

                                    bool isPrimary = (bool)readerImages["IsPrimary"];

                                    if (isPrimary && primaryCount == 0)
                                    {
                                        // 載入主要圖片
                                        pBox_Primary.Image = Image.FromFile(imagePath);
                                        primaryCount++;
                                    }
                                    else if (primaryCount < 3)
                                    {
                                        // 載入其他圖片
                                        if (primaryCount == 1)
                                        {
                                            pBox_Content1.Image = Image.FromFile(imagePath);
                                        }
                                        else if (primaryCount == 2)
                                        {
                                            pBox_Content2.Image = Image.FromFile(imagePath);
                                        }
                                        primaryCount++;
                                    }
                                }
                            } // expose readerImages
                        } // expose cmdImages


                    }
                        isAddMode = true;
                    // 切換到編輯模式
                    SwitchToEditMode();
                }
                else if (e.ColumnIndex == dGV_ItemsRow.Columns["刪除"].Index)
                {
                    // 執行刪除操作
                    DeleteProduct(e.RowIndex);
                }
                else
                {
                    try
                    {
                        DataGridViewRow row = dGV_ItemsRow.Rows[e.RowIndex];

                        // 填充各個文字框
                        lbl_ID.Text = row.Cells["ID"].Value?.ToString() ?? "";
                        txt_ItemName.Text = row.Cells["品名"].Value?.ToString() ?? "";
                        txt_Brand.Text = row.Cells["品牌"].Value?.ToString() ?? "";
                        txt_Stock.Text = row.Cells["庫存"].Value?.ToString() ?? "";
                        txt_Price.Text = $"NT$ {row.Cells["單價"].Value?.ToString() ?? ""}";


                        using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnection))
                        {
                            con.Open();
                            string strSQL = @"SELECT  
                                    Description,
                                    Ingredient,
                                    Nutrients
                                 FROM ProductDetails
                                 WHERE ProductID = @SearchID";

                            using (SqlCommand cmd = new SqlCommand(strSQL, con))
                            {
                                // 在這裡添加參數
                                cmd.Parameters.AddWithValue("@SearchID", lbl_ID.Text);

                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.HasRows)
                                    {
                                        reader.Read(); // 讀取第一行資料
                                        txt_Intro.Text = reader["Description"]?.ToString() ?? ""; // 設定 Description
                                        txt_Ingredient.Text = reader["Ingredient"]?.ToString() ?? ""; // 設定 Ingredient
                                        txt_Nutrients.Text = reader["Nutrients"]?.ToString() ?? ""; // 設定 Nutrients
                                    }
                                } // expose reader
                            } // expose cmd

                            // 針對資料表 ProductImages 讀圖
                            string strSQLImages = @"SELECT 
                                    ImageFilename, 
                                    IsPrimary 
                                FROM ProductImages 
                                WHERE ProductID = @ProductID";

                            using (SqlCommand cmdImages = new SqlCommand(strSQLImages, con))
                            {
                                cmdImages.Parameters.AddWithValue("@ProductID", lbl_ID.Text);
                                using (SqlDataReader readerImages = cmdImages.ExecuteReader())
                                {
                                    int primaryCount = 0;
                                    while (readerImages.Read())
                                    {
                                        string imagePath = Path.Combine(documentsPath, readerImages["ImageFilename"]?.ToString());

                                        bool isPrimary = (bool)readerImages["IsPrimary"];

                                        if (isPrimary && primaryCount == 0)
                                        {
                                            // 載入主要圖片
                                            pBox_Primary.Image = Image.FromFile(imagePath);
                                            primaryCount++;
                                        }
                                        else if (primaryCount < 3)
                                        {
                                            // 載入其他圖片
                                            if (primaryCount == 1)
                                            {
                                                pBox_Content1.Image = Image.FromFile(imagePath);
                                            }
                                            else if (primaryCount == 2)
                                            {
                                                pBox_Content2.Image = Image.FromFile(imagePath);
                                            }
                                            primaryCount++;
                                        }
                                    }
                                } // expose readerImages
                            } // expose cmdImages
                        }// expose con

                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"讀取資料時發生錯誤：{ex.Message}", "錯誤",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Form_NewGoods_Load(object sender, EventArgs e)
        {
            documentsPath = Path.Combine(documentsPath, "ItemPicture\\Products"); ;
            pBox_Primary.SizeMode = PictureBoxSizeMode.Zoom;
            pBox_Content1.SizeMode = PictureBoxSizeMode.Zoom;
            pBox_Content2.SizeMode = PictureBoxSizeMode.Zoom;
            ResetForm();
        }

        private void ucIcon_AddGood_Click(object sender, EventArgs e)
        {
            
            isAddMode = true;
            // 換到新增模式
            SwitchToAddMode();
        }

        private void SwitchToAddMode()
        {
            // 設定淡綠色背景
            Color addModeColor = Color.FromArgb(192, 255, 192);
            lbl_Modecolor.BackColor = addModeColor;

            // 設定相關 Label 背景色
            label2.BackColor = addModeColor; // 
            label10.BackColor = addModeColor; // 
            lbl_Picture1.BackColor = addModeColor; // 
            lbl_Picture2.BackColor = addModeColor; // 
            label11.BackColor = addModeColor; // 
            lbl_IDShow.BackColor = addModeColor;
            lbl_ID.BackColor = addModeColor;
            label14.BackColor = addModeColor;
            label15.BackColor = addModeColor;
            label12.BackColor = addModeColor;
            label13.BackColor = addModeColor;


            // 設定 Panel 背景色
            panel4.BackColor = addModeColor; // 簡介面板
            panel5.BackColor = addModeColor; // 營養分析面板
            panel6.BackColor = addModeColor; // 成份面板

            // btn show
            ucIcon_Save.Visible = true;
            ucIcon_Save.Text = "確定新增";

            ucIcon_CancelEdit.Visible = true;

            // 釋放現有圖片資源
            DisposePictureBoxImage(pBox_Primary);
            DisposePictureBoxImage(pBox_Content1);
            DisposePictureBoxImage(pBox_Content2);

            // 清空所有欄位
            txt_ItemName.Text = "";
            txt_ItemName.ReadOnly = false;
            txt_Brand.Text = "";
            txt_Brand.ReadOnly = false;
            txt_Price.Text = "";
            txt_Price.ReadOnly = false;
            txt_Price.BackColor = Color.White;
            txt_Stock.BackColor = Color.White;
            txt_Stock.Text = "";
            txt_Stock.ReadOnly = false;
            txt_Intro.Text = "";
            txt_Intro.ReadOnly = false;
            txt_Ingredient.Text = "";
            txt_Ingredient.ReadOnly = false;
            txt_Nutrients.Text = "";
            txt_Nutrients.ReadOnly = false;
            lbl_ID.Text = "(新商品)";
            
            // 清空圖片
            pBox_Primary.Image = null;
            pBox_Content1.Image = null;
            pBox_Content2.Image = null;

            // 設定圖片框點擊事件
            pBox_Primary.Click += PictureBox_Click;
            pBox_Content1.Click += PictureBox_Click;
            pBox_Content2.Click += PictureBox_Click;

            // 改變游標樣式以表示可點擊
            pBox_Primary.Cursor = Cursors.Hand;
            pBox_Content1.Cursor = Cursors.Hand;
            pBox_Content2.Cursor = Cursors.Hand;

            
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (!isAddMode) return;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "PNG 檔案|*.png";
                ofd.Title = "選擇商品圖片";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    PictureBox currentPBox = (PictureBox)sender;
                    
                    try
                    {
                        // 釋放現有圖片資源
                        if (currentPBox.Image != null)
                        {
                            currentPBox.Image.Dispose();
                            currentPBox.Image = null;
                        }

                        System.IO.FileStream fs = System.IO.File.OpenRead(ofd.FileName);
                        currentPBox.Image = Image.FromStream(fs);

                        // 儲存原始圖片路徑到 Tag 屬性
                        currentPBox.Tag = ofd.FileName;
                        Console.WriteLine(ofd.FileName);
                        isModifyImage = true;
                        fs.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"載入圖片時發生錯誤：{ex.Message}", "錯誤",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            if(ucIcon_Save.Text == "確定新增")
            {
                if (ValidateInput())
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnection))
                        {
                            con.Open();

                            // 1. 新增商品基本資料
                            string strSQL = @"INSERT INTO FoodProducts 
                            (ProductName, UnitPrice, Brand, QuantityInStock, ReorderLevel, IsActive) 
                            OUTPUT INSERTED.ProductID
                            VALUES (@name, @price, @brand, @stock, @reorder, @active)";

                            int newProductId;
                            using (SqlCommand cmd = new SqlCommand(strSQL, con))
                            {
                                // 這裡需要添加相應的參數值
                                cmd.Parameters.AddWithValue("@name", txt_ItemName.Text);
                                cmd.Parameters.AddWithValue("@price", ParsePrice(txt_Price.Text));
                                cmd.Parameters.AddWithValue("@brand", txt_Brand.Text);
                                cmd.Parameters.AddWithValue("@stock", int.Parse(txt_Stock.Text));
                                cmd.Parameters.AddWithValue("@reorder", 10);
                                cmd.Parameters.AddWithValue("@active", true);

                                newProductId = (int)cmd.ExecuteScalar();
                            }

                            // 2. 新增商品詳細資料
                            strSQL = @"INSERT INTO ProductDetails 
                            (ProductID, ProductName, Description, Ingredient, Nutrients) 
                            VALUES (@productId, @PName, @desc, @ingr, @nutr)";

                            using (SqlCommand cmd = new SqlCommand(strSQL, con))
                            {
                                cmd.Parameters.AddWithValue("@productId", newProductId);
                                cmd.Parameters.AddWithValue("@PName", txt_ItemName.Text);
                                cmd.Parameters.AddWithValue("@desc", txt_Intro.Text);
                                cmd.Parameters.AddWithValue("@ingr", txt_Ingredient.Text);
                                cmd.Parameters.AddWithValue("@nutr", txt_Nutrients.Text);
                                cmd.ExecuteNonQuery();
                            }

                            // 3. 儲存圖片
                            SaveProductImages(newProductId, con);

                            MessageBox.Show("商品新增成功！", "成功",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // 重置表單
                            ResetForm();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"新增商品時發生錯誤：{ex.Message}", "錯誤",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (ucIcon_Save.Text == "確定修改")
            {
                if (ValidateInput())
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnection))
                        {
                            con.Open();
                            using (SqlTransaction transaction = con.BeginTransaction())
                            {
                                try
                                {
                                    int productId = int.Parse(lbl_ID.Text);

                                    // 1. 更新商品基本資料
                                    string updateProductSQL = @"UPDATE FoodProducts 
                                        SET ProductName = @name, 
                                            UnitPrice = @price, 
                                            Brand = @brand, 
                                            QuantityInStock = @stock,
                                            LastUpdated = GETDATE()
                                        WHERE ProductID = @productId";

                                    using (SqlCommand cmd = new SqlCommand(updateProductSQL, con, transaction))
                                    {
                                        cmd.Parameters.AddWithValue("@productId", productId);
                                        cmd.Parameters.AddWithValue("@name", txt_ItemName.Text);
                                        cmd.Parameters.AddWithValue("@price", ParsePrice(txt_Price.Text));
                                        cmd.Parameters.AddWithValue("@brand", txt_Brand.Text);
                                        cmd.Parameters.AddWithValue("@stock", int.Parse(txt_Stock.Text));
                                        cmd.ExecuteNonQuery();
                                    }

                                    // 2. 更新商品詳細資料
                                    string updateDetailsSQL = @"UPDATE ProductDetails 
                                        SET ProductName = @name,
                                            Description = @desc,
                                            Ingredient = @ingr,
                                            Nutrients = @nutr
                                        WHERE ProductID = @productId";

                                    using (SqlCommand cmd = new SqlCommand(updateDetailsSQL, con, transaction))
                                    {
                                        cmd.Parameters.AddWithValue("@productId", productId);
                                        cmd.Parameters.AddWithValue("@name", txt_ItemName.Text);
                                        cmd.Parameters.AddWithValue("@desc", txt_Intro.Text);
                                        cmd.Parameters.AddWithValue("@ingr", txt_Ingredient.Text);
                                        cmd.Parameters.AddWithValue("@nutr", txt_Nutrients.Text);
                                        cmd.ExecuteNonQuery();
                                    }

                                    // 3. 如果有修改圖片，更新圖片
                                    if (isModifyImage)
                                    {
                                        // 先刪除原有圖片
                                        string deleteImagesSQL = "DELETE FROM ProductImages WHERE ProductID = @productId";
                                        using (SqlCommand cmd = new SqlCommand(deleteImagesSQL, con, transaction))
                                        {
                                            cmd.Parameters.AddWithValue("@productId", productId);
                                            cmd.ExecuteNonQuery();
                                        }

                                        // 儲存新圖片
                                        SaveProductImages(productId, con, transaction);
                                    }

                                    transaction.Commit();
                                    MessageBox.Show("商品更新成功！", "成功",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // 重新載入資料
                                    ucIcon_ShowAll_Click(null, null);
                                    ResetForm();
                                }
                                catch (Exception ex)
                                {
                                    transaction.Rollback();
                                    throw new Exception($"更新商品時發生錯誤：{ex.Message}");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"更新商品時發生錯誤：{ex.Message}", "錯誤",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SaveProductImages(int productId, SqlConnection con, SqlTransaction transaction = null)
        {
            // 確保目標資料夾存在
            Directory.CreateDirectory(documentsPath);

            PictureBox[] pictureBoxes = { pBox_Primary, pBox_Content1, pBox_Content2 };
            bool[] isPrimary = { true, false, false };

            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                if (pictureBoxes[i].Image != null && pictureBoxes[i].Tag != null)
                {
                    string sourceFile = pictureBoxes[i].Tag.ToString();
                    string fileName = $"product_{productId}_{i + 1}.png";
                    string destinationFile = Path.Combine(documentsPath, fileName);

                    // 複製圖片到目標資料夾
                    File.Copy(sourceFile, destinationFile, true);

                    // 將圖片資訊儲存到資料庫
                    string strSQL = @"INSERT INTO ProductImages 
                        (ProductID, ImageFilename, IsPrimary) 
                        VALUES (@productId, @filename, @isPrimary)";

                    using (SqlCommand cmd = new SqlCommand(strSQL, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        cmd.Parameters.AddWithValue("@filename", fileName);
                        cmd.Parameters.AddWithValue("@isPrimary", isPrimary[i]);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private bool ValidateInput()
        {
            // 檢查商品名稱
            if (string.IsNullOrWhiteSpace(txt_ItemName.Text))
            {
                MessageBox.Show("請輸入商品名稱", "驗證錯誤", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ItemName.Focus();
                return false;
            }

            // 檢查品牌
            if (string.IsNullOrWhiteSpace(txt_Brand.Text))
            {
                MessageBox.Show("請輸入品牌名稱", "驗證錯誤", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Brand.Focus();
                return false;
            }

            // 檢查價格
            if (string.IsNullOrWhiteSpace(txt_Price.Text) || ParsePrice(txt_Price.Text) <= 0)
            {
                MessageBox.Show("請輸入有效的商品價格", "驗證錯誤", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Price.Focus();
                return false;
            }

            // 檢查庫存
            if (string.IsNullOrWhiteSpace(txt_Stock.Text) || !int.TryParse(txt_Stock.Text, out int stock))
            {
                MessageBox.Show("請輸入有效的庫存數量", "驗證錯誤", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Stock.Focus();
                return false;
            }

            // 檢查簡介
            if (string.IsNullOrWhiteSpace(txt_Intro.Text))
            {
                MessageBox.Show("請輸入商品簡介", "驗證錯誤", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Intro.Focus();
                return false;
            }

            // 檢查成分
            if (string.IsNullOrWhiteSpace(txt_Ingredient.Text))
            {
                MessageBox.Show("請輸入商品成分", "驗證錯誤", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Ingredient.Focus();
                return false;
            }

            // 檢查營養分析
            if (string.IsNullOrWhiteSpace(txt_Nutrients.Text))
            {
                MessageBox.Show("請輸入營養分析", "驗證錯誤", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Nutrients.Focus();
                return false;
            }

            // 檢查三張圖片是否都有選取
            if (pBox_Primary.Image == null)
            {
                MessageBox.Show("請上傳商品主圖", "驗證錯誤", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (pBox_Content1.Image == null)
            {
                MessageBox.Show("請上傳商品內圖1", "驗證錯誤", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (pBox_Content2.Image == null)
            {
                MessageBox.Show("請上傳商品內圖2", "驗證錯誤", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private decimal ParsePrice(string priceText)
        {
            // 從 "NT$ XXX" 格式解析價格
            string numericString = priceText.Replace("NT$", "").Trim();
            if (decimal.TryParse(numericString, out decimal result))
            {
                return result;
            }
            return 0;
        }

        private void ResetForm()
        {
            Color defaultColor = SystemColors.Control;
            
            // 重置所有背景顏色
            lbl_Modecolor.BackColor = defaultColor;
            label14.BackColor = defaultColor;
            label15.BackColor = defaultColor;
            label12.BackColor = defaultColor;
            label13.BackColor = defaultColor;
            lbl_IDShow.BackColor = defaultColor;
            panel4.BackColor = defaultColor;
            panel5.BackColor = defaultColor;
            panel6.BackColor = defaultColor;

            // 重置所有欄位和圖片
            isAddMode = false;
            SwitchToDisplayMode();
        }

        private void SwitchToDisplayMode()
        {
            // 設定淡黃色背景
            Color editModeColor = SystemColors.Control;
            lbl_Modecolor.BackColor = editModeColor;

            // 設定相關 Label 背景色
            label2.BackColor = editModeColor; // 
            label10.BackColor = editModeColor; // 
            lbl_Picture1.BackColor = editModeColor; // 
            lbl_Picture2.BackColor = editModeColor; // 
            label11.BackColor = editModeColor; // 
            lbl_IDShow.BackColor = editModeColor;
            lbl_ID.BackColor = editModeColor;
            label14.BackColor = editModeColor;
            label15.BackColor = editModeColor;
            label12.BackColor = editModeColor;
            label13.BackColor = editModeColor;


            // 設定 Panel 背景色
            panel4.BackColor = editModeColor; // 簡介面板
            panel5.BackColor = editModeColor; // 營養分析面板
            panel6.BackColor = editModeColor; // 成份面板

            
            // btn show
            ucIcon_Save.Visible = false;
            ucIcon_CancelEdit.Visible = false;

            // 切換回顯示模式的邏輯
            txt_ItemName.ReadOnly = true;
            txt_Brand.ReadOnly = true;
            txt_Price.ReadOnly = true;
            txt_Price.BackColor = SystemColors.Control;
            txt_Stock.BackColor = SystemColors.Control;
            txt_Stock.ReadOnly = true;
            txt_Intro.ReadOnly = true;
            txt_Ingredient.ReadOnly = true;
            txt_Nutrients.ReadOnly = true;

            // 移除圖片框點擊事件
            pBox_Primary.Click -= PictureBox_Click;
            pBox_Content1.Click -= PictureBox_Click;
            pBox_Content2.Click -= PictureBox_Click;

            // 恢復游標樣式
            pBox_Primary.Cursor = Cursors.Default;
            pBox_Content1.Cursor = Cursors.Default;
            pBox_Content2.Cursor = Cursors.Default;

            //// 移除確認按鈕
            //var confirmButton = this.Controls.OfType<Button>()
            //    .FirstOrDefault(b => b.Text == "確認新增");
            //if (confirmButton != null)
            //{
            //    this.Controls.Remove(confirmButton);
            //    confirmButton.Dispose();
            //}
        }

        // 在表單關閉時釋放資源
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            
            // 釋放所有 PictureBox 的圖片資源
            DisposePictureBoxImage(pBox_Primary);
            DisposePictureBoxImage(pBox_Content1);
            DisposePictureBoxImage(pBox_Content2);
        }

        private void DisposePictureBoxImage(PictureBox pictureBox)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
                pictureBox.Image = null;
            }
        }

        private void ucIcon_CancelEdit_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void SwitchToEditMode()
        {
            if (string.IsNullOrEmpty(lbl_ID.Text) || lbl_ID.Text == "(商品ID)") return;

            
            // 設定淡黃色背景
            Color editModeColor = Color.FromArgb(255, 255, 192);
            lbl_Modecolor.BackColor = editModeColor;
            
            // 設定相關 Label 背景色
            label2.BackColor = editModeColor; // 
            label10.BackColor = editModeColor; // 
            lbl_Picture1.BackColor = editModeColor; // 
            lbl_Picture2.BackColor = editModeColor; // 
            label11.BackColor = editModeColor; // 
            lbl_IDShow.BackColor = editModeColor;
            lbl_ID.BackColor = editModeColor;
            label14.BackColor = editModeColor;
            label15.BackColor = editModeColor;
            label12.BackColor = editModeColor;
            label13.BackColor = editModeColor;


            // 設定 Panel 背景色
            panel4.BackColor = editModeColor; // 簡介面板
            panel5.BackColor = editModeColor; // 營養分析面板
            panel6.BackColor = editModeColor; // 成份面板

            // 顯示儲存和取消按鈕
            ucIcon_Save.Visible = true;
            ucIcon_Save.Text = "確定修改";
            ucIcon_CancelEdit.Visible = true;

            // 啟用編輯
            txt_ItemName.ReadOnly = false;
            txt_Brand.ReadOnly = false;
            txt_Price.ReadOnly = false;
            txt_Price.BackColor = Color.White;
            txt_Stock.BackColor = Color.White;
            txt_Stock.ReadOnly = false;
            txt_Intro.ReadOnly = false;
            txt_Ingredient.ReadOnly = false;
            txt_Nutrients.ReadOnly = false;

            // 設定圖片框點擊事件
            pBox_Primary.Click += PictureBox_Click;
            pBox_Content1.Click += PictureBox_Click;
            pBox_Content2.Click += PictureBox_Click;

            // 改變游標樣式
            pBox_Primary.Cursor = Cursors.Hand;
            pBox_Content1.Cursor = Cursors.Hand;
            pBox_Content2.Cursor = Cursors.Hand;
        }

        private void DeleteProduct(int rowIndex)
        {
            try
            {
                int productId = Convert.ToInt32(dGV_ItemsRow.Rows[rowIndex].Cells["ID"].Value);
                string productName = dGV_ItemsRow.Rows[rowIndex].Cells["品名"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"確定要刪除商品「{productName}」嗎？\n此操作無法復原。", 
                    "確認刪除",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnection))
                    {
                        con.Open();
                        using (SqlTransaction transaction = con.BeginTransaction())
                        {
                            try
                            {
                                // 1. 刪除商品圖片
                                string deleteImagesSQL = "DELETE FROM ProductImages WHERE ProductID = @productId";
                                using (SqlCommand cmd = new SqlCommand(deleteImagesSQL, con, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@productId", productId);
                                    cmd.ExecuteNonQuery();
                                }

                                // 2. 刪除商品詳細資料
                                string deleteDetailsSQL = "DELETE FROM ProductDetails WHERE ProductID = @productId";
                                using (SqlCommand cmd = new SqlCommand(deleteDetailsSQL, con, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@productId", productId);
                                    cmd.ExecuteNonQuery();
                                }

                                // 3. 刪除商品基本資料
                                string deleteProductSQL = "DELETE FROM FoodProducts WHERE ProductID = @productId";
                                using (SqlCommand cmd = new SqlCommand(deleteProductSQL, con, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@productId", productId);
                                    cmd.ExecuteNonQuery();
                                }

                                transaction.Commit();
                                MessageBox.Show("商品已成功刪除！", "成功", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // 重新載入資料
                                ucIcon_ShowAll_Click(null, null);
                                ResetForm();
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                throw new Exception($"刪除商品時發生錯誤：{ex.Message}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"刪除商品時發生錯誤：{ex.Message}", "錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
