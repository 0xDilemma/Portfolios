namespace WFA_SketchVerB
{
    partial class UserControl_ItemsShow
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
            this.label1 = new System.Windows.Forms.Label();
            this.imageList_GoodPicture = new System.Windows.Forms.ImageList(this.components);
            this.btn_MinusOne = new System.Windows.Forms.Button();
            this.btn_PlusOne = new System.Windows.Forms.Button();
            this.txt_ActualGoodCount = new System.Windows.Forms.TextBox();
            this.lbl_GoodTotPrice = new System.Windows.Forms.Label();
            this.lbl_ResponShow = new System.Windows.Forms.Label();
            this.btn_AddtoCart = new System.Windows.Forms.Button();
            this.flowLayoutPanel_GoodList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(101, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // imageList_GoodPicture
            // 
            this.imageList_GoodPicture.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_GoodPicture.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_GoodPicture.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn_MinusOne
            // 
            this.btn_MinusOne.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MinusOne.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_MinusOne.Location = new System.Drawing.Point(856, 219);
            this.btn_MinusOne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_MinusOne.Name = "btn_MinusOne";
            this.btn_MinusOne.Size = new System.Drawing.Size(36, 29);
            this.btn_MinusOne.TabIndex = 15;
            this.btn_MinusOne.Text = "-";
            this.btn_MinusOne.UseVisualStyleBackColor = true;
            // 
            // btn_PlusOne
            // 
            this.btn_PlusOne.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlusOne.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_PlusOne.Location = new System.Drawing.Point(812, 219);
            this.btn_PlusOne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_PlusOne.Name = "btn_PlusOne";
            this.btn_PlusOne.Size = new System.Drawing.Size(36, 29);
            this.btn_PlusOne.TabIndex = 16;
            this.btn_PlusOne.Text = "+";
            this.btn_PlusOne.UseVisualStyleBackColor = true;
            // 
            // txt_ActualGoodCount
            // 
            this.txt_ActualGoodCount.Location = new System.Drawing.Point(697, 220);
            this.txt_ActualGoodCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ActualGoodCount.Name = "txt_ActualGoodCount";
            this.txt_ActualGoodCount.Size = new System.Drawing.Size(95, 25);
            this.txt_ActualGoodCount.TabIndex = 14;
            this.txt_ActualGoodCount.Text = "1";
            // 
            // lbl_GoodTotPrice
            // 
            this.lbl_GoodTotPrice.AutoSize = true;
            this.lbl_GoodTotPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_GoodTotPrice.Location = new System.Drawing.Point(693, 270);
            this.lbl_GoodTotPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_GoodTotPrice.Name = "lbl_GoodTotPrice";
            this.lbl_GoodTotPrice.Size = new System.Drawing.Size(86, 31);
            this.lbl_GoodTotPrice.TabIndex = 12;
            this.lbl_GoodTotPrice.Text = "小計：";
            // 
            // lbl_ResponShow
            // 
            this.lbl_ResponShow.AutoSize = true;
            this.lbl_ResponShow.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_ResponShow.Location = new System.Drawing.Point(692, 171);
            this.lbl_ResponShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ResponShow.Name = "lbl_ResponShow";
            this.lbl_ResponShow.Size = new System.Drawing.Size(146, 31);
            this.lbl_ResponShow.TabIndex = 13;
            this.lbl_ResponShow.Text = "Actual Item";
            // 
            // btn_AddtoCart
            // 
            this.btn_AddtoCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_AddtoCart.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_AddtoCart.Location = new System.Drawing.Point(680, 91);
            this.btn_AddtoCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddtoCart.Name = "btn_AddtoCart";
            this.btn_AddtoCart.Size = new System.Drawing.Size(167, 51);
            this.btn_AddtoCart.TabIndex = 11;
            this.btn_AddtoCart.Text = "Add to Cart";
            this.btn_AddtoCart.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel_GoodList
            // 
            this.flowLayoutPanel_GoodList.AutoScroll = true;
            this.flowLayoutPanel_GoodList.Location = new System.Drawing.Point(59, 91);
            this.flowLayoutPanel_GoodList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel_GoodList.Name = "flowLayoutPanel_GoodList";
            this.flowLayoutPanel_GoodList.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel_GoodList.Size = new System.Drawing.Size(565, 460);
            this.flowLayoutPanel_GoodList.TabIndex = 17;
            // 
            // UserControl_ItemsShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.flowLayoutPanel_GoodList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_MinusOne);
            this.Controls.Add(this.btn_PlusOne);
            this.Controls.Add(this.txt_ActualGoodCount);
            this.Controls.Add(this.lbl_GoodTotPrice);
            this.Controls.Add(this.lbl_ResponShow);
            this.Controls.Add(this.btn_AddtoCart);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControl_ItemsShow";
            this.Size = new System.Drawing.Size(947, 569);
            this.Load += new System.EventHandler(this.UserControl_ItemsShow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList_GoodPicture;
        private System.Windows.Forms.Button btn_MinusOne;
        private System.Windows.Forms.Button btn_PlusOne;
        private System.Windows.Forms.TextBox txt_ActualGoodCount;
        private System.Windows.Forms.Label lbl_GoodTotPrice;
        private System.Windows.Forms.Label lbl_ResponShow;
        private System.Windows.Forms.Button btn_AddtoCart;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_GoodList;
    }
}
