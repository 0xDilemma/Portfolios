using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace WFA_SketchVer
{
    public partial class UserControl1 : UserControl
    {
        // Variable ================================
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();

        //-- 商品集合 陳列用 ----------------------    
        List<string> list_GoodName = new List<string>(); //商品名稱 val
        List<int> list_GoodPrice = new List<int>(); //val
        List<int> list_Id = new List<int>(); // PK
        List<string> list_GoodDesc = new List<string>(); // 商品描述
        //-----------------------------------------

        //-- 商品各DATA ---------------------------
        List<string> list_GoodsMenu = new List<string>();
        string GoodName = "";
        int GoodPrice = 0;
        int GoodCount = 1;
        int PriceTot = 0;

        //-----------------------------------------

        //=========================================

        // Method ==================================
        //-- 價格計算
        void F_CalGoodTot()
        {
            if (listView_Goodshow.SelectedIndices.Count > 0)
            {
                ListViewItem selectedItem = listView_Goodshow.Items[listView_Goodshow.SelectedIndices[0]];
                // 從 Tag 屬性獲取存儲的 idx
                int selectedIdx = (int)selectedItem.Tag-1;

                GoodPrice = list_GoodPrice[selectedIdx];

                PriceTot = GoodPrice * GoodCount;
                lbl_GoodTotPrice.Text = $"小計： {PriceTot} 元";

            }
        }

        //-- 商品顯示相關 -------------------------
        void F_ReadtheGoodDB() // 建立讀取圖片的 Channel，讀完後關閉 Channel
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "SELECT TOP 200 * FROM PetProducts;";
            SqlCommand sqlcmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = sqlcmd.ExecuteReader();

            int count = 0;
            while (reader.Read())
            {
                list_Id.Add((Int16)reader["Id"]);
                list_GoodName.Add((string)reader["PName"]);
                list_GoodPrice.Add((int)reader["PPrice"]);
                list_GoodDesc.Add((string)reader["PDesc"]);
                string image_Name = (string)reader["PImage"];
                string FullImagePath = GlobalVar.image_dir + @"\" + image_Name;

                

                Console.WriteLine(FullImagePath);
                System.IO.FileStream fs = System.IO.File.OpenRead(FullImagePath); //System.IO 可以寫在開頭 using 套用
                Image imgGood = Image.FromStream(fs); // 將 FileStream 加入至 Image 物件
                imageList_GoodPicture.Images.Add(imgGood);

                fs.Close(); // 加入完成後，記得 Close 釋放空間。
                count++;
            }

            Console.WriteLine($"共有 {count} 筆資料");
            reader.Close();
            con.Close();
        }
        void F_ShowListView_PictureMode()
        {
            listView_Goodshow.Clear();
            listView_Goodshow.View = View.LargeIcon;
            imageList_GoodPicture.ImageSize = new Size(75, 75);
            listView_Goodshow.LargeImageList = imageList_GoodPicture;
            listView_Goodshow.SmallImageList = imageList_GoodPicture;

            for (int idx = 0; idx < list_Id.Count; idx++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = idx;
                item.Text = $"{list_GoodName[idx]} {list_GoodPrice[idx]} 元";
                item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                item.Tag = list_Id[idx]; // 存放ID用
                listView_Goodshow.Items.Add(item);
            }
        }

        void F_ShowListView_TableMode() // 顯示列表模式
        {
            // -- 清空要三個避免奇怪的圖跑出來 --
            listView_Goodshow.Clear();
            listView_Goodshow.LargeImageList = null;
            listView_Goodshow.SmallImageList = null;
            // ---------------
            listView_Goodshow.View = View.Details;
            listView_Goodshow.Columns.Add("Id", 40); //(欄位名稱, 欄位寬度)
            listView_Goodshow.Columns.Add("GoodName", 100);
            listView_Goodshow.Columns.Add("GoodPrice", 100);
            listView_Goodshow.Columns.Add("Describe", 150);

            listView_Goodshow.GridLines = true; //建立格線

            for (int idx = 0; idx < list_Id.Count; idx++)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 10, FontStyle.Bold);
                item.Tag = (int)list_Id[idx];
                item.Text = list_Id[idx].ToString();
                item.SubItems.Add(list_GoodName[idx]);
                item.SubItems.Add(list_GoodPrice[idx].ToString());
                item.SubItems.Add(list_GoodDesc[idx]);
                item.ForeColor = Color.DarkBlue;
                listView_Goodshow.Items.Add(item);

            }

        }

        void F_Refresh() // 當多人同時存取時，就需要重整
        {
            list_Id.Clear(); list_GoodName.Clear(); list_GoodPrice.Clear();
            imageList_GoodPicture.Images.Clear();
            F_ReadtheGoodDB();
            F_ShowListView_TableMode();

            //if (listView_Goodshow.View == View.Details)
            //{
            //    Fun_ShowListView_TableMode();
            //}
            //else
            //{
            //    Fun_ShowListView_PictureMode();
            //}
        }
        //--------------------------------------

        // Event ===========================================
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MyDB";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();
            F_ReadtheGoodDB();  //讀圖用
            //F_ShowListView_TableMode(); //列表模式
            F_ShowListView_PictureMode();

            // 預設價格
           
            F_CalGoodTot();

        }

        private void btn_AddtoCart_Click(object sender, EventArgs e)
        {
            
            if (listView_Goodshow.SelectedIndices.Count > 0)
            {
                ArrayList OrderInfo = new ArrayList();
                OrderInfo.Add(list_GoodName);
                OrderInfo.Add(list_GoodPrice);
                OrderInfo.Add(GoodCount);
                OrderInfo.Add(PriceTot);
                GlobalVar.listOrderCollection.Add(OrderInfo);
                MessageBox.Show("所選品項以加入購物車");
            }
            else
            {
                MessageBox.Show("請先選擇品項");
            }
        }

        private void listView_Goodshow_SelectedIndexChanged(object sender, EventArgs e)
        {
            //WriteLine($"Val {listView_Goodshow.SelectedIndices.Count}");

            if (listView_Goodshow.SelectedIndices.Count > 0)
            // 確保有選中項目，取消選擇時 此事件也會觸發 若沒有 if 便會報錯
            {
                ListViewItem selectedItem = listView_Goodshow.Items[listView_Goodshow.SelectedIndices[0]];

                // 從 Tag 屬性獲取存儲的 idx
                int selectedIdx = (int)selectedItem.Tag - 1; // 因為 DB 中 ID 起始為 1
                //WriteLine($"對應索引 {selectedIdx}");

                // 添加安全檢查
                //if (selectedIdx >= 0 && selectedIdx < list_GoodName.Count)
                //{
                //    WriteLine($"對應索引 {selectedIdx}");
                //    lbl_ResponShow.Text = list_GoodName[selectedIdx];
                //}
                //else
                //{
                //    WriteLine($"索引超出範圍: {selectedIdx}");
                //    // 可以在這裡添加錯誤處理
                //}


                lbl_ResponShow.Text = list_GoodName[selectedIdx];
                F_CalGoodTot();
                
            }
        }

        private void txt_ActualGoodCount_TextChanged(object sender, EventArgs e)
        {
            if (txt_ActualGoodCount.Text != "")
            {
                bool isCupsRight = Int32.TryParse(txt_ActualGoodCount.Text, out GoodCount);

                if (isCupsRight && GoodCount > 0 && GoodCount < 99) // 杯數>0 <99 且型別正確
                { // 杯數輸入正確

                }
                else
                { // 杯數輸入錯誤
                    MessageBox.Show("請輸入正確杯數");
                    GoodCount = 1;
                    txt_ActualGoodCount.Text = $"{GoodCount}";
                }
            }
        }

        private void btn_PlusOne_Click(object sender, EventArgs e)
        {
            GoodCount += 1;
            txt_ActualGoodCount.Text = $"{GoodCount}";
            F_CalGoodTot();
        }

        private void btn_MinusOne_Click(object sender, EventArgs e)
        {
            GoodCount -= 1;
            txt_ActualGoodCount.Text = $"{GoodCount}";
            F_CalGoodTot();
        }



    }
}
