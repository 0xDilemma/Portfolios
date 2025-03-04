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
    public partial class UC_DropDownMenu : UserControl
    {

        // 變數
        private bool isSubMenuShown = false;
        private readonly int MAIN_MENU_HEIGHT = 30;  // MainMenu 的高度
        private readonly int FULL_HEIGHT = 152;  // 包含 MainMenu 和 SubMenu 的高度

        // 建構
        public UC_DropDownMenu()
        {
            InitializeComponent();
            InitializeSubMenuButtons();
            SetupEvents();
            // 初始化時只顯示 MainMenu 的高度
            this.Size = new Size(this.Width, MAIN_MENU_HEIGHT);
        }

        private void SetupEvents()
        {
            btn_Main.MouseEnter += MainButton_MouseEnter;
            btn_Main.MouseLeave += MainButton_MouseLeave; 
            btn_Main.FlatAppearance.BorderSize = 0;

            // 為整個控制項添加滑鼠事件
            this.MouseEnter += UC_DropDownMenu_MouseEnter;
            this.MouseLeave += UC_DropDownMenu_MouseLeave;
        }

        private void InitializeSubMenuButtons()
        {
            string[] menuItems = new string[]
            {
            "管理會員",
            "管理商品上下架",
            "管理訂單"
            };

            int buttonHeight = 40;
            for (int i = 0; i < menuItems.Length; i++)
            {
                Button btn = new Button
                {
                    Text = menuItems[i],
                    Height = buttonHeight,
                    Width = panel_SubMenu.Width,
                    FlatStyle = FlatStyle.Flat,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("微軟正黑體", 11),
                    Location = new Point(0, i * buttonHeight),
                    BackColor = Color.White,
                    Padding = new Padding(10, 0, 0, 0)
                };

                btn.FlatAppearance.BorderSize = 0;
                btn.Click += SubMenuItem_Click;
                btn.MouseLeave += SubMenu_MouseLeave;

                


                panel_SubMenu.Controls.Add(btn);
            }
        }

        //EVENT
        private void SubMenuItem_Click(object sender, EventArgs e) //針對子項目建立事件觸發
        {
            Button btn = sender as Button;
            switch (btn.Text)
            {
                case "管理會員":
                    Form_ManageUserInfo ManageUserForm = new Form_ManageUserInfo();
                    ManageUserForm.ShowDialog();
                    break;
                case "管理商品上下架":
                    Form_NewGoods NewGoodsForm = new Form_NewGoods();
                    NewGoodsForm.ShowDialog();
                    break;
                case "管理訂單":
                    MessageBox.Show("開啟訂單管理");
                    break;
            }
            HideSubMenu();
        }

        private void UC_DropDownMenu_MouseEnter(object sender, EventArgs e)
        {
            ShowSubMenu();
        }

        private void MainButton_MouseEnter(object sender, EventArgs e)
        {
            ShowSubMenu();
        }

        private void MainButton_MouseLeave(object sender, EventArgs e)
        {
            Point mousePos = this.PointToClient(Control.MousePosition);
            if (!this.ClientRectangle.Contains(mousePos))
            {
        HideSubMenu();
            }
        }

        private void ShowSubMenu()
        {
            if (!isSubMenuShown)
            {
                // 展開控制項到完整高度
                this.Size = new Size(this.Width, FULL_HEIGHT);
                panel_SubMenu.Visible = true;
                isSubMenuShown = true;
            }
        }

        private void UC_DropDownMenu_MouseLeave(object sender, EventArgs e)
        {
            Point mousePos = this.PointToClient(Control.MousePosition);
            if (!this.ClientRectangle.Contains(mousePos))
            {
                HideSubMenu();
            }
        }

        private void SubMenu_MouseLeave(object sender, EventArgs e)
        {
            Point mousePos = this.PointToClient(Control.MousePosition);
            if (!panel_MainMenu.Bounds.Contains(mousePos) &&
                !panel_SubMenu.Bounds.Contains(mousePos))
            {
                HideSubMenu();
            }
        }

        private void HideSubMenu()
        {
            // 縮小控制項到只顯示 MainMenu
            this.Size = new Size(this.Width, MAIN_MENU_HEIGHT);
            panel_SubMenu.Visible = false;
            isSubMenuShown = false;
        }

        private void UC_DropDownMenu_Load(object sender, EventArgs e)
        {
            this.Size = new Size(this.Width, MAIN_MENU_HEIGHT);
        }
    }
}
