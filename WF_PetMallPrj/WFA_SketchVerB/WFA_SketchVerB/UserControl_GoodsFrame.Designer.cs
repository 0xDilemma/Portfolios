namespace WFA_SketchVerB
{
    partial class UserControl_GoodsFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_GoodsFrame));
            this.lbl_GoodPrice = new System.Windows.Forms.Label();
            this.lbl_GoodName = new System.Windows.Forms.TextBox();
            this.pnl_plus = new System.Windows.Forms.Panel();
            this.pbox_plus = new System.Windows.Forms.PictureBox();
            this.pbox_minicart = new System.Windows.Forms.PictureBox();
            this.pbox_GoodPrimary = new System.Windows.Forms.PictureBox();
            this.pnl_minus = new System.Windows.Forms.Panel();
            this.pbox_minus = new System.Windows.Forms.PictureBox();
            this.fLP_MinitoCart = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_Quant = new System.Windows.Forms.TextBox();
            this.lbl_addtocart = new System.Windows.Forms.Label();
            this.pnl_edge = new System.Windows.Forms.Panel();
            this.pnl_plus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_plus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_minicart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_GoodPrimary)).BeginInit();
            this.pnl_minus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_minus)).BeginInit();
            this.fLP_MinitoCart.SuspendLayout();
            this.pnl_edge.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_GoodPrice
            // 
            this.lbl_GoodPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_GoodPrice.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_GoodPrice.ForeColor = System.Drawing.Color.Red;
            this.lbl_GoodPrice.Location = new System.Drawing.Point(16, 186);
            this.lbl_GoodPrice.Name = "lbl_GoodPrice";
            this.lbl_GoodPrice.Size = new System.Drawing.Size(112, 63);
            this.lbl_GoodPrice.TabIndex = 1;
            this.lbl_GoodPrice.Text = "價格";
            this.lbl_GoodPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_GoodPrice.MouseEnter += new System.EventHandler(this.UserControl_GoodsFrame_MouseEnter);
            // 
            // lbl_GoodName
            // 
            this.lbl_GoodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_GoodName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_GoodName.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_GoodName.Location = new System.Drawing.Point(15, 150);
            this.lbl_GoodName.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_GoodName.Multiline = true;
            this.lbl_GoodName.Name = "lbl_GoodName";
            this.lbl_GoodName.Size = new System.Drawing.Size(135, 34);
            this.lbl_GoodName.TabIndex = 2;
            this.lbl_GoodName.Text = "品名";
            this.lbl_GoodName.MouseEnter += new System.EventHandler(this.UserControl_GoodsFrame_MouseEnter);
            this.lbl_GoodName.MouseLeave += new System.EventHandler(this.UserControl_GoodsFrame_MouseLeave);
            // 
            // pnl_plus
            // 
            this.pnl_plus.Controls.Add(this.pbox_plus);
            this.pnl_plus.Location = new System.Drawing.Point(54, 0);
            this.pnl_plus.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_plus.Name = "pnl_plus";
            this.pnl_plus.Size = new System.Drawing.Size(19, 26);
            this.pnl_plus.TabIndex = 4;
            this.pnl_plus.Click += new System.EventHandler(this.pnl_plus_Click);
            this.pnl_plus.MouseEnter += new System.EventHandler(this.pnl_minus_MouseEnter);
            this.pnl_plus.MouseLeave += new System.EventHandler(this.pnl_minus_MouseLeave);
            // 
            // pbox_plus
            // 
            this.pbox_plus.Image = global::WFA_SketchVerB.Properties.Resources.tinyplus;
            this.pbox_plus.Location = new System.Drawing.Point(4, 6);
            this.pbox_plus.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.pbox_plus.Name = "pbox_plus";
            this.pbox_plus.Size = new System.Drawing.Size(11, 12);
            this.pbox_plus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_plus.TabIndex = 0;
            this.pbox_plus.TabStop = false;
            this.pbox_plus.Click += new System.EventHandler(this.pnl_plus_Click);
            this.pbox_plus.MouseEnter += new System.EventHandler(this.pbox_minus_MouseEnter);
            // 
            // pbox_minicart
            // 
            this.pbox_minicart.Image = ((System.Drawing.Image)(resources.GetObject("pbox_minicart.Image")));
            this.pbox_minicart.Location = new System.Drawing.Point(113, 7);
            this.pbox_minicart.Margin = new System.Windows.Forms.Padding(1);
            this.pbox_minicart.Name = "pbox_minicart";
            this.pbox_minicart.Size = new System.Drawing.Size(26, 24);
            this.pbox_minicart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_minicart.TabIndex = 3;
            this.pbox_minicart.TabStop = false;
            this.pbox_minicart.MouseEnter += new System.EventHandler(this.pbox_minicart_MouseEnter);
            // 
            // pbox_GoodPrimary
            // 
            this.pbox_GoodPrimary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbox_GoodPrimary.BackColor = System.Drawing.Color.White;
            this.pbox_GoodPrimary.Location = new System.Drawing.Point(15, 8);
            this.pbox_GoodPrimary.Name = "pbox_GoodPrimary";
            this.pbox_GoodPrimary.Size = new System.Drawing.Size(135, 144);
            this.pbox_GoodPrimary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_GoodPrimary.TabIndex = 0;
            this.pbox_GoodPrimary.TabStop = false;
            this.pbox_GoodPrimary.MouseEnter += new System.EventHandler(this.UserControl_GoodsFrame_MouseEnter);
            this.pbox_GoodPrimary.MouseLeave += new System.EventHandler(this.UserControl_GoodsFrame_MouseLeave);
            // 
            // pnl_minus
            // 
            this.pnl_minus.Controls.Add(this.pbox_minus);
            this.pnl_minus.Location = new System.Drawing.Point(0, 0);
            this.pnl_minus.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_minus.Name = "pnl_minus";
            this.pnl_minus.Size = new System.Drawing.Size(19, 26);
            this.pnl_minus.TabIndex = 4;
            this.pnl_minus.Click += new System.EventHandler(this.pnl_minus_Click);
            this.pnl_minus.MouseEnter += new System.EventHandler(this.pnl_minus_MouseEnter);
            this.pnl_minus.MouseLeave += new System.EventHandler(this.pnl_minus_MouseLeave);
            // 
            // pbox_minus
            // 
            this.pbox_minus.Image = global::WFA_SketchVerB.Properties.Resources.tinyminus;
            this.pbox_minus.Location = new System.Drawing.Point(4, 6);
            this.pbox_minus.Margin = new System.Windows.Forms.Padding(2);
            this.pbox_minus.Name = "pbox_minus";
            this.pbox_minus.Size = new System.Drawing.Size(11, 12);
            this.pbox_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_minus.TabIndex = 0;
            this.pbox_minus.TabStop = false;
            this.pbox_minus.Click += new System.EventHandler(this.pnl_minus_Click);
            this.pbox_minus.MouseEnter += new System.EventHandler(this.pbox_minus_MouseEnter);
            // 
            // fLP_MinitoCart
            // 
            this.fLP_MinitoCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.fLP_MinitoCart.Controls.Add(this.pnl_minus);
            this.fLP_MinitoCart.Controls.Add(this.txt_Quant);
            this.fLP_MinitoCart.Controls.Add(this.pnl_plus);
            this.fLP_MinitoCart.Controls.Add(this.lbl_addtocart);
            this.fLP_MinitoCart.Location = new System.Drawing.Point(1, 6);
            this.fLP_MinitoCart.Margin = new System.Windows.Forms.Padding(0);
            this.fLP_MinitoCart.Name = "fLP_MinitoCart";
            this.fLP_MinitoCart.Size = new System.Drawing.Size(112, 28);
            this.fLP_MinitoCart.TabIndex = 5;
            this.fLP_MinitoCart.MouseEnter += new System.EventHandler(this.pbox_minicart_MouseEnter);
            // 
            // txt_Quant
            // 
            this.txt_Quant.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Quant.Location = new System.Drawing.Point(19, 2);
            this.txt_Quant.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.txt_Quant.Name = "txt_Quant";
            this.txt_Quant.Size = new System.Drawing.Size(35, 23);
            this.txt_Quant.TabIndex = 6;
            this.txt_Quant.Text = "1";
            this.txt_Quant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Quant.TextChanged += new System.EventHandler(this.txt_Quant_TextChanged);
            this.txt_Quant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Quant_KeyDown);
            // 
            // lbl_addtocart
            // 
            this.lbl_addtocart.BackColor = System.Drawing.Color.White;
            this.lbl_addtocart.Font = new System.Drawing.Font("細明體-ExtB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_addtocart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_addtocart.Location = new System.Drawing.Point(73, 2);
            this.lbl_addtocart.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lbl_addtocart.Name = "lbl_addtocart";
            this.lbl_addtocart.Size = new System.Drawing.Size(30, 24);
            this.lbl_addtocart.TabIndex = 6;
            this.lbl_addtocart.Text = "加入";
            this.lbl_addtocart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_addtocart.Click += new System.EventHandler(this.lbl_addtocart_Click);
            this.lbl_addtocart.MouseEnter += new System.EventHandler(this.lbl_addtocart_MouseEnter);
            this.lbl_addtocart.MouseLeave += new System.EventHandler(this.lbl_addtocart_MouseLeave);
            // 
            // pnl_edge
            // 
            this.pnl_edge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_edge.BackColor = System.Drawing.Color.White;
            this.pnl_edge.Controls.Add(this.fLP_MinitoCart);
            this.pnl_edge.Controls.Add(this.pbox_minicart);
            this.pnl_edge.Location = new System.Drawing.Point(15, 184);
            this.pnl_edge.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_edge.Name = "pnl_edge";
            this.pnl_edge.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnl_edge.Size = new System.Drawing.Size(146, 40);
            this.pnl_edge.TabIndex = 6;
            this.pnl_edge.MouseLeave += new System.EventHandler(this.pnl_edge_MouseLeave);
            // 
            // UserControl_GoodsFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_GoodPrice);
            this.Controls.Add(this.pbox_GoodPrimary);
            this.Controls.Add(this.lbl_GoodName);
            this.Controls.Add(this.pnl_edge);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "UserControl_GoodsFrame";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(167, 253);
            this.Load += new System.EventHandler(this.UserControl_GoodsFrame_Load);
            this.MouseEnter += new System.EventHandler(this.UserControl_GoodsFrame_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserControl_GoodsFrame_MouseLeave);
            this.pnl_plus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_plus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_minicart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_GoodPrimary)).EndInit();
            this.pnl_minus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_minus)).EndInit();
            this.fLP_MinitoCart.ResumeLayout(false);
            this.fLP_MinitoCart.PerformLayout();
            this.pnl_edge.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbl_GoodPrice;
        public System.Windows.Forms.PictureBox pbox_GoodPrimary;
        public System.Windows.Forms.TextBox lbl_GoodName;
        public System.Windows.Forms.PictureBox pbox_minicart;
        public System.Windows.Forms.Panel pnl_plus;
        public System.Windows.Forms.PictureBox pbox_plus;
        public System.Windows.Forms.Panel pnl_minus;
        public System.Windows.Forms.PictureBox pbox_minus;
        public System.Windows.Forms.FlowLayoutPanel fLP_MinitoCart;
        public System.Windows.Forms.TextBox txt_Quant;
        public System.Windows.Forms.Label lbl_addtocart;
        public System.Windows.Forms.Panel pnl_edge;
    }
}
