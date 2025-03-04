namespace WFA_SketchVerB
{
    partial class Form_TakeOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.fLP_OrderList = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_ItemNameField = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_PriceField = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_QuantField = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_TotField = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_OrderTot = new System.Windows.Forms.Label();
            this.txt_DeliveryAddress = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.chk_SameAddress = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnl_unMembermust = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnl_ItemNameField.SuspendLayout();
            this.pnl_PriceField.SuspendLayout();
            this.pnl_QuantField.SuspendLayout();
            this.pnl_TotField.SuspendLayout();
            this.pnl_unMembermust.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(0, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(810, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "訂單明細";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Close.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Close.Location = new System.Drawing.Point(749, 3);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(56, 34);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // fLP_OrderList
            // 
            this.fLP_OrderList.AutoScroll = true;
            this.fLP_OrderList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fLP_OrderList.Location = new System.Drawing.Point(25, 94);
            this.fLP_OrderList.Margin = new System.Windows.Forms.Padding(2);
            this.fLP_OrderList.Name = "fLP_OrderList";
            this.fLP_OrderList.Size = new System.Drawing.Size(758, 299);
            this.fLP_OrderList.TabIndex = 3;
            this.fLP_OrderList.WrapContents = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.pnl_ItemNameField);
            this.flowLayoutPanel1.Controls.Add(this.pnl_PriceField);
            this.flowLayoutPanel1.Controls.Add(this.pnl_QuantField);
            this.flowLayoutPanel1.Controls.Add(this.pnl_TotField);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 54);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(740, 40);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pnl_ItemNameField
            // 
            this.pnl_ItemNameField.Controls.Add(this.label2);
            this.pnl_ItemNameField.Location = new System.Drawing.Point(0, 0);
            this.pnl_ItemNameField.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_ItemNameField.Name = "pnl_ItemNameField";
            this.pnl_ItemNameField.Size = new System.Drawing.Size(319, 40);
            this.pnl_ItemNameField.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(2, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "商品";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_PriceField
            // 
            this.pnl_PriceField.Controls.Add(this.label3);
            this.pnl_PriceField.Location = new System.Drawing.Point(319, 0);
            this.pnl_PriceField.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_PriceField.Name = "pnl_PriceField";
            this.pnl_PriceField.Size = new System.Drawing.Size(133, 40);
            this.pnl_PriceField.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(2, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "價格";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_QuantField
            // 
            this.pnl_QuantField.Controls.Add(this.label4);
            this.pnl_QuantField.Location = new System.Drawing.Point(452, 0);
            this.pnl_QuantField.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_QuantField.Name = "pnl_QuantField";
            this.pnl_QuantField.Size = new System.Drawing.Size(122, 40);
            this.pnl_QuantField.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(2, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "數量";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_TotField
            // 
            this.pnl_TotField.Controls.Add(this.label5);
            this.pnl_TotField.Location = new System.Drawing.Point(574, 0);
            this.pnl_TotField.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_TotField.Name = "pnl_TotField";
            this.pnl_TotField.Size = new System.Drawing.Size(98, 40);
            this.pnl_TotField.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(2, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "小計";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Pay
            // 
            this.btn_Pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(249)))), ((int)(((byte)(230)))));
            this.btn_Pay.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Pay.Location = new System.Drawing.Point(652, 529);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(127, 50);
            this.btn_Pay.TabIndex = 4;
            this.btn_Pay.Text = "結帳付款";
            this.btn_Pay.UseVisualStyleBackColor = false;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            this.btn_Pay.MouseEnter += new System.EventHandler(this.btn_Pay_MouseEnter);
            this.btn_Pay.MouseLeave += new System.EventHandler(this.btn_Pay_MouseLeave);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_back.Font = new System.Drawing.Font("微軟正黑體 Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_back.ForeColor = System.Drawing.Color.Gray;
            this.btn_back.Location = new System.Drawing.Point(29, 534);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(133, 41);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "↩  繼續選購";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_Close_Click);
            this.btn_back.MouseEnter += new System.EventHandler(this.btn_back_MouseEnter);
            this.btn_back.MouseLeave += new System.EventHandler(this.btn_back_MouseLeave);
            // 
            // lbl_OrderTot
            // 
            this.lbl_OrderTot.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderTot.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_OrderTot.Location = new System.Drawing.Point(393, 535);
            this.lbl_OrderTot.Name = "lbl_OrderTot";
            this.lbl_OrderTot.Size = new System.Drawing.Size(253, 36);
            this.lbl_OrderTot.TabIndex = 6;
            this.lbl_OrderTot.Text = "$NT 9,999,999(已含運)";
            this.lbl_OrderTot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_DeliveryAddress
            // 
            this.txt_DeliveryAddress.BackColor = System.Drawing.Color.White;
            this.txt_DeliveryAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DeliveryAddress.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_DeliveryAddress.Location = new System.Drawing.Point(367, 436);
            this.txt_DeliveryAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txt_DeliveryAddress.Multiline = true;
            this.txt_DeliveryAddress.Name = "txt_DeliveryAddress";
            this.txt_DeliveryAddress.Size = new System.Drawing.Size(253, 82);
            this.txt_DeliveryAddress.TabIndex = 17;
            this.txt_DeliveryAddress.Text = "(地址)";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Address.Location = new System.Drawing.Point(366, 414);
            this.lbl_Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(74, 21);
            this.lbl_Address.TabIndex = 16;
            this.lbl_Address.Text = "宅配地址";
            // 
            // chk_SameAddress
            // 
            this.chk_SameAddress.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk_SameAddress.Location = new System.Drawing.Point(492, 413);
            this.chk_SameAddress.Name = "chk_SameAddress";
            this.chk_SameAddress.Size = new System.Drawing.Size(137, 24);
            this.chk_SameAddress.TabIndex = 18;
            this.chk_SameAddress.Text = "同會員通訊地址";
            this.chk_SameAddress.UseVisualStyleBackColor = true;
            this.chk_SameAddress.Visible = false;
            this.chk_SameAddress.CheckedChanged += new System.EventHandler(this.chk_SameAddress_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "信用卡付款",
            "電子支付",
            "貨到付款"});
            this.comboBox1.Location = new System.Drawing.Point(34, 438);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 32);
            this.comboBox1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(30, 415);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "付款方式";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(157, 415);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "取貨方式";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "超商取貨 運費：60",
            "宅配 運費：120"});
            this.comboBox2.Location = new System.Drawing.Point(161, 438);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(191, 32);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.Text = "超商取貨 運費：60";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(626, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 31);
            this.label9.TabIndex = 20;
            this.label9.Text = "運費：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(708, 420);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 31);
            this.label10.TabIndex = 20;
            this.label10.Text = "$60";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(3, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 24);
            this.label11.TabIndex = 21;
            this.label11.Text = "訂購人手機 (必填)";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(167, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 33);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "(09XXXXXXXX)";
            // 
            // pnl_unMembermust
            // 
            this.pnl_unMembermust.Controls.Add(this.textBox1);
            this.pnl_unMembermust.Controls.Add(this.label11);
            this.pnl_unMembermust.Location = new System.Drawing.Point(25, 476);
            this.pnl_unMembermust.Name = "pnl_unMembermust";
            this.pnl_unMembermust.Size = new System.Drawing.Size(331, 42);
            this.pnl_unMembermust.TabIndex = 23;
            this.pnl_unMembermust.Visible = false;
            // 
            // Form_TakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 584);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnl_unMembermust);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_DeliveryAddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbl_OrderTot);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_Pay);
            this.Controls.Add(this.fLP_OrderList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chk_SameAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_TakeOrder";
            this.Text = "Form_TakeOrder";
            this.Load += new System.EventHandler(this.Form_Cart_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnl_ItemNameField.ResumeLayout(false);
            this.pnl_PriceField.ResumeLayout(false);
            this.pnl_QuantField.ResumeLayout(false);
            this.pnl_TotField.ResumeLayout(false);
            this.pnl_unMembermust.ResumeLayout(false);
            this.pnl_unMembermust.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_ItemNameField;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnl_PriceField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl_QuantField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnl_TotField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_OrderTot;
        private System.Windows.Forms.TextBox txt_DeliveryAddress;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.CheckBox chk_SameAddress;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnl_unMembermust;
        public System.Windows.Forms.FlowLayoutPanel fLP_OrderList;
    }
}