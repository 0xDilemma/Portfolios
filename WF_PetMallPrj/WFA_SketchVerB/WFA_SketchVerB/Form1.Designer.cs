namespace WFA_SketchVerB
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_TitleBar = new System.Windows.Forms.Label();
            this.lbl_Close = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.uC_GoodsDetailCurrent = new WFA_SketchVerB.UC_GoodsDetail();
            this.uC_DownUserMenu1 = new WFA_SketchVerB.UC_DownUserMenu();
            this.UC_ManageMenu = new WFA_SketchVerB.UC_DropDownMenu();
            this.ucIcon_RoundBtn1 = new WFA_SketchVerB.UCIcon_RoundBtn();
            this.user_TopPnl1 = new WFA_SketchVerB.User_TopPnl();
            this.userControl_SideMenu1 = new WFA_SketchVerB.UserControl_SideMenu();
            this.uC_HomePage1 = new WFA_SketchVerB.UC_HomePage();
            this.lbl_botedge = new System.Windows.Forms.Label();
            this.lbl_leftedge = new System.Windows.Forms.Label();
            this.lbl_rightedge = new System.Windows.Forms.Label();
            this.ucIcon_Goback = new WFA_SketchVerB.UCIcon_RoundBtn();
            this.uC_CartCurrent = new WFA_SketchVerB.UC_Cart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TitleBar
            // 
            this.lbl_TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_TitleBar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleBar.ForeColor = System.Drawing.Color.White;
            this.lbl_TitleBar.Location = new System.Drawing.Point(0, 0);
            this.lbl_TitleBar.Name = "lbl_TitleBar";
            this.lbl_TitleBar.Size = new System.Drawing.Size(1160, 23);
            this.lbl_TitleBar.TabIndex = 2;
            this.lbl_TitleBar.Text = "Pet\'s Mall APP";
            this.lbl_TitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_TitleBar_MouseDown);
            this.lbl_TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_TitleBar_MouseMove);
            this.lbl_TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_TitleBar_MouseUp);
            // 
            // lbl_Close
            // 
            this.lbl_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Close.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Close.ForeColor = System.Drawing.Color.White;
            this.lbl_Close.Location = new System.Drawing.Point(1136, 2);
            this.lbl_Close.Name = "lbl_Close";
            this.lbl_Close.Size = new System.Drawing.Size(20, 20);
            this.lbl_Close.TabIndex = 3;
            this.lbl_Close.Text = "X";
            this.lbl_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Close.Click += new System.EventHandler(this.lbl_Close_Click);
            this.lbl_Close.MouseEnter += new System.EventHandler(this.lbl_Close_MouseEnter);
            this.lbl_Close.MouseLeave += new System.EventHandler(this.lbl_Close_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFA_SketchVerB.Properties.Resources.WF_catfprint;
            this.pictureBox1.Location = new System.Drawing.Point(0, 134);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 730);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::WFA_SketchVerB.Properties.Resources.WF_catfprint;
            this.pictureBox2.Location = new System.Drawing.Point(1085, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 864);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // uC_GoodsDetailCurrent
            // 
            this.uC_GoodsDetailCurrent.AutoScroll = true;
            this.uC_GoodsDetailCurrent.BackColor = System.Drawing.Color.White;
            this.uC_GoodsDetailCurrent.Location = new System.Drawing.Point(4, 132);
            this.uC_GoodsDetailCurrent.Margin = new System.Windows.Forms.Padding(4);
            this.uC_GoodsDetailCurrent.Name = "uC_GoodsDetailCurrent";
            this.uC_GoodsDetailCurrent.Size = new System.Drawing.Size(1152, 728);
            this.uC_GoodsDetailCurrent.TabIndex = 20;
            this.uC_GoodsDetailCurrent.Visible = false;
            // 
            // uC_DownUserMenu1
            // 
            this.uC_DownUserMenu1.Location = new System.Drawing.Point(1049, 31);
            this.uC_DownUserMenu1.Margin = new System.Windows.Forms.Padding(0);
            this.uC_DownUserMenu1.Name = "uC_DownUserMenu1";
            this.uC_DownUserMenu1.Size = new System.Drawing.Size(110, 57);
            this.uC_DownUserMenu1.TabIndex = 15;
            this.uC_DownUserMenu1.Visible = false;
            // 
            // UC_ManageMenu
            // 
            this.UC_ManageMenu.Location = new System.Drawing.Point(825, 98);
            this.UC_ManageMenu.Margin = new System.Windows.Forms.Padding(2);
            this.UC_ManageMenu.Name = "UC_ManageMenu";
            this.UC_ManageMenu.Size = new System.Drawing.Size(200, 30);
            this.UC_ManageMenu.TabIndex = 12;
            this.UC_ManageMenu.Visible = false;
            this.UC_ManageMenu.Load += new System.EventHandler(this.UC_ManageMenu_Load);
            // 
            // ucIcon_RoundBtn1
            // 
            this.ucIcon_RoundBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ucIcon_RoundBtn1.BorderColor = System.Drawing.Color.Gray;
            this.ucIcon_RoundBtn1.BorderRadius = 5;
            this.ucIcon_RoundBtn1.BorderSize = 2;
            this.ucIcon_RoundBtn1.EnableHoverEffect = true;
            this.ucIcon_RoundBtn1.FlatAppearance.BorderSize = 0;
            this.ucIcon_RoundBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucIcon_RoundBtn1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ucIcon_RoundBtn1.ForeColor = System.Drawing.Color.White;
            this.ucIcon_RoundBtn1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ucIcon_RoundBtn1.Location = new System.Drawing.Point(225, 98);
            this.ucIcon_RoundBtn1.Margin = new System.Windows.Forms.Padding(2);
            this.ucIcon_RoundBtn1.Name = "ucIcon_RoundBtn1";
            this.ucIcon_RoundBtn1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ucIcon_RoundBtn1.Size = new System.Drawing.Size(118, 32);
            this.ucIcon_RoundBtn1.TabIndex = 17;
            this.ucIcon_RoundBtn1.Text = "商品分類";
            this.ucIcon_RoundBtn1.UseVisualStyleBackColor = false;
            this.ucIcon_RoundBtn1.MouseEnter += new System.EventHandler(this.ucIcon_RoundBtn1_MouseEnter);
            this.ucIcon_RoundBtn1.MouseLeave += new System.EventHandler(this.ucIcon_RoundBtn1_MouseLeave);
            // 
            // user_TopPnl1
            // 
            this.user_TopPnl1.BackColor = System.Drawing.Color.White;
            this.user_TopPnl1.Location = new System.Drawing.Point(0, 22);
            this.user_TopPnl1.Margin = new System.Windows.Forms.Padding(2);
            this.user_TopPnl1.Name = "user_TopPnl1";
            this.user_TopPnl1.Size = new System.Drawing.Size(1160, 110);
            this.user_TopPnl1.TabIndex = 14;
            // 
            // userControl_SideMenu1
            // 
            this.userControl_SideMenu1.Location = new System.Drawing.Point(226, 127);
            this.userControl_SideMenu1.Margin = new System.Windows.Forms.Padding(0);
            this.userControl_SideMenu1.Name = "userControl_SideMenu1";
            this.userControl_SideMenu1.Size = new System.Drawing.Size(450, 200);
            this.userControl_SideMenu1.TabIndex = 18;
            this.userControl_SideMenu1.Visible = false;
            this.userControl_SideMenu1.MouseLeave += new System.EventHandler(this.userControl_SideMenu1_MouseLeave);
            // 
            // uC_HomePage1
            // 
            this.uC_HomePage1.AutoScroll = true;
            this.uC_HomePage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(191)))), ((int)(((byte)(159)))));
            this.uC_HomePage1.Location = new System.Drawing.Point(74, 134);
            this.uC_HomePage1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_HomePage1.Name = "uC_HomePage1";
            this.uC_HomePage1.Size = new System.Drawing.Size(1012, 720);
            this.uC_HomePage1.TabIndex = 13;
            // 
            // lbl_botedge
            // 
            this.lbl_botedge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_botedge.Location = new System.Drawing.Point(0, 860);
            this.lbl_botedge.Name = "lbl_botedge";
            this.lbl_botedge.Size = new System.Drawing.Size(1160, 4);
            this.lbl_botedge.TabIndex = 21;
            // 
            // lbl_leftedge
            // 
            this.lbl_leftedge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_leftedge.Location = new System.Drawing.Point(0, 0);
            this.lbl_leftedge.Name = "lbl_leftedge";
            this.lbl_leftedge.Size = new System.Drawing.Size(4, 864);
            this.lbl_leftedge.TabIndex = 21;
            // 
            // lbl_rightedge
            // 
            this.lbl_rightedge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_rightedge.Location = new System.Drawing.Point(1156, 0);
            this.lbl_rightedge.Name = "lbl_rightedge";
            this.lbl_rightedge.Size = new System.Drawing.Size(4, 864);
            this.lbl_rightedge.TabIndex = 22;
            // 
            // ucIcon_Goback
            // 
            this.ucIcon_Goback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ucIcon_Goback.BorderColor = System.Drawing.Color.White;
            this.ucIcon_Goback.BorderRadius = 5;
            this.ucIcon_Goback.BorderSize = 1;
            this.ucIcon_Goback.EnableHoverEffect = true;
            this.ucIcon_Goback.FlatAppearance.BorderSize = 0;
            this.ucIcon_Goback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucIcon_Goback.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ucIcon_Goback.ForeColor = System.Drawing.Color.White;
            this.ucIcon_Goback.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ucIcon_Goback.Location = new System.Drawing.Point(113, 141);
            this.ucIcon_Goback.Name = "ucIcon_Goback";
            this.ucIcon_Goback.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ucIcon_Goback.Size = new System.Drawing.Size(102, 40);
            this.ucIcon_Goback.TabIndex = 23;
            this.ucIcon_Goback.Text = "返回";
            this.ucIcon_Goback.UseVisualStyleBackColor = false;
            this.ucIcon_Goback.Visible = false;
            this.ucIcon_Goback.Click += new System.EventHandler(this.ucIcon_Goback_Click);
            // 
            // uC_CartCurrent
            // 
            this.uC_CartCurrent.AutoScroll = true;
            this.uC_CartCurrent.BackColor = System.Drawing.Color.White;
            this.uC_CartCurrent.Location = new System.Drawing.Point(731, 93);
            this.uC_CartCurrent.Name = "uC_CartCurrent";
            this.uC_CartCurrent.Size = new System.Drawing.Size(425, 447);
            this.uC_CartCurrent.TabIndex = 24;
            this.uC_CartCurrent.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1160, 864);
            this.Controls.Add(this.uC_CartCurrent);
            this.Controls.Add(this.ucIcon_Goback);
            this.Controls.Add(this.ucIcon_RoundBtn1);
            this.Controls.Add(this.UC_ManageMenu);
            this.Controls.Add(this.lbl_rightedge);
            this.Controls.Add(this.lbl_leftedge);
            this.Controls.Add(this.lbl_botedge);
            this.Controls.Add(this.uC_GoodsDetailCurrent);
            this.Controls.Add(this.uC_DownUserMenu1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Close);
            this.Controls.Add(this.lbl_TitleBar);
            this.Controls.Add(this.user_TopPnl1);
            this.Controls.Add(this.userControl_SideMenu1);
            this.Controls.Add(this.uC_HomePage1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "PetMall";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_TitleBar;
        private System.Windows.Forms.Label lbl_Close;
        public User_TopPnl user_TopPnl1;
        public UC_DownUserMenu uC_DownUserMenu1;
        public UC_HomePage uC_HomePage1;
        private UCIcon_RoundBtn ucIcon_RoundBtn1;
        private UserControl_SideMenu userControl_SideMenu1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_botedge;
        private System.Windows.Forms.Label lbl_leftedge;
        private System.Windows.Forms.Label lbl_rightedge;
        private UCIcon_RoundBtn ucIcon_Goback;
        public UC_GoodsDetail uC_GoodsDetailCurrent;
        public UC_Cart uC_CartCurrent;
        public UC_DropDownMenu UC_ManageMenu;
    }
}

