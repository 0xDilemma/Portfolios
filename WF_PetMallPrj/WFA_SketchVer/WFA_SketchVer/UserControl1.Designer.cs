namespace WFA_SketchVer
{
    partial class UserControl1
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
            this.components = new System.ComponentModel.Container();
            this.listView_Goodshow = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList_GoodPicture = new System.Windows.Forms.ImageList(this.components);
            this.btn_AddtoCart = new System.Windows.Forms.Button();
            this.lbl_ResponShow = new System.Windows.Forms.Label();
            this.txt_ActualGoodCount = new System.Windows.Forms.TextBox();
            this.btn_MinusOne = new System.Windows.Forms.Button();
            this.btn_PlusOne = new System.Windows.Forms.Button();
            this.lbl_GoodTotPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView_Goodshow
            // 
            this.listView_Goodshow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listView_Goodshow.HideSelection = false;
            this.listView_Goodshow.Location = new System.Drawing.Point(38, 44);
            this.listView_Goodshow.MultiSelect = false;
            this.listView_Goodshow.Name = "listView_Goodshow";
            this.listView_Goodshow.Size = new System.Drawing.Size(454, 380);
            this.listView_Goodshow.TabIndex = 1;
            this.listView_Goodshow.UseCompatibleStateImageBehavior = false;
            this.listView_Goodshow.SelectedIndexChanged += new System.EventHandler(this.listView_Goodshow_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(72, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // imageList_GoodPicture
            // 
            this.imageList_GoodPicture.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_GoodPicture.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_GoodPicture.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn_AddtoCart
            // 
            this.btn_AddtoCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_AddtoCart.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_AddtoCart.Location = new System.Drawing.Point(506, 66);
            this.btn_AddtoCart.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddtoCart.Name = "btn_AddtoCart";
            this.btn_AddtoCart.Size = new System.Drawing.Size(125, 41);
            this.btn_AddtoCart.TabIndex = 3;
            this.btn_AddtoCart.Text = "Add to Cart";
            this.btn_AddtoCart.UseVisualStyleBackColor = false;
            this.btn_AddtoCart.Click += new System.EventHandler(this.btn_AddtoCart_Click);
            // 
            // lbl_ResponShow
            // 
            this.lbl_ResponShow.AutoSize = true;
            this.lbl_ResponShow.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_ResponShow.Location = new System.Drawing.Point(515, 130);
            this.lbl_ResponShow.Name = "lbl_ResponShow";
            this.lbl_ResponShow.Size = new System.Drawing.Size(116, 24);
            this.lbl_ResponShow.TabIndex = 4;
            this.lbl_ResponShow.Text = "Actual Item";
            // 
            // txt_ActualGoodCount
            // 
            this.txt_ActualGoodCount.Location = new System.Drawing.Point(519, 169);
            this.txt_ActualGoodCount.Name = "txt_ActualGoodCount";
            this.txt_ActualGoodCount.Size = new System.Drawing.Size(72, 22);
            this.txt_ActualGoodCount.TabIndex = 5;
            this.txt_ActualGoodCount.Text = "1";
            this.txt_ActualGoodCount.TextChanged += new System.EventHandler(this.txt_ActualGoodCount_TextChanged);
            // 
            // btn_MinusOne
            // 
            this.btn_MinusOne.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MinusOne.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_MinusOne.Location = new System.Drawing.Point(638, 168);
            this.btn_MinusOne.Name = "btn_MinusOne";
            this.btn_MinusOne.Size = new System.Drawing.Size(27, 23);
            this.btn_MinusOne.TabIndex = 7;
            this.btn_MinusOne.Text = "-";
            this.btn_MinusOne.UseVisualStyleBackColor = true;
            this.btn_MinusOne.Click += new System.EventHandler(this.btn_MinusOne_Click);
            // 
            // btn_PlusOne
            // 
            this.btn_PlusOne.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlusOne.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_PlusOne.Location = new System.Drawing.Point(605, 168);
            this.btn_PlusOne.Name = "btn_PlusOne";
            this.btn_PlusOne.Size = new System.Drawing.Size(27, 23);
            this.btn_PlusOne.TabIndex = 8;
            this.btn_PlusOne.Text = "+";
            this.btn_PlusOne.UseVisualStyleBackColor = true;
            this.btn_PlusOne.Click += new System.EventHandler(this.btn_PlusOne_Click);
            // 
            // lbl_GoodTotPrice
            // 
            this.lbl_GoodTotPrice.AutoSize = true;
            this.lbl_GoodTotPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_GoodTotPrice.Location = new System.Drawing.Point(516, 209);
            this.lbl_GoodTotPrice.Name = "lbl_GoodTotPrice";
            this.lbl_GoodTotPrice.Size = new System.Drawing.Size(67, 24);
            this.lbl_GoodTotPrice.TabIndex = 4;
            this.lbl_GoodTotPrice.Text = "小計：";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btn_MinusOne);
            this.Controls.Add(this.btn_PlusOne);
            this.Controls.Add(this.txt_ActualGoodCount);
            this.Controls.Add(this.lbl_GoodTotPrice);
            this.Controls.Add(this.lbl_ResponShow);
            this.Controls.Add(this.btn_AddtoCart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_Goodshow);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(720, 480);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView_Goodshow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList_GoodPicture;
        private System.Windows.Forms.Button btn_AddtoCart;
        private System.Windows.Forms.Label lbl_ResponShow;
        private System.Windows.Forms.TextBox txt_ActualGoodCount;
        private System.Windows.Forms.Button btn_MinusOne;
        private System.Windows.Forms.Button btn_PlusOne;
        private System.Windows.Forms.Label lbl_GoodTotPrice;
    }
}
