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
using System.Drawing.Drawing2D;
using System.Collections;

namespace WFA_SketchVerB
{
    public partial class UserControl_GoodsFrame : UserControl
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public Image ProductImage { get; set; }

        private int borderRadius = 10;  // 圓角半徑
        private float borderSize = 1f;  // 邊框粗細
        private Color borderColor = Color.LightGray;  // 邊框顏色

        int quant= 1; // txt_Quant 用

        public event EventHandler ReloadGoodsRequested; // 新增事件
        public event EventHandler Clicked;

        // METHOD==================================
        // 建議加入更新UI的方法
        public void UpdateDisplay()
        {
            // 將原本的 TextBox 設定修改如下
            lbl_GoodName.Enabled = false;
            lbl_GoodName.ReadOnly = true;
            lbl_GoodName.BorderStyle = BorderStyle.None;  // 移除邊框
            lbl_GoodName.BackColor = Color.White;  // 強制設定背景色為白色
            lbl_GoodName.ForeColor = Color.Black;
            lbl_GoodName.TabStop = false;  // 防止 Tab 鍵焦點

            lbl_GoodName.Text = ProductName;
            lbl_GoodPrice.Text = $"NT$ {ProductPrice:N0}";
            if (ProductImage != null)
            {
                pbox_GoodPrimary.Image = ProductImage;
                pbox_GoodPrimary.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // 設定高品質繪圖
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -1, -1);

            using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
            using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1))
            using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                // 控制項表面
                this.Region = new Region(pathSurface);
            
                // 繪製表面邊緣
                e.Graphics.DrawPath(penSurface, pathSurface);

                // 繪製邊框
                if (borderSize >= 1)
                    e.Graphics.DrawPath(penBorder, pathBorder);
            }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Invalidate();
        }
        
        // EVENT===================================
        public UserControl_GoodsFrame()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            // 啟用雙緩衝繪圖以減少閃爍
            this.DoubleBuffered = true;
            txt_Quant.Text = $"{GlobalVar.Quant}";
            UpdateDisplay();
        }

        private void UserControl_GoodsFrame_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void UserControl_GoodsFrame_MouseEnter(object sender, EventArgs e)
        {
             // 當滑鼠進入時，改變邊框粗細和顏色
            borderSize = 2f; // 增加邊框粗細
            borderColor = Color.DarkRed; // 改變邊框顏色
            this.Invalidate(); // 重新繪製控制項
        }

        private void UserControl_GoodsFrame_MouseLeave(object sender, EventArgs e)
        {
            // 當滑鼠離開時，恢復邊框粗細和顏色
            borderSize = 1f; // 恢復邊框粗細
            borderColor = Color.LightGray; // 恢復邊框顏色
            this.Invalidate(); // 重新繪製控制項
        }

        private void pbox_minicart_MouseEnter(object sender, EventArgs e)
        {
            borderSize = 2f; // 增加邊框粗細
            borderColor = Color.DarkRed; // 改變邊框顏色
            this.Invalidate();
            pnl_edge.BringToFront();
            lbl_GoodPrice.SendToBack();
            
        }



        private void pnl_edge_MouseLeave(object sender, EventArgs e)
        {
            borderSize = 2f; // 增加邊框粗細
            borderColor = Color.DarkRed; // 改變邊框顏色
            lbl_GoodPrice.BringToFront();
            pnl_edge.SendToBack();
            GlobalVar.Quant = 1;
            txt_Quant.Text = $"{GlobalVar.Quant}";
        }

        private void lbl_addtocart_MouseEnter(object sender, EventArgs e)
        {
            
            lbl_addtocart.BackColor = Color.DarkRed ;
            lbl_addtocart.ForeColor = Color.White ;

        }

        private void lbl_addtocart_MouseLeave(object sender, EventArgs e)
        {
            lbl_addtocart.BackColor = Color.White;
            lbl_addtocart.ForeColor = Color.DarkRed;
        }

        private void pnl_minus_MouseEnter(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.LightGray ;
        }

        private void pnl_minus_MouseLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor =
                            Color.FromArgb(255, 224, 192);
        }

        private void pbox_minus_MouseEnter(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Name == pbox_minus.Name)
            { pnl_minus_MouseEnter(pnl_minus, e); }

            else if (((PictureBox)sender).Name == pbox_plus.Name)
            { pnl_minus_MouseEnter(pnl_plus, e); }
        }

        private void pnl_plus_Click(object sender, EventArgs e)
        {
            GlobalVar.Quant += 1;
            txt_Quant.Text=$"{GlobalVar.Quant}";
            
        }

        private void pnl_minus_Click(object sender, EventArgs e)
        {
            GlobalVar.Quant -= 1;  
            txt_Quant.Text=$"{GlobalVar.Quant}";
            
        }

        private void txt_Quant_TextChanged(object sender, EventArgs e)
        {
            if (txt_Quant.Text != "")
            {
                bool isQuantRight = Int32.TryParse(txt_Quant.Text, out  quant);

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

        private void lbl_addtocart_Click(object sender, EventArgs e)
        {
            if (GlobalVar.Quant <= GlobalVar.ProductStock[ProductID]) // 確認庫存足夠
            {
                GlobalVar.TotPrice = GlobalVar.Quant * ProductPrice;

                bool itemExists = false;

                // 檢查是否已存在相同商品
                foreach (ArrayList order in GlobalVar.listOrderCollection)
                {
                    if ((int)order[5] == ProductID) // 檢查商品 ID
                    {
                        // 更新數量和總價
                        order[2] = (int)order[2] + GlobalVar.Quant;
                        order[3] = (int)order[2] * ProductPrice;
                        itemExists = true;
                        break;
                    }
                }

                if (!itemExists)
                {
                    ArrayList OrderInfo = new ArrayList();
                    OrderInfo.Add(lbl_GoodName.Text);
                    OrderInfo.Add(ProductPrice);
                    OrderInfo.Add(GlobalVar.Quant);
                    OrderInfo.Add(GlobalVar.TotPrice);
                    OrderInfo.Add(pbox_GoodPrimary.Tag); // 存圖路徑
                    OrderInfo.Add(ProductID);
                    GlobalVar.listOrderCollection.Add(OrderInfo);
                }

                MessageBox.Show("所選品項已加入購物車");

                // RESET 參數 & 重整
                pnl_edge_MouseLeave(sender, e);
                UserControl_GoodsFrame_MouseLeave(sender, e);

                // GV 庫存修改
                GlobalVar.ProductStock[ProductID] -= GlobalVar.Quant;

                GlobalVar.Quant = 1;
            }
            else
            {
                MessageBox.Show("庫存不足 T^T ~，請等待補貨");
                quant = 1; GlobalVar.Quant = 1;
                txt_Quant.Text = $"{quant}";
            }

            Console.WriteLine(pbox_GoodPrimary.Tag);
        }

        private void txt_Quant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;  // 防止發出提示音
                                            
                // 例如觸發加入購物車的功能
                lbl_addtocart_Click(sender, e);
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Console.WriteLine($"GoodsFrame clicked, ProductID: {ProductID}");
            Clicked?.Invoke(this, e);
        }

        

    }
}
