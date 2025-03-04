namespace WFA_SketchVerB
{
    partial class UC_CartRowFrame
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
            this.txt_ShowthisName = new System.Windows.Forms.TextBox();
            this.pBox_Trash = new System.Windows.Forms.PictureBox();
            this.pbox_ShowthisImage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_minus = new System.Windows.Forms.Panel();
            this.pbox_minus = new System.Windows.Forms.PictureBox();
            this.pnl_plus = new System.Windows.Forms.Panel();
            this.pbox_plus = new System.Windows.Forms.PictureBox();
            this.txt_Quant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ShowthisTot = new System.Windows.Forms.Label();
            this.ucIcon_UpdateSave = new WFA_SketchVerB.UCIcon_RoundBtn();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Trash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ShowthisImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnl_minus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_minus)).BeginInit();
            this.pnl_plus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_plus)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ShowthisName
            // 
            this.txt_ShowthisName.BackColor = System.Drawing.Color.White;
            this.txt_ShowthisName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ShowthisName.Enabled = false;
            this.txt_ShowthisName.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_ShowthisName.Location = new System.Drawing.Point(103, 17);
            this.txt_ShowthisName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ShowthisName.Multiline = true;
            this.txt_ShowthisName.Name = "txt_ShowthisName";
            this.txt_ShowthisName.ReadOnly = true;
            this.txt_ShowthisName.Size = new System.Drawing.Size(158, 41);
            this.txt_ShowthisName.TabIndex = 4;
            this.txt_ShowthisName.Text = "商品名稱";
            // 
            // pBox_Trash
            // 
            this.pBox_Trash.Image = global::WFA_SketchVerB.Properties.Resources.gtrash;
            this.pBox_Trash.Location = new System.Drawing.Point(328, 64);
            this.pBox_Trash.Name = "pBox_Trash";
            this.pBox_Trash.Size = new System.Drawing.Size(30, 30);
            this.pBox_Trash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox_Trash.TabIndex = 6;
            this.pBox_Trash.TabStop = false;
            this.pBox_Trash.Click += new System.EventHandler(this.pBox_Trash_Click);
            this.pBox_Trash.MouseEnter += new System.EventHandler(this.pBox_Trash_MouseEnter);
            this.pBox_Trash.MouseLeave += new System.EventHandler(this.pBox_Trash_MouseLeave);
            // 
            // pbox_ShowthisImage
            // 
            this.pbox_ShowthisImage.Image = global::WFA_SketchVerB.Properties.Resources.shopping_bag;
            this.pbox_ShowthisImage.Location = new System.Drawing.Point(22, 19);
            this.pbox_ShowthisImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbox_ShowthisImage.Name = "pbox_ShowthisImage";
            this.pbox_ShowthisImage.Size = new System.Drawing.Size(73, 75);
            this.pbox_ShowthisImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_ShowthisImage.TabIndex = 5;
            this.pbox_ShowthisImage.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnl_minus);
            this.panel2.Controls.Add(this.pnl_plus);
            this.panel2.Controls.Add(this.txt_Quant);
            this.panel2.Location = new System.Drawing.Point(141, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(105, 29);
            this.panel2.TabIndex = 8;
            // 
            // pnl_minus
            // 
            this.pnl_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnl_minus.Controls.Add(this.pbox_minus);
            this.pnl_minus.Location = new System.Drawing.Point(4, 1);
            this.pnl_minus.Name = "pnl_minus";
            this.pnl_minus.Padding = new System.Windows.Forms.Padding(3);
            this.pnl_minus.Size = new System.Drawing.Size(20, 25);
            this.pnl_minus.TabIndex = 4;
            this.pnl_minus.Click += new System.EventHandler(this.pnl_minus_Click);
            this.pnl_minus.MouseEnter += new System.EventHandler(this.pnl_MouseEnter);
            this.pnl_minus.MouseLeave += new System.EventHandler(this.pnl_MouseLeave);
            // 
            // pbox_minus
            // 
            this.pbox_minus.Image = global::WFA_SketchVerB.Properties.Resources.tinyminus;
            this.pbox_minus.Location = new System.Drawing.Point(3, 5);
            this.pbox_minus.Margin = new System.Windows.Forms.Padding(2);
            this.pbox_minus.Name = "pbox_minus";
            this.pbox_minus.Size = new System.Drawing.Size(15, 15);
            this.pbox_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_minus.TabIndex = 0;
            this.pbox_minus.TabStop = false;
            this.pbox_minus.Click += new System.EventHandler(this.pnl_minus_Click);
            this.pbox_minus.MouseEnter += new System.EventHandler(this.pbox_MouseEnter);
            // 
            // pnl_plus
            // 
            this.pnl_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnl_plus.Controls.Add(this.pbox_plus);
            this.pnl_plus.Location = new System.Drawing.Point(79, 1);
            this.pnl_plus.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_plus.Name = "pnl_plus";
            this.pnl_plus.Size = new System.Drawing.Size(20, 25);
            this.pnl_plus.TabIndex = 4;
            this.pnl_plus.Click += new System.EventHandler(this.pnl_plus_Click);
            this.pnl_plus.MouseEnter += new System.EventHandler(this.pnl_MouseEnter);
            this.pnl_plus.MouseLeave += new System.EventHandler(this.pnl_MouseLeave);
            // 
            // pbox_plus
            // 
            this.pbox_plus.Image = global::WFA_SketchVerB.Properties.Resources.tinyplus;
            this.pbox_plus.Location = new System.Drawing.Point(3, 5);
            this.pbox_plus.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.pbox_plus.Name = "pbox_plus";
            this.pbox_plus.Size = new System.Drawing.Size(15, 15);
            this.pbox_plus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_plus.TabIndex = 0;
            this.pbox_plus.TabStop = false;
            this.pbox_plus.Click += new System.EventHandler(this.pnl_plus_Click);
            this.pbox_plus.MouseEnter += new System.EventHandler(this.pbox_MouseEnter);
            // 
            // txt_Quant
            // 
            this.txt_Quant.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Quant.Location = new System.Drawing.Point(28, 2);
            this.txt_Quant.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.txt_Quant.Name = "txt_Quant";
            this.txt_Quant.Size = new System.Drawing.Size(46, 25);
            this.txt_Quant.TabIndex = 6;
            this.txt_Quant.Text = "1";
            this.txt_Quant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Quant.TextChanged += new System.EventHandler(this.txt_Quant_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 2);
            this.label1.TabIndex = 9;
            // 
            // lbl_ShowthisTot
            // 
            this.lbl_ShowthisTot.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_ShowthisTot.Location = new System.Drawing.Point(267, 17);
            this.lbl_ShowthisTot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ShowthisTot.Name = "lbl_ShowthisTot";
            this.lbl_ShowthisTot.Size = new System.Drawing.Size(108, 23);
            this.lbl_ShowthisTot.TabIndex = 10;
            this.lbl_ShowthisTot.Text = "(單品小計)";
            this.lbl_ShowthisTot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucIcon_UpdateSave
            // 
            this.ucIcon_UpdateSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucIcon_UpdateSave.BorderColor = System.Drawing.Color.Silver;
            this.ucIcon_UpdateSave.BorderRadius = 5;
            this.ucIcon_UpdateSave.BorderSize = 1;
            this.ucIcon_UpdateSave.EnableHoverEffect = true;
            this.ucIcon_UpdateSave.FlatAppearance.BorderSize = 0;
            this.ucIcon_UpdateSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucIcon_UpdateSave.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ucIcon_UpdateSave.ForeColor = System.Drawing.Color.Gray;
            this.ucIcon_UpdateSave.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ucIcon_UpdateSave.Location = new System.Drawing.Point(252, 66);
            this.ucIcon_UpdateSave.Name = "ucIcon_UpdateSave";
            this.ucIcon_UpdateSave.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucIcon_UpdateSave.Size = new System.Drawing.Size(70, 25);
            this.ucIcon_UpdateSave.TabIndex = 11;
            this.ucIcon_UpdateSave.Text = "確認修改";
            this.ucIcon_UpdateSave.UseVisualStyleBackColor = false;
            this.ucIcon_UpdateSave.Visible = false;
            this.ucIcon_UpdateSave.Click += new System.EventHandler(this.ucIcon_UpdateSave_Click);
            // 
            // UC_CartRowFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ucIcon_UpdateSave);
            this.Controls.Add(this.lbl_ShowthisTot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pBox_Trash);
            this.Controls.Add(this.pbox_ShowthisImage);
            this.Controls.Add(this.txt_ShowthisName);
            this.Name = "UC_CartRowFrame";
            this.Size = new System.Drawing.Size(385, 108);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Trash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ShowthisImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl_minus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_minus)).EndInit();
            this.pnl_plus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_plus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbox_ShowthisImage;
        public System.Windows.Forms.TextBox txt_ShowthisName;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel pnl_minus;
        public System.Windows.Forms.PictureBox pbox_minus;
        public System.Windows.Forms.Panel pnl_plus;
        public System.Windows.Forms.PictureBox pbox_plus;
        public System.Windows.Forms.TextBox txt_Quant;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pBox_Trash;
        public System.Windows.Forms.Label lbl_ShowthisTot;
        private UCIcon_RoundBtn ucIcon_UpdateSave;
    }
}
