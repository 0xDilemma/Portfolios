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
    public partial class UC_DownUserMenu : UserControl
    {
        // 變數
        private bool isSubMenuShown = false;
        private readonly int MAIN_MENU_HEIGHT = 57;  // MainMenu 的高度
        private readonly int FULL_HEIGHT = 180;  // 包含 MainMenu 和 SubMenu 的高度

        private void ShowSubMenu()
        {
            if (!isSubMenuShown)
            {
                // 展開控制項到完整高度
                this.Size = new Size(this.Width, FULL_HEIGHT);
                fLPnl_SubMenu.Visible = true;
                isSubMenuShown = true;
            }
        }

        private void HideSubMenu()
        {
            // 縮小控制項到只顯示 MainMenu
            this.Size = new Size(this.Width, MAIN_MENU_HEIGHT);
            fLPnl_SubMenu.Visible = false;
            isSubMenuShown = false;
        }

        // 建構
        public UC_DownUserMenu()
        {
            InitializeComponent();
            ucIcon_ShowUName.EnableHoverEffect = false;
            SetupEvents();
            // 初始化時只顯示 MainMenu 的高度
            this.Size = new Size(this.Width, MAIN_MENU_HEIGHT);
        }

        private void UC_DownUserMenu_Load(object sender, EventArgs e)
        {
            this.Size = new Size(this.Width, MAIN_MENU_HEIGHT);
        }

        private void SetupEvents()
        {
            pnl_Main.MouseEnter += MainButton_MouseEnter;
            pnl_Main.MouseLeave += MainButton_MouseLeave;


            // 為整個控制項添加滑鼠事件
            //this.MouseEnter += UC_DropDownMenu_MouseEnter;
            this.MouseLeave += UC_DropDownMenu_MouseLeave;
        }

        private void UC_DropDownMenu_MouseEnter(object sender, EventArgs e)
        {
            ShowSubMenu();
        }

        private void UC_DropDownMenu_MouseLeave(object sender, EventArgs e)
        {

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

        private void ucIcon_Logout_Click(object sender, EventArgs e)
        {
            // 清空 GV 中的 Currentuser
            GlobalVar.CurrentUser = null;
            // 清空訂單
            GlobalVar.listOrderCollection.Clear();
            // 隱藏用戶選單
            this.Visible = false;

            // 調整頂部面板按鈕位置
            GlobalVar.MainForm.user_TopPnl1.AdjustButtonsPosition(false);
        }

        private void ucIcon_RoundBtn1_Click(object sender, EventArgs e)
        {
            Form_PersonalInfo uC_PersonalInfo = new Form_PersonalInfo();
            uC_PersonalInfo.ShowDialog();
        }
    }
}
