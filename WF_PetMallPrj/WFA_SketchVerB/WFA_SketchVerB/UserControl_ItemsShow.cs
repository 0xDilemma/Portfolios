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
using static System.Console;

namespace WFA_SketchVerB
{
    public partial class UserControl_ItemsShow : UserControl
    {
        // VARIABLE================================
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();

        List<string> list_GoodName = new List<string>(); //商品名稱 val
        List<int> list_GoodPrice = new List<int>(); //val
        List<int> list_Id = new List<int>(); // PK
        List<string> list_GoodDesc = new List<string>(); // 商品描述

        // METHOD =================================
        void F_ReadDBPicture()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnection);
            con.Open();
            string strSQL = "SELECT  * FROM PetProducts;";
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
            
            WriteLine($"共有 {count} 筆資料");
            reader.Close();
            con.Close();
        }


        // EVENT==============================
        public UserControl_ItemsShow()
        {
            InitializeComponent();
        }

        private void UserControl_ItemsShow_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MyDB";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnection = scsb.ConnectionString.ToString();

            F_ReadDBPicture();

           
            for (int i = 0; i < list_Id.Count; i++)
            {
                UserControl_GoodsFrame goodsFrame = new UserControl_GoodsFrame();
                goodsFrame.lbl_GoodName.Text = list_GoodName[i];
                goodsFrame.lbl_GoodPrice.Text = list_GoodPrice[i].ToString();

                //goodsFrame.ProductImage = imageList_GoodPicture.Images[i];
                //goodsFrame.ProductId = list_Id[i];
                flowLayoutPanel_GoodList.Controls.Add(goodsFrame);
            }

        }
    }
}
