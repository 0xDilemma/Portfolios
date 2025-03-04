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
using System.Collections;

namespace WFA_SketchVerB
{
    public partial class UC_GoodsDetail : UserControl
    {   // Var
        private int productId;
        private ProductInfo currentProduct;
        private int unitPrice;
        int quant = 1; // txt_Quant 用
        // 定義路徑
        private readonly string IMAGE_BASE_PATH;
        private readonly string ORIGINAL_IMAGE_PATH;

        // 建構 ------------------------
        public UC_GoodsDetail(int productId)
        {
            InitializeComponent();
            //this.productId = productId;
            //this.Load += UC_GoodsDetail_Load;
        }

        public UC_GoodsDetail()
        {
            InitializeComponent();
            // 設定基礎路徑（使用使用者文件資料夾）
            string documentsPath = GlobalVar.image_dir; // 直接套用 GV 路徑
            
            IMAGE_BASE_PATH = Path.Combine(documentsPath, "ItemPicture");
            ORIGINAL_IMAGE_PATH = Path.Combine(IMAGE_BASE_PATH, "Products");
            
        }
        // --------------------------

        //EVENT & Method
        private void UC_GoodsDetail_Load(object sender, EventArgs e)
        {
            pBox_Current.Image = pBox_Primary.Image;
        }

        public void LoadProductDetails(int productId)
        {
            this.productId = productId;

            LoadProductDetails();
        }

        private void LoadProductDetails()
        {
            // 從 GlobalVar.ProductList 中找到對應的商品 by LINQ
            currentProduct = GlobalVar.ProductList.FirstOrDefault(p => p.ProductID == productId);

            if (currentProduct != null)
            {
                // 設定商品詳細資訊
                txt_Intro.Text = currentProduct.Description ?? "";
                txt_Ingredient.Text = currentProduct.Ingredient ?? "";
                txt_Nutrients.Text = currentProduct.Nutrients ?? "";
                lbl_GoodName.Text = currentProduct.ProductName;
                unitPrice = currentProduct.UnitPrice;
                lbl_Price.Text = $"NT$ {currentProduct.UnitPrice}";
                lbl_Stock.Text = currentProduct.QuantityInStock.ToString();

                // 載入圖片
                int imageCount = 0;
                foreach (var image in currentProduct.Images)
                {
                    // 檢查 ImageFileName 是否為 null
                    if (string.IsNullOrEmpty(image.ImageFileName))
                    {
                        continue; // 跳過這個圖片
                        
                    }
                    
                    string imagePath = Path.Combine(ORIGINAL_IMAGE_PATH, image.ImageFileName);
                    string thumbnailPath = Path.Combine(IMAGE_BASE_PATH, "Thumbnails", "thumb_" + image.ImageFileName);
                    if (File.Exists(imagePath))
                    {
                        try
                        {
                            if (image.IsPrimary && imageCount == 0)
                            {
                                // 載入主要圖片
                                using (var stream = File.OpenRead(imagePath))
                                {
                                    pBox_Primary.Image = Image.FromStream(stream);
                                    pBox_Primary.Tag = thumbnailPath;
                                }
                                imageCount++;
                            }
                            else if (imageCount < 3)
                            {
                                // 載入其他圖片
                                using (var stream = File.OpenRead(imagePath))
                                {
                                    if (imageCount == 1)
                                    {
                                        pBox_2.Image = Image.FromStream(stream);
                                    }
                                    else if (imageCount == 2)
                                    {
                                        pBox_3.Image = Image.FromStream(stream);
                                    }
                                }
                                imageCount++;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"載入圖片時發生錯誤：{ex.Message}", "錯誤", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("找不到商品資訊", "錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pBox_Primary_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox clickedBox && clickedBox.Image != null)
            {
                pBox_Current.Image = clickedBox.Image;
                
                lbl_CurrentPic.Location = new Point(clickedBox.Location.X, lbl_CurrentPic.Location.Y);
            }
            
        }

        private void pnl_MouseEnter(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.LightGray;
        }

        private void pnl_MouseLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor =
                Color.FromArgb(255,224,192);
        }

        private void pbox_MouseEnter(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Name == pbox_minus.Name)
            { pnl_MouseEnter(pnl_minus, e); }

            else if (((PictureBox)sender).Name == pbox_plus.Name)
            { pnl_MouseEnter(pnl_plus, e); }
        }

        private void pnl_plus_Click(object sender, EventArgs e)
        {
            GlobalVar.Quant += 1;
            txt_Quant.Text = $"{GlobalVar.Quant}";

        }

        private void pnl_minus_Click(object sender, EventArgs e)
        {
            GlobalVar.Quant -= 1;
            txt_Quant.Text = $"{GlobalVar.Quant}";

        }

        private void txt_Quant_TextChanged(object sender, EventArgs e)
        {
            if (txt_Quant.Text != "")
            {
                bool isQuantRight = Int32.TryParse(txt_Quant.Text, out quant);

                if (isQuantRight && quant > 0 && quant < 999) // 0 ~ 99 且型別正確
                { //正確
                    GlobalVar.Quant = quant;
                }
                else
                { //錯誤
                    MessageBox.Show("請輸入正確數量");
                    quant = 1;
                    txt_Quant.Text = $"{quant}";
                }
            }
        }


        private void addtocart_Click(object sender, EventArgs e)
        {
            if (GlobalVar.Quant <= GlobalVar.ProductStock[productId]) // 確認庫存足夠
            {
                GlobalVar.TotPrice = GlobalVar.Quant * unitPrice;

                bool itemExists = false;

                // 檢查是否已存在相同商品
                foreach (ArrayList order in GlobalVar.listOrderCollection)
                {
                    if ((int)order[5] == productId) // 檢查商品 ID
                    {
                        // 更新數量和總價
                        order[2] = (int)order[2] + GlobalVar.Quant;
                        order[3] = (int)order[2] * unitPrice;
                        itemExists = true;
                        break;
                    }
                }

                if (!itemExists)
                {
                    ArrayList OrderInfo = new ArrayList();
                    OrderInfo.Add(lbl_GoodName.Text);
                    OrderInfo.Add(unitPrice);
                    OrderInfo.Add(GlobalVar.Quant);
                    OrderInfo.Add(GlobalVar.TotPrice);
                    OrderInfo.Add(pBox_Primary.Tag); // 存圖路徑
                    OrderInfo.Add(productId);        // 注意：修正了 productId 加入的位置
                    GlobalVar.listOrderCollection.Add(OrderInfo);
                }

                MessageBox.Show("所選品項已加入購物車");

                // GV 庫存修改
                GlobalVar.ProductStock[productId] -= GlobalVar.Quant;
            }
            else
            {
                MessageBox.Show("庫存不足 T^T ~，請等待補貨");
                quant = 1;
                txt_Quant.Text = $"{quant}";
            }

            Console.WriteLine(pBox_Primary.Tag);
        }

        private void txt_Quant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;  // 防止發出提示音

                // 例如觸發加入購物車的功能
                addtocart_Click(sender, e);
            }
        }

        private void UC_GoodsDetail_VisibleChanged(object sender, EventArgs e)
        {
            pBox_Current.Image = pBox_Primary.Image;
        }
    }
}
