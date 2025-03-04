namespace WFA_SketchVerB
{
    partial class Form_NewGoods
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
            this.lbl_TitleBar = new System.Windows.Forms.Label();
            this.btn_QuerySearch = new System.Windows.Forms.Button();
            this.txt_Query = new System.Windows.Forms.TextBox();
            this.cBox_QueryFieldChoose = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dGV_ItemsRow = new System.Windows.Forms.DataGridView();
            this.pBox_Primary = new System.Windows.Forms.PictureBox();
            this.lbl_Picture1 = new System.Windows.Forms.Label();
            this.lbl_Picture2 = new System.Windows.Forms.Label();
            this.pBox_Content1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nutrients = new System.Windows.Forms.TextBox();
            this.txt_Ingredient = new System.Windows.Forms.TextBox();
            this.txt_Intro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pBox_Content2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_ItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_IDShow = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.ucIcon_ShowAll = new WFA_SketchVerB.UCIcon_RoundBtn();
            this.ucIcon_Refresh = new WFA_SketchVerB.UCIcon_RoundBtn();
            this.ucIcon_AddGood = new WFA_SketchVerB.UCIcon_RoundBtn();
            this.ucIcon_Close = new WFA_SketchVerB.UCIcon_RoundBtn();
            this.txt_Brand = new System.Windows.Forms.TextBox();
            this.txt_Stock = new System.Windows.Forms.TextBox();
            this.ucIcon_Save = new WFA_SketchVerB.UCIcon_RoundBtn();
            this.ucIcon_CancelEdit = new WFA_SketchVerB.UCIcon_RoundBtn();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_Modecolor = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ItemsRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Primary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Content1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Content2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TitleBar
            // 
            this.lbl_TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_TitleBar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_TitleBar.ForeColor = System.Drawing.Color.White;
            this.lbl_TitleBar.Location = new System.Drawing.Point(0, 0);
            this.lbl_TitleBar.Name = "lbl_TitleBar";
            this.lbl_TitleBar.Size = new System.Drawing.Size(1440, 24);
            this.lbl_TitleBar.TabIndex = 4;
            this.lbl_TitleBar.Text = "商品管理系統";
            this.lbl_TitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_TitleBar_MouseDown);
            this.lbl_TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_TitleBar_MouseMove);
            this.lbl_TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_TitleBar_MouseUp);
            // 
            // btn_QuerySearch
            // 
            this.btn_QuerySearch.BackColor = System.Drawing.Color.White;
            this.btn_QuerySearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_QuerySearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_QuerySearch.Location = new System.Drawing.Point(130, 110);
            this.btn_QuerySearch.Name = "btn_QuerySearch";
            this.btn_QuerySearch.Size = new System.Drawing.Size(52, 29);
            this.btn_QuerySearch.TabIndex = 10;
            this.btn_QuerySearch.Text = "篩選";
            this.btn_QuerySearch.UseVisualStyleBackColor = false;
            this.btn_QuerySearch.Visible = false;
            // 
            // txt_Query
            // 
            this.txt_Query.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Query.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Query.Location = new System.Drawing.Point(19, 81);
            this.txt_Query.Name = "txt_Query";
            this.txt_Query.Size = new System.Drawing.Size(162, 29);
            this.txt_Query.TabIndex = 13;
            this.txt_Query.Visible = false;
            // 
            // cBox_QueryFieldChoose
            // 
            this.cBox_QueryFieldChoose.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBox_QueryFieldChoose.FormattingEnabled = true;
            this.cBox_QueryFieldChoose.Location = new System.Drawing.Point(19, 113);
            this.cBox_QueryFieldChoose.Name = "cBox_QueryFieldChoose";
            this.cBox_QueryFieldChoose.Size = new System.Drawing.Size(105, 28);
            this.cBox_QueryFieldChoose.TabIndex = 12;
            this.cBox_QueryFieldChoose.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(16, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 26);
            this.label9.TabIndex = 11;
            this.label9.Text = "Query";
            this.label9.Visible = false;
            // 
            // dGV_ItemsRow
            // 
            this.dGV_ItemsRow.BackgroundColor = System.Drawing.Color.White;
            this.dGV_ItemsRow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ItemsRow.Location = new System.Drawing.Point(16, 172);
            this.dGV_ItemsRow.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.dGV_ItemsRow.Name = "dGV_ItemsRow";
            this.dGV_ItemsRow.RowHeadersWidth = 51;
            this.dGV_ItemsRow.RowTemplate.Height = 24;
            this.dGV_ItemsRow.Size = new System.Drawing.Size(855, 509);
            this.dGV_ItemsRow.TabIndex = 18;
            this.dGV_ItemsRow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_ItemsRow_CellClick);
            // 
            // pBox_Primary
            // 
            this.pBox_Primary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_Primary.Location = new System.Drawing.Point(906, 99);
            this.pBox_Primary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pBox_Primary.Name = "pBox_Primary";
            this.pBox_Primary.Size = new System.Drawing.Size(175, 175);
            this.pBox_Primary.TabIndex = 19;
            this.pBox_Primary.TabStop = false;
            // 
            // lbl_Picture1
            // 
            this.lbl_Picture1.AutoSize = true;
            this.lbl_Picture1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Picture1.Location = new System.Drawing.Point(902, 73);
            this.lbl_Picture1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Picture1.Name = "lbl_Picture1";
            this.lbl_Picture1.Size = new System.Drawing.Size(86, 24);
            this.lbl_Picture1.TabIndex = 20;
            this.lbl_Picture1.Text = "商品主圖";
            // 
            // lbl_Picture2
            // 
            this.lbl_Picture2.AutoSize = true;
            this.lbl_Picture2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Picture2.Location = new System.Drawing.Point(902, 289);
            this.lbl_Picture2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Picture2.Name = "lbl_Picture2";
            this.lbl_Picture2.Size = new System.Drawing.Size(97, 24);
            this.lbl_Picture2.TabIndex = 20;
            this.lbl_Picture2.Text = "商品內圖1";
            // 
            // pBox_Content1
            // 
            this.pBox_Content1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_Content1.Location = new System.Drawing.Point(906, 314);
            this.pBox_Content1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pBox_Content1.Name = "pBox_Content1";
            this.pBox_Content1.Size = new System.Drawing.Size(175, 175);
            this.pBox_Content1.TabIndex = 19;
            this.pBox_Content1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(1109, 416);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(270, 45);
            this.panel6.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "成份";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(8, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 3);
            this.label8.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(1109, 568);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 45);
            this.panel5.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "營養分析";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(8, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 3);
            this.label6.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(1109, 259);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 45);
            this.panel4.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "簡介";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(8, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 3);
            this.label3.TabIndex = 7;
            // 
            // txt_Nutrients
            // 
            this.txt_Nutrients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nutrients.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Nutrients.Location = new System.Drawing.Point(1109, 619);
            this.txt_Nutrients.Multiline = true;
            this.txt_Nutrients.Name = "txt_Nutrients";
            this.txt_Nutrients.Size = new System.Drawing.Size(300, 80);
            this.txt_Nutrients.TabIndex = 22;
            this.txt_Nutrients.Text = "(營養分析)";
            // 
            // txt_Ingredient
            // 
            this.txt_Ingredient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Ingredient.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Ingredient.Location = new System.Drawing.Point(1109, 467);
            this.txt_Ingredient.Multiline = true;
            this.txt_Ingredient.Name = "txt_Ingredient";
            this.txt_Ingredient.Size = new System.Drawing.Size(300, 80);
            this.txt_Ingredient.TabIndex = 23;
            this.txt_Ingredient.Text = "(詳細成分)";
            // 
            // txt_Intro
            // 
            this.txt_Intro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Intro.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Intro.Location = new System.Drawing.Point(1109, 310);
            this.txt_Intro.Multiline = true;
            this.txt_Intro.Name = "txt_Intro";
            this.txt_Intro.Size = new System.Drawing.Size(300, 80);
            this.txt_Intro.TabIndex = 24;
            this.txt_Intro.Text = "(商品簡介)";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(884, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(3, 655);
            this.label1.TabIndex = 28;
            // 
            // pBox_Content2
            // 
            this.pBox_Content2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_Content2.Location = new System.Drawing.Point(906, 540);
            this.pBox_Content2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pBox_Content2.Name = "pBox_Content2";
            this.pBox_Content2.Size = new System.Drawing.Size(175, 175);
            this.pBox_Content2.TabIndex = 19;
            this.pBox_Content2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(902, 512);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "商品內圖2";
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ItemName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_ItemName.Location = new System.Drawing.Point(1109, 130);
            this.txt_ItemName.Multiline = true;
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.ReadOnly = true;
            this.txt_ItemName.Size = new System.Drawing.Size(158, 49);
            this.txt_ItemName.TabIndex = 30;
            this.txt_ItemName.Text = "(品名)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(901, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 26);
            this.label2.TabIndex = 29;
            this.label2.Text = "(上架時間)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(1103, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 26);
            this.label10.TabIndex = 29;
            this.label10.Text = "(最後更新)";
            // 
            // lbl_IDShow
            // 
            this.lbl_IDShow.AutoSize = true;
            this.lbl_IDShow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_IDShow.Location = new System.Drawing.Point(1107, 77);
            this.lbl_IDShow.Name = "lbl_IDShow";
            this.lbl_IDShow.Size = new System.Drawing.Size(43, 21);
            this.lbl_IDShow.TabIndex = 31;
            this.lbl_IDShow.Text = "ID：";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_ID.Location = new System.Drawing.Point(1146, 77);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(71, 21);
            this.lbl_ID.TabIndex = 32;
            this.lbl_ID.Text = "(商品ID)";
            // 
            // txt_Price
            // 
            this.txt_Price.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Price.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Price.Location = new System.Drawing.Point(1109, 215);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(100, 35);
            this.txt_Price.TabIndex = 33;
            // 
            // ucIcon_ShowAll
            // 
            this.ucIcon_ShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(156)))), ((int)(((byte)(211)))));
            this.ucIcon_ShowAll.BorderColor = System.Drawing.Color.Transparent;
            this.ucIcon_ShowAll.BorderRadius = 10;
            this.ucIcon_ShowAll.BorderSize = 1;
            this.ucIcon_ShowAll.EnableHoverEffect = true;
            this.ucIcon_ShowAll.FlatAppearance.BorderSize = 0;
            this.ucIcon_ShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucIcon_ShowAll.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ucIcon_ShowAll.ForeColor = System.Drawing.Color.White;
            this.ucIcon_ShowAll.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(115)))), ((int)(((byte)(220)))));
            this.ucIcon_ShowAll.Location = new System.Drawing.Point(196, 88);
            this.ucIcon_ShowAll.Name = "ucIcon_ShowAll";
            this.ucIcon_ShowAll.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(156)))), ((int)(((byte)(211)))));
            this.ucIcon_ShowAll.Size = new System.Drawing.Size(109, 40);
            this.ucIcon_ShowAll.TabIndex = 17;
            this.ucIcon_ShowAll.Text = "讀取現有商品";
            this.ucIcon_ShowAll.UseVisualStyleBackColor = false;
            this.ucIcon_ShowAll.Click += new System.EventHandler(this.ucIcon_ShowAll_Click);
            // 
            // ucIcon_Refresh
            // 
            this.ucIcon_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(156)))), ((int)(((byte)(211)))));
            this.ucIcon_Refresh.BorderColor = System.Drawing.Color.Transparent;
            this.ucIcon_Refresh.BorderRadius = 10;
            this.ucIcon_Refresh.BorderSize = 1;
            this.ucIcon_Refresh.EnableHoverEffect = true;
            this.ucIcon_Refresh.FlatAppearance.BorderSize = 0;
            this.ucIcon_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucIcon_Refresh.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ucIcon_Refresh.ForeColor = System.Drawing.Color.White;
            this.ucIcon_Refresh.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(115)))), ((int)(((byte)(220)))));
            this.ucIcon_Refresh.Location = new System.Drawing.Point(425, 88);
            this.ucIcon_Refresh.Name = "ucIcon_Refresh";
            this.ucIcon_Refresh.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(156)))), ((int)(((byte)(211)))));
            this.ucIcon_Refresh.Size = new System.Drawing.Size(87, 40);
            this.ucIcon_Refresh.TabIndex = 14;
            this.ucIcon_Refresh.Text = "重新整理";
            this.ucIcon_Refresh.UseVisualStyleBackColor = false;
            // 
            // ucIcon_AddGood
            // 
            this.ucIcon_AddGood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(168)))), ((int)(((byte)(85)))));
            this.ucIcon_AddGood.BorderColor = System.Drawing.Color.Transparent;
            this.ucIcon_AddGood.BorderRadius = 10;
            this.ucIcon_AddGood.BorderSize = 1;
            this.ucIcon_AddGood.EnableHoverEffect = true;
            this.ucIcon_AddGood.FlatAppearance.BorderSize = 0;
            this.ucIcon_AddGood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucIcon_AddGood.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ucIcon_AddGood.ForeColor = System.Drawing.Color.White;
            this.ucIcon_AddGood.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(34)))));
            this.ucIcon_AddGood.Location = new System.Drawing.Point(322, 88);
            this.ucIcon_AddGood.Name = "ucIcon_AddGood";
            this.ucIcon_AddGood.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(168)))), ((int)(((byte)(85)))));
            this.ucIcon_AddGood.Size = new System.Drawing.Size(87, 40);
            this.ucIcon_AddGood.TabIndex = 15;
            this.ucIcon_AddGood.Text = "新增商品";
            this.ucIcon_AddGood.UseVisualStyleBackColor = false;
            this.ucIcon_AddGood.Click += new System.EventHandler(this.ucIcon_AddGood_Click);
            // 
            // ucIcon_Close
            // 
            this.ucIcon_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucIcon_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ucIcon_Close.BorderColor = System.Drawing.Color.Transparent;
            this.ucIcon_Close.BorderRadius = 1;
            this.ucIcon_Close.BorderSize = 1;
            this.ucIcon_Close.EnableHoverEffect = true;
            this.ucIcon_Close.FlatAppearance.BorderSize = 0;
            this.ucIcon_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucIcon_Close.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ucIcon_Close.ForeColor = System.Drawing.Color.White;
            this.ucIcon_Close.HoverColor = System.Drawing.Color.DimGray;
            this.ucIcon_Close.Location = new System.Drawing.Point(1418, 0);
            this.ucIcon_Close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucIcon_Close.Name = "ucIcon_Close";
            this.ucIcon_Close.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ucIcon_Close.Size = new System.Drawing.Size(22, 24);
            this.ucIcon_Close.TabIndex = 9;
            this.ucIcon_Close.Text = "X";
            this.ucIcon_Close.UseVisualStyleBackColor = false;
            this.ucIcon_Close.Click += new System.EventHandler(this.ucIcon_Close_Click);
            // 
            // txt_Brand
            // 
            this.txt_Brand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Brand.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Brand.Location = new System.Drawing.Point(1273, 130);
            this.txt_Brand.Multiline = true;
            this.txt_Brand.Name = "txt_Brand";
            this.txt_Brand.ReadOnly = true;
            this.txt_Brand.Size = new System.Drawing.Size(122, 49);
            this.txt_Brand.TabIndex = 30;
            this.txt_Brand.Text = "(品牌)";
            // 
            // txt_Stock
            // 
            this.txt_Stock.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Stock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Stock.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Stock.Location = new System.Drawing.Point(1274, 214);
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.Size = new System.Drawing.Size(79, 35);
            this.txt_Stock.TabIndex = 33;
            // 
            // ucIcon_Save
            // 
            this.ucIcon_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(168)))), ((int)(((byte)(85)))));
            this.ucIcon_Save.BorderColor = System.Drawing.Color.DimGray;
            this.ucIcon_Save.BorderRadius = 8;
            this.ucIcon_Save.BorderSize = 2;
            this.ucIcon_Save.EnableHoverEffect = true;
            this.ucIcon_Save.FlatAppearance.BorderSize = 0;
            this.ucIcon_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucIcon_Save.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ucIcon_Save.ForeColor = System.Drawing.Color.White;
            this.ucIcon_Save.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(34)))));
            this.ucIcon_Save.Location = new System.Drawing.Point(1255, 62);
            this.ucIcon_Save.Name = "ucIcon_Save";
            this.ucIcon_Save.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(168)))), ((int)(((byte)(85)))));
            this.ucIcon_Save.Size = new System.Drawing.Size(80, 31);
            this.ucIcon_Save.TabIndex = 15;
            this.ucIcon_Save.Text = "確定新增";
            this.ucIcon_Save.UseVisualStyleBackColor = false;
            this.ucIcon_Save.Visible = false;
            this.ucIcon_Save.Click += new System.EventHandler(this.Btn_Confirm_Click);
            // 
            // ucIcon_CancelEdit
            // 
            this.ucIcon_CancelEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ucIcon_CancelEdit.BorderColor = System.Drawing.Color.DimGray;
            this.ucIcon_CancelEdit.BorderRadius = 8;
            this.ucIcon_CancelEdit.BorderSize = 2;
            this.ucIcon_CancelEdit.EnableHoverEffect = true;
            this.ucIcon_CancelEdit.FlatAppearance.BorderSize = 0;
            this.ucIcon_CancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucIcon_CancelEdit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ucIcon_CancelEdit.ForeColor = System.Drawing.Color.DimGray;
            this.ucIcon_CancelEdit.HoverColor = System.Drawing.Color.Silver;
            this.ucIcon_CancelEdit.Location = new System.Drawing.Point(1341, 62);
            this.ucIcon_CancelEdit.Name = "ucIcon_CancelEdit";
            this.ucIcon_CancelEdit.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ucIcon_CancelEdit.Size = new System.Drawing.Size(80, 31);
            this.ucIcon_CancelEdit.TabIndex = 34;
            this.ucIcon_CancelEdit.Text = "取消";
            this.ucIcon_CancelEdit.UseVisualStyleBackColor = false;
            this.ucIcon_CancelEdit.Visible = false;
            this.ucIcon_CancelEdit.Click += new System.EventHandler(this.ucIcon_CancelEdit_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(1107, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 21);
            this.label12.TabIndex = 31;
            this.label12.Text = "價格";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(1270, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 21);
            this.label13.TabIndex = 31;
            this.label13.Text = "庫存";
            // 
            // lbl_Modecolor
            // 
            this.lbl_Modecolor.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Modecolor.Location = new System.Drawing.Point(892, 40);
            this.lbl_Modecolor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Modecolor.Name = "lbl_Modecolor";
            this.lbl_Modecolor.Size = new System.Drawing.Size(538, 689);
            this.lbl_Modecolor.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(1110, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 21);
            this.label14.TabIndex = 31;
            this.label14.Text = "品名：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(1270, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 21);
            this.label15.TabIndex = 31;
            this.label15.Text = "品牌：";
            // 
            // Form_NewGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 736);
            this.Controls.Add(this.ucIcon_CancelEdit);
            this.Controls.Add(this.txt_Stock);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbl_IDShow);
            this.Controls.Add(this.txt_Brand);
            this.Controls.Add(this.txt_ItemName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txt_Nutrients);
            this.Controls.Add(this.txt_Ingredient);
            this.Controls.Add(this.txt_Intro);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl_Picture2);
            this.Controls.Add(this.pBox_Content2);
            this.Controls.Add(this.lbl_Picture1);
            this.Controls.Add(this.pBox_Content1);
            this.Controls.Add(this.pBox_Primary);
            this.Controls.Add(this.dGV_ItemsRow);
            this.Controls.Add(this.ucIcon_ShowAll);
            this.Controls.Add(this.ucIcon_Refresh);
            this.Controls.Add(this.ucIcon_Save);
            this.Controls.Add(this.ucIcon_AddGood);
            this.Controls.Add(this.btn_QuerySearch);
            this.Controls.Add(this.txt_Query);
            this.Controls.Add(this.cBox_QueryFieldChoose);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ucIcon_Close);
            this.Controls.Add(this.lbl_TitleBar);
            this.Controls.Add(this.lbl_Modecolor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_NewGoods";
            this.Text = "Form_NewGoods";
            this.Load += new System.EventHandler(this.Form_NewGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ItemsRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Primary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Content1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Content2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_TitleBar;
        private UCIcon_RoundBtn ucIcon_Close;
        private UCIcon_RoundBtn ucIcon_Refresh;
        private UCIcon_RoundBtn ucIcon_AddGood;
        private System.Windows.Forms.Button btn_QuerySearch;
        private System.Windows.Forms.TextBox txt_Query;
        private System.Windows.Forms.ComboBox cBox_QueryFieldChoose;
        private System.Windows.Forms.Label label9;
        private UCIcon_RoundBtn ucIcon_ShowAll;
        private System.Windows.Forms.DataGridView dGV_ItemsRow;
        private System.Windows.Forms.PictureBox pBox_Primary;
        private System.Windows.Forms.Label lbl_Picture1;
        private System.Windows.Forms.Label lbl_Picture2;
        private System.Windows.Forms.PictureBox pBox_Content1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nutrients;
        private System.Windows.Forms.TextBox txt_Ingredient;
        private System.Windows.Forms.TextBox txt_Intro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pBox_Content2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_ItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_IDShow;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Brand;
        private System.Windows.Forms.TextBox txt_Stock;
        private UCIcon_RoundBtn ucIcon_Save;
        private UCIcon_RoundBtn ucIcon_CancelEdit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_Modecolor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}