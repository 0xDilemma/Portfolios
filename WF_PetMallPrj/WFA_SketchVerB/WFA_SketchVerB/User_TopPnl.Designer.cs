namespace WFA_SketchVerB
{
    partial class User_TopPnl
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_TopPnl));
            this.fLPnl_Login = new System.Windows.Forms.FlowLayoutPanel();
            this.pbox_Login = new System.Windows.Forms.PictureBox();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.fLPnl_ShopCart = new System.Windows.Forms.FlowLayoutPanel();
            this.pbox_ShopCart = new System.Windows.Forms.PictureBox();
            this.lbl_ShopCart = new System.Windows.Forms.Label();
            this.fLPnl_HomePage = new System.Windows.Forms.FlowLayoutPanel();
            this.pbox_HomePage = new System.Windows.Forms.PictureBox();
            this.lbl_HomePage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uC_DownUserMenu1 = new WFA_SketchVerB.UC_DownUserMenu();
            this.uC_RoundedTextBox1 = new WFA_SketchVerB.UC_RoundedTextBox();
            this.lbl_Line = new System.Windows.Forms.Label();
            this.ucIcon_QuerySearch = new WFA_SketchVerB.UCIcon_RoundBtn();
            this.txt_Query = new System.Windows.Forms.TextBox();
            this.fLPnl_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Login)).BeginInit();
            this.fLPnl_ShopCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ShopCart)).BeginInit();
            this.fLPnl_HomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_HomePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // fLPnl_Login
            // 
            this.fLPnl_Login.Controls.Add(this.pbox_Login);
            this.fLPnl_Login.Controls.Add(this.lbl_Login);
            this.fLPnl_Login.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fLPnl_Login.Location = new System.Drawing.Point(1094, 9);
            this.fLPnl_Login.Margin = new System.Windows.Forms.Padding(2);
            this.fLPnl_Login.Name = "fLPnl_Login";
            this.fLPnl_Login.Size = new System.Drawing.Size(64, 57);
            this.fLPnl_Login.TabIndex = 1;
            this.fLPnl_Login.Click += new System.EventHandler(this.fLPnl_Login_Click);
            // 
            // pbox_Login
            // 
            this.pbox_Login.Image = global::WFA_SketchVerB.Properties.Resources.user;
            this.pbox_Login.Location = new System.Drawing.Point(2, 2);
            this.pbox_Login.Margin = new System.Windows.Forms.Padding(2);
            this.pbox_Login.Name = "pbox_Login";
            this.pbox_Login.Size = new System.Drawing.Size(62, 34);
            this.pbox_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_Login.TabIndex = 0;
            this.pbox_Login.TabStop = false;
            this.pbox_Login.Click += new System.EventHandler(this.fLPnl_Login_Click);
            // 
            // lbl_Login
            // 
            this.lbl_Login.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Login.Location = new System.Drawing.Point(2, 38);
            this.lbl_Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(62, 18);
            this.lbl_Login.TabIndex = 1;
            this.lbl_Login.Text = "會員登入";
            this.lbl_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Login.Click += new System.EventHandler(this.fLPnl_Login_Click);
            // 
            // fLPnl_ShopCart
            // 
            this.fLPnl_ShopCart.Controls.Add(this.pbox_ShopCart);
            this.fLPnl_ShopCart.Controls.Add(this.lbl_ShopCart);
            this.fLPnl_ShopCart.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fLPnl_ShopCart.Location = new System.Drawing.Point(1034, 9);
            this.fLPnl_ShopCart.Margin = new System.Windows.Forms.Padding(2);
            this.fLPnl_ShopCart.Name = "fLPnl_ShopCart";
            this.fLPnl_ShopCart.Size = new System.Drawing.Size(57, 57);
            this.fLPnl_ShopCart.TabIndex = 1;
            this.fLPnl_ShopCart.Click += new System.EventHandler(this.fLPnl_ShopCart_Click);
            // 
            // pbox_ShopCart
            // 
            this.pbox_ShopCart.Image = global::WFA_SketchVerB.Properties.Resources.shopping_bag;
            this.pbox_ShopCart.Location = new System.Drawing.Point(2, 2);
            this.pbox_ShopCart.Margin = new System.Windows.Forms.Padding(2);
            this.pbox_ShopCart.Name = "pbox_ShopCart";
            this.pbox_ShopCart.Size = new System.Drawing.Size(55, 34);
            this.pbox_ShopCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_ShopCart.TabIndex = 0;
            this.pbox_ShopCart.TabStop = false;
            this.pbox_ShopCart.Click += new System.EventHandler(this.fLPnl_ShopCart_Click);
            // 
            // lbl_ShopCart
            // 
            this.lbl_ShopCart.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_ShopCart.Location = new System.Drawing.Point(2, 38);
            this.lbl_ShopCart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ShopCart.Name = "lbl_ShopCart";
            this.lbl_ShopCart.Size = new System.Drawing.Size(55, 18);
            this.lbl_ShopCart.TabIndex = 1;
            this.lbl_ShopCart.Text = "購物車";
            this.lbl_ShopCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_ShopCart.Click += new System.EventHandler(this.fLPnl_ShopCart_Click);
            // 
            // fLPnl_HomePage
            // 
            this.fLPnl_HomePage.Controls.Add(this.pbox_HomePage);
            this.fLPnl_HomePage.Controls.Add(this.lbl_HomePage);
            this.fLPnl_HomePage.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fLPnl_HomePage.Location = new System.Drawing.Point(975, 9);
            this.fLPnl_HomePage.Margin = new System.Windows.Forms.Padding(2);
            this.fLPnl_HomePage.Name = "fLPnl_HomePage";
            this.fLPnl_HomePage.Size = new System.Drawing.Size(57, 57);
            this.fLPnl_HomePage.TabIndex = 1;
            this.fLPnl_HomePage.Click += new System.EventHandler(this.fLPnl_HomePage_Click);
            // 
            // pbox_HomePage
            // 
            this.pbox_HomePage.Image = global::WFA_SketchVerB.Properties.Resources.home;
            this.pbox_HomePage.Location = new System.Drawing.Point(2, 2);
            this.pbox_HomePage.Margin = new System.Windows.Forms.Padding(2);
            this.pbox_HomePage.Name = "pbox_HomePage";
            this.pbox_HomePage.Size = new System.Drawing.Size(55, 34);
            this.pbox_HomePage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_HomePage.TabIndex = 0;
            this.pbox_HomePage.TabStop = false;
            this.pbox_HomePage.Click += new System.EventHandler(this.fLPnl_HomePage_Click);
            // 
            // lbl_HomePage
            // 
            this.lbl_HomePage.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_HomePage.Location = new System.Drawing.Point(2, 38);
            this.lbl_HomePage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_HomePage.Name = "lbl_HomePage";
            this.lbl_HomePage.Size = new System.Drawing.Size(55, 18);
            this.lbl_HomePage.TabIndex = 1;
            this.lbl_HomePage.Text = "首頁";
            this.lbl_HomePage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_HomePage.Click += new System.EventHandler(this.fLPnl_HomePage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(338, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "熱詞";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(249, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "活動專區";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(59, -22);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(152, 144);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(170)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(742, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // uC_DownUserMenu1
            // 
            this.uC_DownUserMenu1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_DownUserMenu1.Location = new System.Drawing.Point(1052, 9);
            this.uC_DownUserMenu1.Margin = new System.Windows.Forms.Padding(0);
            this.uC_DownUserMenu1.Name = "uC_DownUserMenu1";
            this.uC_DownUserMenu1.Size = new System.Drawing.Size(108, 57);
            this.uC_DownUserMenu1.TabIndex = 7;
            this.uC_DownUserMenu1.Visible = false;
            // 
            // uC_RoundedTextBox1
            // 
            this.uC_RoundedTextBox1.BackColor = System.Drawing.Color.White;
            this.uC_RoundedTextBox1.Enabled = false;
            this.uC_RoundedTextBox1.Location = new System.Drawing.Point(306, 9);
            this.uC_RoundedTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uC_RoundedTextBox1.Name = "uC_RoundedTextBox1";
            this.uC_RoundedTextBox1.Size = new System.Drawing.Size(494, 38);
            this.uC_RoundedTextBox1.TabIndex = 3;
            this.uC_RoundedTextBox1.UserColor = System.Drawing.Color.White;
            // 
            // lbl_Line
            // 
            this.lbl_Line.BackColor = System.Drawing.Color.Black;
            this.lbl_Line.Location = new System.Drawing.Point(0, 109);
            this.lbl_Line.Name = "lbl_Line";
            this.lbl_Line.Size = new System.Drawing.Size(1160, 1);
            this.lbl_Line.TabIndex = 8;
            // 
            // ucIcon_QuerySearch
            // 
            this.ucIcon_QuerySearch.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.ucIcon_QuerySearch.BackColor = System.Drawing.Color.Gray;
            this.ucIcon_QuerySearch.BorderColor = System.Drawing.Color.White;
            this.ucIcon_QuerySearch.BorderRadius = 10;
            this.ucIcon_QuerySearch.BorderSize = 2;
            this.ucIcon_QuerySearch.EnableHoverEffect = true;
            this.ucIcon_QuerySearch.FlatAppearance.BorderSize = 0;
            this.ucIcon_QuerySearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucIcon_QuerySearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ucIcon_QuerySearch.ForeColor = System.Drawing.Color.White;
            this.ucIcon_QuerySearch.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ucIcon_QuerySearch.Location = new System.Drawing.Point(805, 9);
            this.ucIcon_QuerySearch.Name = "ucIcon_QuerySearch";
            this.ucIcon_QuerySearch.NormalColor = System.Drawing.Color.Gray;
            this.ucIcon_QuerySearch.Size = new System.Drawing.Size(73, 35);
            this.ucIcon_QuerySearch.TabIndex = 9;
            this.ucIcon_QuerySearch.Text = "搜尋~";
            this.ucIcon_QuerySearch.UseVisualStyleBackColor = false;
            // 
            // txt_Query
            // 
            this.txt_Query.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Query.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Query.Location = new System.Drawing.Point(324, 18);
            this.txt_Query.Name = "txt_Query";
            this.txt_Query.Size = new System.Drawing.Size(439, 22);
            this.txt_Query.TabIndex = 10;
            this.txt_Query.Text = "關鍵字...";
            // 
            // User_TopPnl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txt_Query);
            this.Controls.Add(this.ucIcon_QuerySearch);
            this.Controls.Add(this.lbl_Line);
            this.Controls.Add(this.uC_DownUserMenu1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uC_RoundedTextBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.fLPnl_HomePage);
            this.Controls.Add(this.fLPnl_ShopCart);
            this.Controls.Add(this.fLPnl_Login);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "User_TopPnl";
            this.Size = new System.Drawing.Size(1160, 110);
            this.Load += new System.EventHandler(this.User_TopPnl_Load);
            this.fLPnl_Login.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Login)).EndInit();
            this.fLPnl_ShopCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ShopCart)).EndInit();
            this.fLPnl_HomePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_HomePage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_Login;
        private System.Windows.Forms.FlowLayoutPanel fLPnl_Login;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.FlowLayoutPanel fLPnl_ShopCart;
        private System.Windows.Forms.PictureBox pbox_ShopCart;
        private System.Windows.Forms.Label lbl_ShopCart;
        private System.Windows.Forms.FlowLayoutPanel fLPnl_HomePage;
        private System.Windows.Forms.PictureBox pbox_HomePage;
        private System.Windows.Forms.Label lbl_HomePage;
        private System.Windows.Forms.PictureBox pictureBox4;
        private UC_RoundedTextBox uC_RoundedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private UC_DownUserMenu uC_DownUserMenu1;
        private System.Windows.Forms.Label lbl_Line;
        private UCIcon_RoundBtn ucIcon_QuerySearch;
        private System.Windows.Forms.TextBox txt_Query;
    }
}
