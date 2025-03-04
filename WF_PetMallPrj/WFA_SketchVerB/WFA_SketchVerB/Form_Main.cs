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
    public partial class Form_Main : Form
    {
        private bool isSubMenuShown = false;

        public Form_Main()
        {
            InitializeComponent();
            InitializeMenuButtons();
        }

        private void InitializeMenuButtons()
        {
            // 建立主選單按鈕
            string[] mainMenuItems = new string[]
            {
            "雙11寵物展", "品牌旗艦館", "主題活動",
            "品牌飼料", "貓狗罐罐", "寵物保健"
            };

            int buttonHeight = 50;
            for (int i = 0; i < mainMenuItems.Length; i++)
            {
                Button btn = new Button
                {
                    Text = mainMenuItems[i],
                    Height = buttonHeight,
                    Width = panel_MainMenu.Width,
                    FlatStyle = FlatStyle.Flat,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("微軟正黑體", 12),
                    Location = new Point(0, i * buttonHeight),
                    BackColor = Color.White,
                    Padding = new Padding(20, 0, 0, 0)
                };

                btn.FlatAppearance.BorderSize = 0;
                btn.MouseEnter += MainMenuItem_MouseEnter;
                btn.MouseLeave += MainMenuItem_MouseLeave;
                panel_MainMenu.Controls.Add(btn);
            }
        }

        private void MainMenuItem_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "雙11寵物展")
            {
                F_ShowSubMenu();
                F_LoadSubMenuItems2();
            }

            if (btn.Text == "主題活動")
            {
                F_ShowSubMenu();
                F_LoadSubMenuItems();
            }
        }

        private void MainMenuItem_MouseLeave(object sender, EventArgs e)
        {
            Point mousePos = this.PointToClient(Control.MousePosition);
            if (!panel_MainMenu.Bounds.Contains(mousePos) &&
                !panel_SubMenu.Bounds.Contains(mousePos))
            {
                HideSubMenu();
            }
        }

        private void F_ShowSubMenu()
        {
            if (!isSubMenuShown)
            {
                panel_SubMenu.Visible = true;
                isSubMenuShown = true;
            }
        }

        private void HideSubMenu()
        {
            panel_SubMenu.Visible = false;
            isSubMenuShown = false;
        }

        private void F_LoadSubMenuItems() 
        {
            panel_SubMenu.Controls.Clear();

            // 建立活動項目的 UserControl
            int itemWidth = 180;
            int itemHeight = 220;
            int padding = 10;

            string[] activities = new string[]
            {
            "冬窩5折", "毛孩乾杯請吃", "貪食滿額送好禮",
            "健綠滿額贈", "加1元多1件", "保健最低8折起"
            };

            for (int i = 0; i < activities.Length; i++)
            {
                UserControl_GoodsFrame activityFrame = new UserControl_GoodsFrame();
                activityFrame.Size = new Size(itemWidth, itemHeight);
                activityFrame.Location = new Point(
                    padding + (i % 4) * (itemWidth + padding),
                    padding + (i / 4) * (itemHeight + padding)
                );
                activityFrame.lbl_GoodName.Text = activities[i];

                panel_SubMenu.Controls.Add(activityFrame);
            }
        }
        private void F_LoadSubMenuItems2()
        {
            panel_SubMenu.Controls.Clear();

            // 建立活動項目的 UserControl
            int itemWidth = 180;
            int itemHeight = 220;
            int padding = 10;

            string[] activities = new string[]
            {
            "活動頁", "人氣王", "溫暖窩窩新上市",
            "飼料5折", "罐罐爆殺", "銅板購"
            };

            for (int i = 0; i < activities.Length; i++)
            {
                UserControl_GoodsFrame activityFrame = new UserControl_GoodsFrame();
                activityFrame.Size = new Size(itemWidth, itemHeight);
                activityFrame.Location = new Point(
                    padding + (i % 4) * (itemWidth + padding),
                    padding + (i / 4) * (itemHeight + padding)
                );
                activityFrame.lbl_GoodName.Text = activities[i];

                panel_SubMenu.Controls.Add(activityFrame);
            }
        }
    }
}
