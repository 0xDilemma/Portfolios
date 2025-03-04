using System;
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
    public partial class UC_OrderRowFrame : UserControl
    {
        
        public string ItemName { get; set; }
        public string ItemPrice { get; set; }
        public int ItemQuant {  get; set; }
        public int ItemTotPrice {  get; set; }
        public string ItemImagePath { get; set; }

        //var
        int quant; // txt_Quant 用
        int oldQuant ; // txt_Quant 用
        int productId;

        public UC_OrderRowFrame()
        {
            InitializeComponent();
            oldQuant = this.ItemQuant;
        }

        private void pBox_Trash_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.Image = Properties.Resources.trash;
        }

        private void pBox_Trash_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.Image = Properties.Resources.gtrash;
        }

        private void pBox_Trash_Click(object sender, EventArgs e)
        {
            // 從 ProductList 中移除對應商品
            string productNameToRemove = this.txt_ShowthisName.Text; // 假設您有一個顯示商品名稱的Label

            // 從父容器（FlowLayoutPanel）中移除此 UserControl
            this.Parent.Controls.Remove(this);

            // 從全域訂單集合中移除
            var itemToRemove = GlobalVar.listOrderCollection.FirstOrDefault(x =>
                x[0].ToString() == productNameToRemove); // 假設商品名稱存在 ArrayList 的第二個位置
            if (itemToRemove != null)
            {
                GlobalVar.listOrderCollection.Remove(itemToRemove);
            }

            GlobalVar.MainForm.uC_CartCurrent.fLP_OrderList.Controls.Clear();
            GlobalVar.MainForm.uC_CartCurrent.F_CartLoad();
        }

        private void pnl_MouseEnter(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.LightGray;
        }

        private void pnl_MouseLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor =
                Color.Transparent;
        }

        private void pbox_MouseEnter(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Name == pbox_minus.Name)
            { pnl_MouseEnter(pnl_minus, e); }

            else if (((PictureBox)sender).Name == pbox_plus.Name)
            { pnl_MouseEnter(pnl_plus, e); }
        }

        private void pnl_minus_Click(object sender, EventArgs e)
        {
            this.ItemQuant -= 1;
            txt_ShowQuant.Text = $"{ItemQuant}";
            ucIcon_UpdateSave.Visible = true;
        }

        private void pnl_plus_Click(object sender, EventArgs e)
        {

            this.ItemQuant += 1;
            txt_ShowQuant.Text = $"{ItemQuant}";
            ucIcon_UpdateSave.Visible = true;
        }

        private void txt_ShowQuant_TextChanged(object sender, EventArgs e)
        {
            if (txt_ShowQuant.Text != "")
            {
                bool isQuantRight = Int32.TryParse(txt_ShowQuant.Text, out quant);

                if (isQuantRight && quant > 0 && quant < 999) // 0 ~ 99 且型別正確
                { //正確
                    
                    ucIcon_UpdateSave.Visible = true;
                }
                else
                { //錯誤
                    MessageBox.Show("請輸入正確數量");
                    quant = 1;
                    txt_ShowQuant.Text = $"{oldQuant}";
                }
            }
        }

        private void ucIcon_UpdateSave_Click(object sender, EventArgs e)
        {
            productId = (int)this.Tag;
            if (this.ItemQuant <= GlobalVar.ProductStock[productId]) // 確認庫存足夠
            {


                // 在訂單集合中找到對應商品
                var existingOrder = GlobalVar.listOrderCollection.FirstOrDefault(x =>
                    x[0].ToString() == txt_ShowthisName.Text);

                if (existingOrder != null)
                {
                    // 取得原本的數量以計算庫存調整
                    int oldQuantity = Convert.ToInt32(existingOrder[2]);

                    // 更新數量和總價
                    existingOrder[2] = this.ItemQuant;
                    int unitPrice = (int)existingOrder[1];
                    int newTotPrice = unitPrice * this.ItemQuant;
                    existingOrder[3] = newTotPrice;

                    // 調整庫存（先歸還原本數量，再扣除新數量）
                    GlobalVar.ProductStock[productId] += oldQuantity;
                    GlobalVar.ProductStock[productId] -= this.ItemQuant;
                    
                    MessageBox.Show("商品數量已更新");


                    // 重新載入購物車顯示
                    GlobalVar.MainForm.uC_CartCurrent.fLP_OrderList.Controls.Clear();
                    GlobalVar.MainForm.uC_CartCurrent.F_CartLoad();
                    GlobalVar.TakeOrderForm.fLP_OrderList.Controls.Clear();
                    GlobalVar.TakeOrderForm.F_OrderLoad();
                }
            }
            else
            {
                MessageBox.Show("庫存不足 T^T ~，請等待補貨");
                quant = 1;
                txt_ShowQuant.Text = $"{oldQuant}";
            }
            
            ucIcon_UpdateSave.Visible = false;
        }
    }
}
