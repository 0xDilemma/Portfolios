using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SketchVer
{
    public partial class Form1 : Form
    {
        // Variable
        //--- 拖曳用----
        private bool beginMove = false;
        private int currentXPos; private int currentYPos;
        WFA_SketchVer.UserControl1 U1 = new  WFA_SketchVer.UserControl1();
        WFA_SketchVer.UserControl2 U2 = new WFA_SketchVer.UserControl2();

        //-------------
        // Method

        // Events
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("觸發成功");
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

        // 視窗關閉
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Call FormCart
        private void lbl_Cart_Click(object sender, EventArgs e)
        {
            Form_Cart myFormCart = new Form_Cart();
            myFormCart.ShowDialog();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Form_Login myFormLogin = new Form_Login();
            myFormLogin.ShowDialog();
        }

        private void btn_Item_Click(object sender, EventArgs e)
        {
            lbl_LB1.Visible = true;
            lbl_LB2.Visible = false;

            if ( !panel_PageShow.Controls.Contains(U1))
            {
                panel_PageShow.Controls.Add(U1);
                U1.Dock = DockStyle.Fill;
                U1.BringToFront();
            }
            else
            {
                U1.BringToFront();
            }
        }

        private void btn_List_Click(object sender, EventArgs e)
        {
            lbl_LB1.Visible = false;
            lbl_LB2.Visible = true;

            if (!panel_PageShow.Controls.Contains(U2))
            {
                panel_PageShow.Controls.Add(U2);
                U2.Dock = DockStyle.Fill;
                U2.BringToFront();
            }
            else
            {
                U2.BringToFront();
            }
        }
    }
}
