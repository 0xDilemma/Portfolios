using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SketchVerB
{
    public partial class UC_Cart : UserControl
    {
        //Method
        public void F_CartLoad()
        {
            int OrderTot = 0;

            foreach (ArrayList Items in GlobalVar.listOrderCollection)
            {
                string currentItemName = Items[0].ToString();

                // 尋找是否已存在相同商品
                UC_CartRowFrame existingFrame = null;
                foreach (Control control in fLP_OrderList.Controls)
                {
                    if (control is UC_CartRowFrame orderFrame && orderFrame.txt_ShowthisName.Text == currentItemName)
                    {
                        existingFrame = orderFrame;
                        break;
                    }
                }

                if (existingFrame != null)
                {
                    // 更新既有商品的數量和小計
                    int newQuant = existingFrame.ItemQuant + (int)Items[2];
                    existingFrame.ItemQuant = newQuant;
                    existingFrame.txt_Quant.Text = newQuant.ToString();

                    // 清理價格字串，只保留數字
                    string priceStr = existingFrame.ItemPrice
                        .Replace("$NT", "")  // 移除 $NT（不含空格）
                        .Replace("$", "")    // 以防萬一再移除 $ 符號
                        .Replace("NT", "")   // 以防萬一再移除 NT
                        .Trim();             // 移除前後空格
                    //MessageBox.Show($"{priceStr}");

                    // 計算新的小計
                    if (int.TryParse(priceStr, out int price))
                    {
                        int newTot = price * newQuant;
                        existingFrame.ItemTotPrice = newTot;
                        existingFrame.lbl_ShowthisTot.Text = $"$NT {newTot}";
                    }
                    else
                    {
                        MessageBox.Show("價格格式錯誤");
                        return;
                    }
                }
                else
                {
                    // 建立新的商品列
                    UC_CartRowFrame ItemsFrame = new UC_CartRowFrame();
                    ItemsFrame.txt_ShowthisName.Text = currentItemName; //品名
                    //ItemsFrame.ItemName = currentItemName;

                    ItemsFrame.lbl_ShowthisTot.Text = Items[1].ToString(); //單價
                    ItemsFrame.ItemPrice = Items[1].ToString();

                    ItemsFrame.txt_Quant.Text = Items[2].ToString(); //數量
                    ItemsFrame.ItemQuant = (int)Items[2];

                    ItemsFrame.lbl_ShowthisTot.Text = $"$NT {Items[3].ToString()}"; //單品小計
                    //ItemsFrame.ItemTotPrice = (int)Items[3];

                    //ItemsFrame.ItemImagePath = Items[4].ToString();
                    ItemsFrame.pbox_ShowthisImage.Image = Image.FromFile(Items[4].ToString());

                    //.Tag 給ID
                    ItemsFrame.Tag = (int)Items[5];

                    // 加入到 FlowLayoutPanel
                    fLP_OrderList.Controls.Add(ItemsFrame);
                }

                // 更新總金額
                OrderTot += (int)Items[3];
            }
            lbl_OrderTot.Text = $"$NT {OrderTot}";
        }

        public UC_Cart()
        {
            InitializeComponent();
        }

        private void ucIcon_TakeOrder_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            fLP_OrderList.Controls.Clear();
            Form_TakeOrder myOrderCart = new Form_TakeOrder();
            myOrderCart.ShowDialog();

            //if (GlobalVar.CurrentUser != null)
            //{
                
            //}
            //else
            //{
            //    MessageBox.Show("請先登入會員！！！");
            //}
        }

        private void ucIcon_RoundBtn1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void UC_Cart_Load(object sender, EventArgs e)
        {
           // F_CartLoad();
        }
    }
}
