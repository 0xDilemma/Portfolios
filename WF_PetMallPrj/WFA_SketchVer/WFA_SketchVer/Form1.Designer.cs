namespace WFA_SketchVer
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Cart = new System.Windows.Forms.Label();
            this.lbl_TitleBar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Item = new System.Windows.Forms.Button();
            this.panel_L1 = new System.Windows.Forms.Panel();
            this.lbl_LB2 = new System.Windows.Forms.Label();
            this.lbl_LB1 = new System.Windows.Forms.Label();
            this.btn_List = new System.Windows.Forms.Button();
            this.panel_PageShow = new System.Windows.Forms.Panel();
            this.panel_Top.SuspendLayout();
            this.panel_L1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gabriola", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(12, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pet\'s Mall";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel_Top.Controls.Add(this.btn_Login);
            this.panel_Top.Controls.Add(this.lbl_Cart);
            this.panel_Top.Controls.Add(this.label1);
            this.panel_Top.Location = new System.Drawing.Point(0, 28);
            this.panel_Top.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1100, 89);
            this.panel_Top.TabIndex = 1;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Login.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Login.Location = new System.Drawing.Point(779, 23);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(143, 44);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "會員登入";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_Cart
            // 
            this.lbl_Cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Cart.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Cart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Cart.Location = new System.Drawing.Point(973, 26);
            this.lbl_Cart.Name = "lbl_Cart";
            this.lbl_Cart.Size = new System.Drawing.Size(109, 41);
            this.lbl_Cart.TabIndex = 1;
            this.lbl_Cart.Text = "購物車";
            this.lbl_Cart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Cart.Click += new System.EventHandler(this.lbl_Cart_Click);
            // 
            // lbl_TitleBar
            // 
            this.lbl_TitleBar.BackColor = System.Drawing.Color.White;
            this.lbl_TitleBar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleBar.Location = new System.Drawing.Point(4, 1);
            this.lbl_TitleBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TitleBar.Name = "lbl_TitleBar";
            this.lbl_TitleBar.Size = new System.Drawing.Size(1096, 29);
            this.lbl_TitleBar.TabIndex = 2;
            this.lbl_TitleBar.Text = "Pet\'s Mall APP";
            this.lbl_TitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_TitleBar_MouseDown);
            this.lbl_TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_TitleBar_MouseMove);
            this.lbl_TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_TitleBar_MouseUp);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(73)))), ((int)(((byte)(56)))));
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(1072, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "X";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_Item
            // 
            this.btn_Item.BackColor = System.Drawing.Color.White;
            this.btn_Item.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Item.Location = new System.Drawing.Point(0, -1);
            this.btn_Item.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Item.Name = "btn_Item";
            this.btn_Item.Size = new System.Drawing.Size(135, 104);
            this.btn_Item.TabIndex = 5;
            this.btn_Item.Text = "品項";
            this.btn_Item.UseVisualStyleBackColor = false;
            this.btn_Item.Click += new System.EventHandler(this.btn_Item_Click);
            // 
            // panel_L1
            // 
            this.panel_L1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel_L1.Controls.Add(this.lbl_LB2);
            this.panel_L1.Controls.Add(this.lbl_LB1);
            this.panel_L1.Controls.Add(this.btn_List);
            this.panel_L1.Controls.Add(this.btn_Item);
            this.panel_L1.Location = new System.Drawing.Point(0, 118);
            this.panel_L1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_L1.Name = "panel_L1";
            this.panel_L1.Size = new System.Drawing.Size(135, 600);
            this.panel_L1.TabIndex = 6;
            // 
            // lbl_LB2
            // 
            this.lbl_LB2.BackColor = System.Drawing.Color.Green;
            this.lbl_LB2.Location = new System.Drawing.Point(-3, 100);
            this.lbl_LB2.Name = "lbl_LB2";
            this.lbl_LB2.Size = new System.Drawing.Size(11, 104);
            this.lbl_LB2.TabIndex = 7;
            // 
            // lbl_LB1
            // 
            this.lbl_LB1.BackColor = System.Drawing.Color.Green;
            this.lbl_LB1.Location = new System.Drawing.Point(-3, -2);
            this.lbl_LB1.Name = "lbl_LB1";
            this.lbl_LB1.Size = new System.Drawing.Size(11, 104);
            this.lbl_LB1.TabIndex = 7;
            // 
            // btn_List
            // 
            this.btn_List.BackColor = System.Drawing.Color.White;
            this.btn_List.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_List.Location = new System.Drawing.Point(0, 102);
            this.btn_List.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(135, 104);
            this.btn_List.TabIndex = 5;
            this.btn_List.Text = "列表";
            this.btn_List.UseVisualStyleBackColor = false;
            this.btn_List.Click += new System.EventHandler(this.btn_List_Click);
            // 
            // panel_PageShow
            // 
            this.panel_PageShow.Location = new System.Drawing.Point(133, 118);
            this.panel_PageShow.Name = "panel_PageShow";
            this.panel_PageShow.Size = new System.Drawing.Size(966, 600);
            this.panel_PageShow.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(132)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1097, 720);
            this.Controls.Add(this.panel_PageShow);
            this.Controls.Add(this.panel_L1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_TitleBar);
            this.Controls.Add(this.panel_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "PetMall";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Top.ResumeLayout(false);
            this.panel_L1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label lbl_Cart;
        private System.Windows.Forms.Label lbl_TitleBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Panel panel_L1;
        private System.Windows.Forms.Button btn_Item;
        private System.Windows.Forms.Button btn_List;
        private System.Windows.Forms.Label lbl_LB1;
        private System.Windows.Forms.Label lbl_LB2;
        private System.Windows.Forms.Panel panel_PageShow;
    }
}

