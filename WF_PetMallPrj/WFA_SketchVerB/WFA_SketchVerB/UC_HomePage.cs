using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // ADO.NET
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace WFA_SketchVerB
{
    public partial class UC_HomePage : UserControl
    {
        // Variable
        private const int THUMB_WIDTH = 200;
        private const int THUMB_HEIGHT = 200;

        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        
        string strSQL = "";

        string[] GoodsNames = new string[] { };

        // 定義路徑
        private readonly string IMAGE_BASE_PATH;
        private readonly string ORIGINAL_IMAGE_PATH;
        private readonly string THUMBNAIL_PATH;

        // ===========================================
        private int itemWidth = 170;
        private int itemHeight = 235;
        private int itemPadding = 5;

        // 提供修改尺寸的方法
        public void SetItemSize(int width, int height, int padding)
        {
            itemWidth = width;
            itemHeight = height;
            itemPadding = padding;
        }
        // ========================================

        // Method
        public UC_HomePage()
        {
            InitializeComponent();
            //資料庫連接
            F_DBconset();

            // 設定基礎路徑（使用使用者文件資料夾）
            string documentsPath = GlobalVar.image_dir; // 直接套用 GV 路徑
           
            IMAGE_BASE_PATH = Path.Combine(documentsPath,  "ItemPicture");
            ORIGINAL_IMAGE_PATH = Path.Combine(IMAGE_BASE_PATH, "Products");
            THUMBNAIL_PATH = Path.Combine(IMAGE_BASE_PATH, "Thumbnails");

            // 確保資料夾存在
            EnsureDirectoriesExist();

            // 載入產品圖片並生成縮圖
            LoadProductImages();
        }

        void F_DBconset()
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MyDB";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnection = scsb.ConnectionString.ToString();
            
        }

        private void EnsureDirectoriesExist()
         {
            try
            {
                Directory.CreateDirectory(IMAGE_BASE_PATH);
                Directory.CreateDirectory(ORIGINAL_IMAGE_PATH);
                Directory.CreateDirectory(THUMBNAIL_PATH);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"建立資料夾失敗：{ex.Message}", "錯誤",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadProductImages() //  寫了當縮圖不存在才建立
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalVar.strDBConnection))
                {
                    // 只選擇 isPrimary 為 true 的圖片
                    strSQL = "SELECT ImageFileName FROM ProductImages WHERE isPrimary = 1";
                    SqlCommand cmd = new SqlCommand(strSQL, conn);
                    
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
            
                    while (reader.Read())
                    {
                        string fileName = reader["ImageFileName"].ToString();
                        string originalFile = Path.Combine(ORIGINAL_IMAGE_PATH, fileName);
                        string thumbnailFile = Path.Combine(THUMBNAIL_PATH, "thumb_" + fileName);

                        // 確認原始圖片存在且縮圖不存在時才建立縮圖
                        if (File.Exists(originalFile) && !File.Exists(thumbnailFile))
                        {
                            Cl_IamgeHelper.CreateAndSaveThumbnail(
                            originalFile,
                            thumbnailFile,
                            THUMB_WIDTH,
                            THUMB_HEIGHT
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入圖片失敗：{ex.Message}", "錯誤",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void F_LoadGoodsTable()
        {
            // 1. 先取得熱銷商品排序
            Dictionary<int, int> hotProducts = GetHotProducts();  // ProductID, 銷量

            using (SqlConnection conn = new SqlConnection(GlobalVar.strDBConnection))
            {
                conn.Open();
                // 修改 SQL 查詢，使用子查詢來確保至少有一張主要圖片
                string sql = @"
                    SELECT DISTINCT 
                        f.ProductID, 
                        f.ProductName, 
                        f.UnitPrice, 
                        f.QuantityInStock, 
                        pd.Description, 
                        pd.Ingredient, 
                        pd.Nutrients,
                        pi.ImageFileName,
                        pi.isPrimary
                    FROM FoodProducts f 
                    LEFT JOIN ProductDetails pd ON f.ProductID = pd.ProductID 
                    LEFT JOIN ProductImages pi ON f.ProductID = pi.ProductID 
                    WHERE f.IsActive = 1 
                    AND EXISTS (
                        SELECT 1 
                        FROM ProductImages pi2 
                        WHERE pi2.ProductID = f.ProductID 
                        AND pi2.isPrimary = 1
                    )";

                SqlCommand cmd = new SqlCommand(sql, conn);
                DataTable dt = new DataTable();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }

                // 清空 ProductList
                GlobalVar.ProductList.Clear();

                // 使用字典暫存產品資訊，避免重複建立
                Dictionary<int, ProductInfo> productDict = new Dictionary<int, ProductInfo>();

                // 處理每一行資料
                foreach (DataRow row in dt.Rows)
                {
                    int productId = Convert.ToInt32(row["ProductID"]);

                    // 如果產品還未加入字典，建立新的產品資訊
                    if (!productDict.ContainsKey(productId))
                    {
                        ProductInfo product = new ProductInfo
                        {
                            ProductID = productId,
                            ProductName = row["ProductName"].ToString(),
                            UnitPrice = Convert.ToInt32(row["UnitPrice"]),
                            QuantityInStock = Convert.ToInt32(row["QuantityInStock"]),
                            Description = row["Description"]?.ToString(),
                            Ingredient = row["Ingredient"]?.ToString(),
                            Nutrients = row["Nutrients"]?.ToString(),
                            Images = new List<ProductImage>()
                        };
                        productDict.Add(productId, product);
                    }

                    // 加入圖片資訊（如果有）
                    if (row["ImageFileName"] != DBNull.Value)
                    {
                        productDict[productId].Images.Add(new ProductImage
                        {
                            ImageFileName = row["ImageFileName"].ToString(),
                            IsPrimary = Convert.ToBoolean(row["isPrimary"])
                        });
                    }
                }

                // 將字典中的產品資訊加入到 ProductList
                GlobalVar.ProductList.AddRange(productDict.Values);

                // 3. 先建立熱銷商品的 GoodsFrame
                foreach (var hotProduct in hotProducts)
                {
                    DataRow[] rows = dt.Select($"ProductID = {hotProduct.Key}");
                    if (rows.Length > 0)
                    {
                        F_CreateGoodsFrame(rows[0]);
                    }
                }

                // 4. 建立其餘商品的 GoodsFrame
                var processedIds = new HashSet<int>(hotProducts.Keys);
                foreach (DataRow row in dt.Rows)
                {
                    int productId = Convert.ToInt32(row["ProductID"]);
                    if (!processedIds.Contains(productId))
                    {
                        F_CreateGoodsFrame(row);
                        processedIds.Add(productId);
                    }
                }
            }
        }

        // 取得熱銷商品排序
        private Dictionary<int, int> GetHotProducts()
        {
            Dictionary<int, int> hotProducts = new Dictionary<int, int>();

            using (SqlConnection conn = new SqlConnection(GlobalVar.strDBConnection))
            {
                conn.Open();
                string sql = @"
            SELECT TOP 5 ProductID, SUM(Quantity) as TotalSold 
            FROM OrderDetails 
            GROUP BY ProductID 
            ORDER BY TotalSold DESC";

                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        hotProducts.Add(
                            Convert.ToInt32(reader["ProductID"]),
                            Convert.ToInt32(reader["TotalSold"])
                        );
                    }
                }
            }
            return hotProducts;
        }

        // 建立 GoodsFrame 的方法
        private void F_CreateGoodsFrame(DataRow row)
        {
            UserControl_GoodsFrame goodsFrame = new UserControl_GoodsFrame();
            goodsFrame.Size = new Size(itemWidth, itemHeight);
            goodsFrame.Margin = new Padding(itemPadding);

            // 設定商品資訊
            int productId = Convert.ToInt32(row["ProductID"]);
            goodsFrame.ProductID = productId;
            goodsFrame.ProductName = row["ProductName"].ToString();
            goodsFrame.ProductPrice = Convert.ToInt32(row["UnitPrice"]);

            // 更新庫存字典
            try
            {
                GlobalVar.ProductStock.Add(goodsFrame.ProductID, (int)row["QuantityInStock"]);
            }
            catch (ArgumentException)
            {
                GlobalVar.ProductStock[goodsFrame.ProductID] = (int)row["QuantityInStock"];
            }

            // 從 ProductList 中找到對應的商品
            var product = GlobalVar.ProductList.FirstOrDefault(p => p.ProductID == productId);
            
            if (product != null)
            {
                // 尋找主要圖片
                var primaryImage = product.Images.FirstOrDefault(img => img.IsPrimary);
                if (primaryImage != null)
                {
                    string thumbnailPath = Path.Combine(THUMBNAIL_PATH, "thumb_" + primaryImage.ImageFileName);
                    if (File.Exists(thumbnailPath))
                    {
                        using (var stream = new FileStream(thumbnailPath, FileMode.Open, FileAccess.Read))
                        {
                            goodsFrame.ProductImage = Image.FromStream(stream);
                            goodsFrame.pbox_GoodPrimary.Image = goodsFrame.ProductImage;
                            goodsFrame.pbox_GoodPrimary.Tag = thumbnailPath;
                        }
                    }
                }
            }

            // 設定顯示資訊
            goodsFrame.lbl_GoodName.Text = goodsFrame.ProductName;
            goodsFrame.lbl_GoodPrice.Text = $"NT$ {goodsFrame.ProductPrice}";

            // 訂閱點擊事件
            goodsFrame.Clicked += (sender, e) =>
            {
                var clickedFrame = sender as UserControl_GoodsFrame;
                if (clickedFrame != null)
                {
                    // 通知主表單處理點擊事件
                    ((Form1)ParentForm).GoodsFrame_Clicked(clickedFrame, e);
                }
            };

            // 訂閱重新載入事件
            goodsFrame.ReloadGoodsRequested += (s, e) => F_LoadGoodsTable();

            // 加入到 FlowLayoutPanel
            fLP_GoodsMainShow.Controls.Add(goodsFrame);
        }

        // 假設這是一個顯示 UC_GoodsDetail 的方法
        private void F_ShowGoodsDetail(UC_GoodsDetail goodsDetail)
        {
            // 這裡可以是顯示的邏輯，例如將其加入到某個容器中
            // 例如：this.Controls.Add(goodsDetail);
        }

        // EVENT
        public void F_ReloadHomePage()
        {
            // 清除所有現有的商品項目
            fLP_GoodsMainShow.Controls.Clear();

            // 重新載入
            fLP_GoodsMainShow.BorderStyle = BorderStyle.None;
            LoadProductImages(); // 先確保所有縮圖都已建立
            F_LoadGoodsTable(); // 載入商品
        }

        private void UC_HomePage_Load(object sender, EventArgs e)
        {
            F_ReloadHomePage();
            
        }

        public void LoadFilteredProducts(SqlCommand cmd)
        {
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(reader);

                foreach (DataRow row in dt.Rows)
                {
                    F_CreateGoodsFrame(row);
                }
            }
        }
    }
}
