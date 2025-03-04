using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WFA_SketchVerB
{
    public partial class UserControl_SideMenu : UserControl
    {
        //
        // Variable
        //
        
        private bool isSubMenuShown = false;

        private readonly int MAIN_MENU_Width = 118;
        private readonly int FULL_Width = 600;
        public UserControl_SideMenu()
        {
            InitializeComponent();
            InitializeMenuButtons();

            // 訂閱整個 UserControl 的 MouseMove 事件
            this.MouseMove += UserControl_MouseMove;
            panel_MainMenu.MouseMove += UserControl_MouseMove;
            panel_SubMenu.MouseMove += UserControl_MouseMove;
        }

        //
        // EVENT
        //
        private void MainMenuItem_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "貓貓食品")
            {
                F_ShowSubMenu();
                F_LoadSubMenuItems2();
            }

            if (btn.Text == "狗狗食品")
            {
                F_ShowSubMenu();
                F_LoadSubMenuItems();
            }
        }

        private void UserControl_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePos = this.PointToClient(Control.MousePosition);
            Rectangle totalBounds = new Rectangle();

            totalBounds = Rectangle.Union(totalBounds, panel_MainMenu.Bounds);
            totalBounds = Rectangle.Union(totalBounds, panel_SubMenu.Bounds);

            if (!totalBounds.Contains(mousePos))
            {
                F_HideSubMenu();
            }
        }

        // 另外建議在 panel_SubMenu 上也添加 MouseLeave 事件
        private void panel_SubMenu_MouseLeave(object sender, EventArgs e)
        {
            Point mousePos = this.PointToClient(Control.MousePosition);
            Rectangle totalBounds = new Rectangle();
            
            totalBounds = Rectangle.Union(totalBounds, panel_MainMenu.Bounds);
            totalBounds = Rectangle.Union(totalBounds, panel_SubMenu.Bounds);
            
            if (!totalBounds.Contains(mousePos))
            {
                F_HideSubMenu();
            }
        }

        //
        //Method
        //
        private void InitializeMenuButtons()
        {
            string[] mainMenuItems = new string[]
            {
                "狗狗食品",
                "貓貓食品",
              
            };

            // 設定 panel_MainMenu 的寬度
            panel_MainMenu.Width = MAIN_MENU_Width;

            int buttonHeight = 45;
            for (int i = 0; i < mainMenuItems.Length; i++)
            {
                Button btn = new Button
                {
                    Text = mainMenuItems[i],
                    Height = buttonHeight,
                    Width = MAIN_MENU_Width,  // 使用相同的寬度
                    FlatStyle = FlatStyle.Flat,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("微軟正黑體", 11),
                    Location = new Point(0, i * buttonHeight),
                    BackColor = Color.White,
                    Padding = new Padding(20, 0, 0, 0),
                    Dock = DockStyle.Top  // 改用 Dock 來對齊
                };

                btn.FlatAppearance.BorderSize = 0;
                btn.MouseEnter += MainMenuItem_MouseEnter;
                panel_MainMenu.Controls.Add(btn);
            }
        }
        public void F_HideSubMenu()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(F_HideSubMenu));
                return;
            }

            panel_SubMenu.Visible = false;
            panel_MainMenu.Width = MAIN_MENU_Width;
            this.Width = MAIN_MENU_Width;  // 設定整個控制項的寬度
            isSubMenuShown = false;
        }
        private void F_ShowSubMenu()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(F_ShowSubMenu));
                return;
            }

            if (!isSubMenuShown)
            {
                this.Width = FULL_Width;
                panel_SubMenu.Visible = true;
                isSubMenuShown = true;
            }
        }
        private void F_LoadSubMenuItems()
        {
            panel_SubMenu.Controls.Clear();

            using (SqlConnection conn = new SqlConnection(GlobalVar.strDBConnection))
            {
                conn.Open();
                // 查詢狗狗食品的品牌
                string sql = "SELECT DISTINCT Brand FROM FoodProducts WHERE Category LIKE N'%狗%' AND IsActive = 1";
                SqlCommand cmd = new SqlCommand(sql, conn);

                // 設定按鈕的基本屬性
                int buttonWidth = 160;
                int buttonHeight = 40;
                int padding = 10;
                int currentY = padding;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string brand = reader["Brand"].ToString();
                        
                        UCIcon_RoundBtn brandButton = new UCIcon_RoundBtn
                        {
                            Text = brand,
                            Size = new Size(buttonWidth, buttonHeight),
                            Location = new Point(padding, currentY),
                            NormalColor = Color.White,
                            HoverColor = Color.FromArgb(240, 240, 240),
                            BorderColor = Color.FromArgb(224, 224, 224),
                            ForeColor = Color.Black,
                            BorderRadius = 10,
                            BorderSize = 1
                        };

                        // 添加點擊事件
                        brandButton.Click += (sender, e) => 
                        {
                            string selectedBrand = (sender as UCIcon_RoundBtn).Text;
                            
                            // 清除並重新載入商品列表
                            GlobalVar.MainForm.uC_HomePage1.fLP_GoodsMainShow.Controls.Clear();
                            
                            using (SqlConnection conn2 = new SqlConnection(GlobalVar.strDBConnection))
                            {
                                conn2.Open();
                                string sql2 = @"
                                    SELECT f.*, pi.ImageFileName 
                                    FROM FoodProducts f 
                                    LEFT JOIN ProductImages pi ON f.ProductID = pi.ProductID 
                                    WHERE f.IsActive = 1 
                                    AND f.Brand = @Brand 
                                    AND f.Category LIKE N'%狗%'
                                    AND (pi.isPrimary = 1 OR pi.isPrimary IS NULL)";

                                SqlCommand cmd2 = new SqlCommand(sql2, conn2);
                                cmd2.Parameters.AddWithValue("@Brand", selectedBrand);

                                // 使用 HomePage 的方法來建立商品框
                                GlobalVar.MainForm.uC_HomePage1.LoadFilteredProducts(cmd2);
                            }
                        };

                        panel_SubMenu.Controls.Add(brandButton);
                        currentY += buttonHeight + padding;
                    }
                }
            }
        }
        private void F_LoadSubMenuItems2()
        {
            panel_SubMenu.Controls.Clear();

            using (SqlConnection conn = new SqlConnection(GlobalVar.strDBConnection))
            {
                conn.Open();
                // 查詢貓貓食品的品牌
                string sql = "SELECT DISTINCT Brand FROM FoodProducts WHERE Category LIKE N'%貓%' AND IsActive = 1";
                SqlCommand cmd = new SqlCommand(sql, conn);

                // 設定按鈕的基本屬性
                int buttonWidth = 160;
                int buttonHeight = 40;
                int padding = 10;
                int currentY = padding;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string brand = reader["Brand"].ToString();
                        
                        UCIcon_RoundBtn brandButton = new UCIcon_RoundBtn
                        {
                            Text = brand,
                            Size = new Size(buttonWidth, buttonHeight),
                            Location = new Point(padding, currentY),
                            NormalColor = Color.White,
                            HoverColor = Color.FromArgb(240, 240, 240),
                            BorderColor = Color.FromArgb(224, 224, 224),
                            ForeColor = Color.Black,
                            BorderRadius = 10,
                            BorderSize = 1
                        };

                        // 添加點擊事件
                        brandButton.Click += (sender, e) => 
                        {
                            string selectedBrand = (sender as UCIcon_RoundBtn).Text;
                            
                            // 清除並重新載入商品列表
                            GlobalVar.MainForm.uC_HomePage1.fLP_GoodsMainShow.Controls.Clear();
                            
                            using (SqlConnection conn2 = new SqlConnection(GlobalVar.strDBConnection))
                            {
                                conn2.Open();
                                string sql2 = @"
                                    SELECT f.*, pi.ImageFileName 
                                    FROM FoodProducts f 
                                    LEFT JOIN ProductImages pi ON f.ProductID = pi.ProductID 
                                    WHERE f.IsActive = 1 
                                    AND f.Brand = @Brand 
                                    AND f.Category LIKE N'%貓%'
                                    AND (pi.isPrimary = 1 OR pi.isPrimary IS NULL)";

                                SqlCommand cmd2 = new SqlCommand(sql2, conn2);
                                cmd2.Parameters.AddWithValue("@Brand", selectedBrand);

                                // 使用 HomePage 的方法來建立商品框
                                GlobalVar.MainForm.uC_HomePage1.LoadFilteredProducts(cmd2);
                            }
                        };

                        panel_SubMenu.Controls.Add(brandButton);
                        currentY += buttonHeight + padding;
                    }
                }
            }
        }

        
    }
}
