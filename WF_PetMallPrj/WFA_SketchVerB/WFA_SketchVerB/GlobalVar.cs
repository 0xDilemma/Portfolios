using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_SketchVerB
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPhone { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserRole { get; set; }
        public string UserAddress { get; set; }
    }

    public class ProductInfo
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public int QuantityInStock { get; set; }
        public string Description { get; set; }
        public string Ingredient { get; set; }
        public string Nutrients { get; set; }
        public List<ProductImage> Images { get; set; } = new List<ProductImage>();
    }

    public class ProductImage
    {
        public string ImageFileName { get; set; }
        public bool IsPrimary { get; set; }
    }

    internal class GlobalVar
    {
        public static string image_dir = @"C:\Users\iSpan\Downloads\WF_DilemmaProject1115_athome"; // 教室用
        //public static string image_dir = @"D:\下載\WF_DilemmaProject1114"; // 家用

        public static string strDBConnection = "";
        public static List<ArrayList> listOrderCollection = new List<ArrayList>(); // 存訂單 Data
        public static Dictionary<int, int> ProductStock = new Dictionary<int, int>();  // Key: 商品ID, Value: 庫存數量
        public static bool IsAdmin = false;

        public static int Quant = 1;
        public static int TotPrice = 0;
        public static Form1 MainForm { get; set; } // 給登入觸發用
        public static Form_Login LoginForm { get; set; } // 給註冊觸發用
        public static Form_TakeOrder TakeOrderForm { get; set; }    
        public static User CurrentUser { get; set; }

        public static List<ProductInfo> ProductList = new List<ProductInfo>(); // 存儲所有商品資訊
    }
}
