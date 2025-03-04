namespace WFA_SketchVerB
{
    partial class UC_Cart
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
            this.lbl_Top = new System.Windows.Forms.Label();
            this.lbl_bot = new System.Windows.Forms.Label();
            this.lbl_left = new System.Windows.Forms.Label();
            this.lbl_right = new System.Windows.Forms.Label();
            this.fLP_OrderList = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_OrderTot = new System.Windows.Forms.Label();
            this.ucIcon_RoundBtn1 = new WFA_SketchVerB.UCIcon_RoundBtn();
            this.ucIcon_TakeOrder = new WFA_SketchVerB.UCIcon_RoundBtn();
            this.SuspendLayout();
            // 
            // lbl_Top
            // 
            this.lbl_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Top.Location = new System.Drawing.Point(0, 0);
            this.lbl_Top.Name = "lbl_Top";
            this.lbl_Top.Size = new System.Drawing.Size(425, 2);
            this.lbl_Top.TabIndex = 0;
            // 
            // lbl_bot
            // 
            this.lbl_bot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_bot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_bot.Location = new System.Drawing.Point(0, 445);
            this.lbl_bot.Name = "lbl_bot";
            this.lbl_bot.Size = new System.Drawing.Size(425, 2);
            this.lbl_bot.TabIndex = 1;
            // 
            // lbl_left
            // 
            this.lbl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_left.Location = new System.Drawing.Point(0, 2);
            this.lbl_left.Name = "lbl_left";
            this.lbl_left.Size = new System.Drawing.Size(2, 443);
            this.lbl_left.TabIndex = 2;
            // 
            // lbl_right
            // 
            this.lbl_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_right.Location = new System.Drawing.Point(423, 2);
            this.lbl_right.Name = "lbl_right";
            this.lbl_right.Size = new System.Drawing.Size(2, 443);
            this.lbl_right.TabIndex = 3;
            // 
            // fLP_OrderList
            // 
            this.fLP_OrderList.AutoScroll = true;
            this.fLP_OrderList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fLP_OrderList.Location = new System.Drawing.Point(8, 7);
            this.fLP_OrderList.Margin = new System.Windows.Forms.Padding(2);
            this.fLP_OrderList.Name = "fLP_OrderList";
            this.fLP_OrderList.Size = new System.Drawing.Size(410, 352);
            this.fLP_OrderList.TabIndex = 4;
            this.fLP_OrderList.WrapContents = false;
            // 
            // lbl_OrderTot
            // 
            this.lbl_OrderTot.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderTot.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_OrderTot.Location = new System.Drawing.Point(145, 386);
            this.lbl_OrderTot.Name = "lbl_OrderTot";
            this.lbl_OrderTot.Size = new System.Drawing.Size(147, 36);
            this.lbl_OrderTot.TabIndex = 7;
            this.lbl_OrderTot.Text = "NT$ ";
            this.lbl_OrderTot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucIcon_RoundBtn1
            // 
            this.ucIcon_RoundBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ucIcon_RoundBtn1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ucIcon_RoundBtn1.BorderRadius = 10;
            this.ucIcon_RoundBtn1.BorderSize = 1;
            this.ucIcon_RoundBtn1.EnableHoverEffect = true;
            this.ucIcon_RoundBtn1.FlatAppearance.BorderSize = 0;
            this.ucIcon_RoundBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucIcon_RoundBtn1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ucIcon_RoundBtn1.ForeColor = System.Drawing.Color.White;
            this.ucIcon_RoundBtn1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ucIcon_RoundBtn1.Location = new System.Drawing.Point(13, 384);
            this.ucIcon_RoundBtn1.Name = "ucIcon_RoundBtn1";
            this.ucIcon_RoundBtn1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ucIcon_RoundBtn1.Size = new System.Drawing.Size(73, 40);
            this.ucIcon_RoundBtn1.TabIndex = 5;
            this.ucIcon_RoundBtn1.Text = "收起";
            this.ucIcon_RoundBtn1.UseVisualStyleBackColor = false;
            this.ucIcon_RoundBtn1.Click += new System.EventHandler(this.ucIcon_RoundBtn1_Click);
            // 
            // ucIcon_TakeOrder
            // 
            this.ucIcon_TakeOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ucIcon_TakeOrder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ucIcon_TakeOrder.BorderRadius = 10;
            this.ucIcon_TakeOrder.BorderSize = 1;
            this.ucIcon_TakeOrder.EnableHoverEffect = true;
            this.ucIcon_TakeOrder.FlatAppearance.BorderSize = 0;
            this.ucIcon_TakeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucIcon_TakeOrder.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ucIcon_TakeOrder.ForeColor = System.Drawing.Color.White;
            this.ucIcon_TakeOrder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ucIcon_TakeOrder.Location = new System.Drawing.Point(296, 384);
            this.ucIcon_TakeOrder.Name = "ucIcon_TakeOrder";
            this.ucIcon_TakeOrder.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ucIcon_TakeOrder.Size = new System.Drawing.Size(109, 40);
            this.ucIcon_TakeOrder.TabIndex = 5;
            this.ucIcon_TakeOrder.Text = "前往結帳";
            this.ucIcon_TakeOrder.UseVisualStyleBackColor = false;
            this.ucIcon_TakeOrder.Click += new System.EventHandler(this.ucIcon_TakeOrder_Click);
            // 
            // UC_Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_OrderTot);
            this.Controls.Add(this.ucIcon_RoundBtn1);
            this.Controls.Add(this.ucIcon_TakeOrder);
            this.Controls.Add(this.fLP_OrderList);
            this.Controls.Add(this.lbl_right);
            this.Controls.Add(this.lbl_left);
            this.Controls.Add(this.lbl_bot);
            this.Controls.Add(this.lbl_Top);
            this.Name = "UC_Cart";
            this.Size = new System.Drawing.Size(425, 447);
            this.Load += new System.EventHandler(this.UC_Cart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Top;
        private System.Windows.Forms.Label lbl_bot;
        private System.Windows.Forms.Label lbl_left;
        private System.Windows.Forms.Label lbl_right;
        private UCIcon_RoundBtn ucIcon_TakeOrder;
        private UCIcon_RoundBtn ucIcon_RoundBtn1;
        private System.Windows.Forms.Label lbl_OrderTot;
        public System.Windows.Forms.FlowLayoutPanel fLP_OrderList;
    }
}
