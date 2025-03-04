using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WFA_SketchVerB
{
    public partial class Form1 : Form
    {
        // Variable
        //--- 拖曳用----
        private bool beginMove = false;
        private int currentXPos; private int currentYPos;
        WFA_SketchVerB.UserControl_ItemsShow U1 = new  WFA_SketchVerB.UserControl_ItemsShow();

        //-------------
        // Method
       

        // 提供給登入表單調用的方法
        public void ShowAdminMenu()
        {
            UC_ManageMenu.Visible = true;
        }

        // 建構 ================================
        public Form1()
        {
            InitializeComponent();
            UC_ManageMenu.Visible = false;  // 預設隱藏
            GlobalVar.MainForm = this; 
        }

        // Events ==============================
        private void Form1_Load(object sender, EventArgs e)
        {
            userControl_SideMenu1.Width = 118;
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
            if(beginMove)
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

        // Call FormCart

        private void lbl_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_Close_MouseEnter(object sender, EventArgs e)
        {
            lbl_Close.BackColor = Color.Red;
            lbl_Close.ForeColor = Color.Black;
        }

        private void lbl_Close_MouseLeave(object sender, EventArgs e)
        {
            lbl_Close.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            lbl_Close.ForeColor = Color.White;
        }

        private void UC_ManageMenu_Load(object sender, EventArgs e)
        {

        }

        private void ucIcon_RoundBtn1_MouseEnter(object sender, EventArgs e)
        {
            userControl_SideMenu1.Visible = true;
            userControl_SideMenu1.BringToFront();
            
            // 觸發側邊欄的第一個按鈕（假設是"狗狗食品"）的MouseEnter事件
            if (userControl_SideMenu1.panel_MainMenu.Controls.Count > 0)
            {
                Button firstButton = userControl_SideMenu1.panel_MainMenu.Controls[0] as Button;
                if (firstButton != null)
                {
                    // 模擬滑鼠進入事件
                    firstButton.PerformClick();
                }
            }
        }

        private void ucIcon_RoundBtn1_MouseLeave(object sender, EventArgs e)
        {
            Point mousePos = userControl_SideMenu1.PointToClient(Control.MousePosition);
            if (!userControl_SideMenu1.panel_MainMenu.Bounds.Contains(mousePos) &&
                !userControl_SideMenu1.panel_SubMenu.Bounds.Contains(mousePos))
            {
                userControl_SideMenu1.Visible = false;
                //userControl_SideMenu1.HideSubMenu();
            }
        }

        private void userControl_SideMenu1_MouseLeave(object sender, EventArgs e)
        {
            userControl_SideMenu1.Visible = false ;
        }

        // 在建構函式中訂閱事件
        public void SubscribeToGoodsFrameEvents(UserControl_GoodsFrame goodsFrame)
        {
            goodsFrame.Clicked += GoodsFrame_Clicked;
        }

        public void GoodsFrame_Clicked(object sender, EventArgs e)
        {
            var goodsFrame = sender as UserControl_GoodsFrame;
            if (goodsFrame != null)
            {
                // 隱藏首頁
                uC_HomePage1.Visible = false;
                ucIcon_Goback.Visible = true;
                

                // 設定商品詳細資訊並顯示
                uC_GoodsDetailCurrent.LoadProductDetails(goodsFrame.ProductID);
                uC_GoodsDetailCurrent.Visible = true;
                uC_GoodsDetailCurrent.BringToFront();

                ucIcon_RoundBtn1.BringToFront();
                UC_ManageMenu.BringToFront();
                ucIcon_Goback.BringToFront();
            }
        }

        // 在創建 GoodsFrame 控制項時訂閱事件
        private void CreateGoodsFrame()
        {
            UserControl_GoodsFrame goodsFrame = new UserControl_GoodsFrame();
            // ... 其他設定 ...
            goodsFrame.Clicked += GoodsFrame_Clicked; // 訂閱事件
        }

        private void ucIcon_Goback_Click(object sender, EventArgs e)
        {
            ucIcon_Goback.Visible=false;
            uC_GoodsDetailCurrent.Visible=false;
            uC_HomePage1.Visible=true;
        }
    }
}
