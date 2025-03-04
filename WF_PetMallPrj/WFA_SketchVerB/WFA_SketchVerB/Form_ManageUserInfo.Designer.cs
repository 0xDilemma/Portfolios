namespace WFA_SketchVerB
{
    partial class Form_ManageUserInfo
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
            this.btn_QuerySearch = new System.Windows.Forms.Button();
            this.txt_Query = new System.Windows.Forms.TextBox();
            this.cBox_QueryFieldChoose = new System.Windows.Forms.ComboBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dGV_membersRow = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gBox_DetailInfo = new System.Windows.Forms.GroupBox();
            this.ucIcon_CancelEdit = new WFA_SketchVerB.UCIcon_RoundBtn();
            this.ucIcon_SaveInfo = new WFA_SketchVerB.UCIcon_RoundBtn();
            this.txt_UserRole = new System.Windows.Forms.TextBox();
            this.txt_Pwd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ucIcon_ShowAll = new WFA_SketchVerB.UCIcon_RoundBtn();
            this.ucIcon_LinkTest = new WFA_SketchVerB.UCIcon_RoundBtn();
            this.ucIcon_AddMember = new WFA_SketchVerB.UCIcon_RoundBtn();
            this.ucIcon_Refresh = new WFA_SketchVerB.UCIcon_RoundBtn();
            this.lbl_TitleBar = new System.Windows.Forms.Label();
            this.ucIcon_RoundBtn1 = new WFA_SketchVerB.UCIcon_RoundBtn();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_membersRow)).BeginInit();
            this.gBox_DetailInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_QuerySearch
            // 
            this.btn_QuerySearch.BackColor = System.Drawing.Color.White;
            this.btn_QuerySearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_QuerySearch.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_QuerySearch.Location = new System.Drawing.Point(180, 119);
            this.btn_QuerySearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_QuerySearch.Name = "btn_QuerySearch";
            this.btn_QuerySearch.Size = new System.Drawing.Size(69, 36);
            this.btn_QuerySearch.TabIndex = 0;
            this.btn_QuerySearch.Text = "搜尋";
            this.btn_QuerySearch.UseVisualStyleBackColor = false;
            this.btn_QuerySearch.Click += new System.EventHandler(this.btn_QuerySearch_Click);
            // 
            // txt_Query
            // 
            this.txt_Query.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Query.Location = new System.Drawing.Point(31, 79);
            this.txt_Query.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Query.Name = "txt_Query";
            this.txt_Query.Size = new System.Drawing.Size(216, 34);
            this.txt_Query.TabIndex = 2;
            // 
            // cBox_QueryFieldChoose
            // 
            this.cBox_QueryFieldChoose.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBox_QueryFieldChoose.FormattingEnabled = true;
            this.cBox_QueryFieldChoose.Location = new System.Drawing.Point(31, 119);
            this.cBox_QueryFieldChoose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBox_QueryFieldChoose.Name = "cBox_QueryFieldChoose";
            this.cBox_QueryFieldChoose.Size = new System.Drawing.Size(139, 33);
            this.cBox_QueryFieldChoose.TabIndex = 1;
            // 
            // txt_Address
            // 
            this.txt_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Address.Enabled = false;
            this.txt_Address.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Address.Location = new System.Drawing.Point(99, 235);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(216, 20);
            this.txt_Address.TabIndex = 13;
            // 
            // txt_Name
            // 
            this.txt_Name.Enabled = false;
            this.txt_Name.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Name.Location = new System.Drawing.Point(99, 128);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(215, 27);
            this.txt_Name.TabIndex = 14;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Enabled = false;
            this.txt_Phone.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Phone.Location = new System.Drawing.Point(99, 181);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(215, 27);
            this.txt_Phone.TabIndex = 15;
            // 
            // txt_Email
            // 
            this.txt_Email.Enabled = false;
            this.txt_Email.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Email.Location = new System.Drawing.Point(99, 289);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(215, 27);
            this.txt_Email.TabIndex = 16;
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_ID.Location = new System.Drawing.Point(99, 74);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(215, 27);
            this.txt_ID.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(17, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "電話";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(17, 290);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(23, 49);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "關鍵字搜尋";
            // 
            // dGV_membersRow
            // 
            this.dGV_membersRow.BackgroundColor = System.Drawing.Color.White;
            this.dGV_membersRow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_membersRow.Location = new System.Drawing.Point(267, 45);
            this.dGV_membersRow.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.dGV_membersRow.Name = "dGV_membersRow";
            this.dGV_membersRow.RowHeadersWidth = 51;
            this.dGV_membersRow.RowTemplate.Height = 24;
            this.dGV_membersRow.Size = new System.Drawing.Size(908, 636);
            this.dGV_membersRow.TabIndex = 0;
            this.dGV_membersRow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_membersRow_CellClick_ShowtoBox);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(17, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(17, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "地址";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(17, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // gBox_DetailInfo
            // 
            this.gBox_DetailInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.gBox_DetailInfo.Controls.Add(this.ucIcon_CancelEdit);
            this.gBox_DetailInfo.Controls.Add(this.ucIcon_SaveInfo);
            this.gBox_DetailInfo.Controls.Add(this.txt_Address);
            this.gBox_DetailInfo.Controls.Add(this.txt_Name);
            this.gBox_DetailInfo.Controls.Add(this.txt_Phone);
            this.gBox_DetailInfo.Controls.Add(this.txt_UserRole);
            this.gBox_DetailInfo.Controls.Add(this.txt_Pwd);
            this.gBox_DetailInfo.Controls.Add(this.txt_Email);
            this.gBox_DetailInfo.Controls.Add(this.txt_ID);
            this.gBox_DetailInfo.Controls.Add(this.label6);
            this.gBox_DetailInfo.Controls.Add(this.label7);
            this.gBox_DetailInfo.Controls.Add(this.label3);
            this.gBox_DetailInfo.Controls.Add(this.label5);
            this.gBox_DetailInfo.Controls.Add(this.label2);
            this.gBox_DetailInfo.Controls.Add(this.label4);
            this.gBox_DetailInfo.Controls.Add(this.label1);
            this.gBox_DetailInfo.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gBox_DetailInfo.Location = new System.Drawing.Point(1183, 45);
            this.gBox_DetailInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBox_DetailInfo.Name = "gBox_DetailInfo";
            this.gBox_DetailInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBox_DetailInfo.Size = new System.Drawing.Size(328, 496);
            this.gBox_DetailInfo.TabIndex = 3;
            this.gBox_DetailInfo.TabStop = false;
            this.gBox_DetailInfo.Text = "詳細資料(唯讀)";
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
            this.ucIcon_CancelEdit.Location = new System.Drawing.Point(45, 445);
            this.ucIcon_CancelEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucIcon_CancelEdit.Name = "ucIcon_CancelEdit";
            this.ucIcon_CancelEdit.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ucIcon_CancelEdit.Size = new System.Drawing.Size(107, 39);
            this.ucIcon_CancelEdit.TabIndex = 18;
            this.ucIcon_CancelEdit.Text = "取消";
            this.ucIcon_CancelEdit.UseVisualStyleBackColor = false;
            this.ucIcon_CancelEdit.Visible = false;
            this.ucIcon_CancelEdit.Click += new System.EventHandler(this.ucIcon_CancelEdit_Click);
            // 
            // ucIcon_SaveInfo
            // 
            this.ucIcon_SaveInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(156)))), ((int)(((byte)(211)))));
            this.ucIcon_SaveInfo.BorderColor = System.Drawing.Color.White;
            this.ucIcon_SaveInfo.BorderRadius = 8;
            this.ucIcon_SaveInfo.BorderSize = 2;
            this.ucIcon_SaveInfo.EnableHoverEffect = true;
            this.ucIcon_SaveInfo.FlatAppearance.BorderSize = 0;
            this.ucIcon_SaveInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucIcon_SaveInfo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ucIcon_SaveInfo.ForeColor = System.Drawing.Color.White;
            this.ucIcon_SaveInfo.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(115)))), ((int)(((byte)(220)))));
            this.ucIcon_SaveInfo.Location = new System.Drawing.Point(207, 445);
            this.ucIcon_SaveInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucIcon_SaveInfo.Name = "ucIcon_SaveInfo";
            this.ucIcon_SaveInfo.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(156)))), ((int)(((byte)(211)))));
            this.ucIcon_SaveInfo.Size = new System.Drawing.Size(107, 39);
            this.ucIcon_SaveInfo.TabIndex = 18;
            this.ucIcon_SaveInfo.Text = "保存";
            this.ucIcon_SaveInfo.UseVisualStyleBackColor = false;
            this.ucIcon_SaveInfo.Visible = false;
            this.ucIcon_SaveInfo.Click += new System.EventHandler(this.ucIcon_SaveInfo_Click);
            // 
            // txt_UserRole
            // 
            this.txt_UserRole.Enabled = false;
            this.txt_UserRole.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_UserRole.Location = new System.Drawing.Point(141, 398);
            this.txt_UserRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_UserRole.Name = "txt_UserRole";
            this.txt_UserRole.Size = new System.Drawing.Size(172, 27);
            this.txt_UserRole.TabIndex = 16;
            // 
            // txt_Pwd
            // 
            this.txt_Pwd.Enabled = false;
            this.txt_Pwd.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Pwd.Location = new System.Drawing.Point(99, 338);
            this.txt_Pwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Pwd.Name = "txt_Pwd";
            this.txt_Pwd.Size = new System.Drawing.Size(215, 27);
            this.txt_Pwd.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(17, 399);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "權限代號";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(17, 339);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Pwd";
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
            this.ucIcon_ShowAll.Location = new System.Drawing.Point(601, 689);
            this.ucIcon_ShowAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucIcon_ShowAll.Name = "ucIcon_ShowAll";
            this.ucIcon_ShowAll.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(156)))), ((int)(((byte)(211)))));
            this.ucIcon_ShowAll.Size = new System.Drawing.Size(240, 50);
            this.ucIcon_ShowAll.TabIndex = 5;
            this.ucIcon_ShowAll.Text = "讀取會員資料";
            this.ucIcon_ShowAll.UseVisualStyleBackColor = false;
            this.ucIcon_ShowAll.Click += new System.EventHandler(this.ucIcon_ShowAll_Click);
            // 
            // ucIcon_LinkTest
            // 
            this.ucIcon_LinkTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(156)))), ((int)(((byte)(211)))));
            this.ucIcon_LinkTest.BorderColor = System.Drawing.Color.Transparent;
            this.ucIcon_LinkTest.BorderRadius = 10;
            this.ucIcon_LinkTest.BorderSize = 1;
            this.ucIcon_LinkTest.EnableHoverEffect = true;
            this.ucIcon_LinkTest.FlatAppearance.BorderSize = 0;
            this.ucIcon_LinkTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucIcon_LinkTest.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ucIcon_LinkTest.ForeColor = System.Drawing.Color.White;
            this.ucIcon_LinkTest.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(115)))), ((int)(((byte)(220)))));
            this.ucIcon_LinkTest.Location = new System.Drawing.Point(85, 174);
            this.ucIcon_LinkTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucIcon_LinkTest.Name = "ucIcon_LinkTest";
            this.ucIcon_LinkTest.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(156)))), ((int)(((byte)(211)))));
            this.ucIcon_LinkTest.Size = new System.Drawing.Size(116, 50);
            this.ucIcon_LinkTest.TabIndex = 6;
            this.ucIcon_LinkTest.Text = "連線測試";
            this.ucIcon_LinkTest.UseVisualStyleBackColor = false;
            this.ucIcon_LinkTest.Click += new System.EventHandler(this.btn_LinkTest_Click);
            // 
            // ucIcon_AddMember
            // 
            this.ucIcon_AddMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(168)))), ((int)(((byte)(85)))));
            this.ucIcon_AddMember.BorderColor = System.Drawing.Color.Transparent;
            this.ucIcon_AddMember.BorderRadius = 10;
            this.ucIcon_AddMember.BorderSize = 1;
            this.ucIcon_AddMember.EnableHoverEffect = true;
            this.ucIcon_AddMember.FlatAppearance.BorderSize = 0;
            this.ucIcon_AddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucIcon_AddMember.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ucIcon_AddMember.ForeColor = System.Drawing.Color.White;
            this.ucIcon_AddMember.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(34)))));
            this.ucIcon_AddMember.Location = new System.Drawing.Point(85, 243);
            this.ucIcon_AddMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucIcon_AddMember.Name = "ucIcon_AddMember";
            this.ucIcon_AddMember.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(168)))), ((int)(((byte)(85)))));
            this.ucIcon_AddMember.Size = new System.Drawing.Size(116, 50);
            this.ucIcon_AddMember.TabIndex = 6;
            this.ucIcon_AddMember.Text = "新增資料";
            this.ucIcon_AddMember.UseVisualStyleBackColor = false;
            this.ucIcon_AddMember.Click += new System.EventHandler(this.ucIcon_AddMember_Click);
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
            this.ucIcon_Refresh.Location = new System.Drawing.Point(85, 311);
            this.ucIcon_Refresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucIcon_Refresh.Name = "ucIcon_Refresh";
            this.ucIcon_Refresh.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(156)))), ((int)(((byte)(211)))));
            this.ucIcon_Refresh.Size = new System.Drawing.Size(116, 50);
            this.ucIcon_Refresh.TabIndex = 6;
            this.ucIcon_Refresh.Text = "重新整理";
            this.ucIcon_Refresh.UseVisualStyleBackColor = false;
            this.ucIcon_Refresh.Click += new System.EventHandler(this.ucIcon_Refresh_Click);
            // 
            // lbl_TitleBar
            // 
            this.lbl_TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_TitleBar.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_TitleBar.ForeColor = System.Drawing.Color.White;
            this.lbl_TitleBar.Location = new System.Drawing.Point(0, 0);
            this.lbl_TitleBar.Name = "lbl_TitleBar";
            this.lbl_TitleBar.Size = new System.Drawing.Size(1537, 30);
            this.lbl_TitleBar.TabIndex = 7;
            this.lbl_TitleBar.Text = "會員資料管理";
            this.lbl_TitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_TitleBar_MouseDown);
            this.lbl_TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_TitleBar_MouseMove);
            this.lbl_TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_TitleBar_MouseUp);
            // 
            // ucIcon_RoundBtn1
            // 
            this.ucIcon_RoundBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ucIcon_RoundBtn1.BorderColor = System.Drawing.Color.Transparent;
            this.ucIcon_RoundBtn1.BorderRadius = 1;
            this.ucIcon_RoundBtn1.BorderSize = 1;
            this.ucIcon_RoundBtn1.EnableHoverEffect = true;
            this.ucIcon_RoundBtn1.FlatAppearance.BorderSize = 0;
            this.ucIcon_RoundBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucIcon_RoundBtn1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ucIcon_RoundBtn1.ForeColor = System.Drawing.Color.White;
            this.ucIcon_RoundBtn1.HoverColor = System.Drawing.Color.DimGray;
            this.ucIcon_RoundBtn1.Location = new System.Drawing.Point(1505, 0);
            this.ucIcon_RoundBtn1.Name = "ucIcon_RoundBtn1";
            this.ucIcon_RoundBtn1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ucIcon_RoundBtn1.Size = new System.Drawing.Size(32, 30);
            this.ucIcon_RoundBtn1.TabIndex = 8;
            this.ucIcon_RoundBtn1.Text = "X";
            this.ucIcon_RoundBtn1.UseVisualStyleBackColor = false;
            this.ucIcon_RoundBtn1.Click += new System.EventHandler(this.ucIcon_RoundBtn1_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(2, 759);
            this.label10.TabIndex = 9;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(1535, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(2, 759);
            this.label11.TabIndex = 9;
            this.label11.Text = "label10";
            // 
            // Form_ManageUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1537, 759);
            this.Controls.Add(this.ucIcon_RoundBtn1);
            this.Controls.Add(this.ucIcon_Refresh);
            this.Controls.Add(this.ucIcon_AddMember);
            this.Controls.Add(this.ucIcon_LinkTest);
            this.Controls.Add(this.ucIcon_ShowAll);
            this.Controls.Add(this.btn_QuerySearch);
            this.Controls.Add(this.txt_Query);
            this.Controls.Add(this.cBox_QueryFieldChoose);
            this.Controls.Add(this.dGV_membersRow);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_TitleBar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gBox_DetailInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_ManageUserInfo";
            this.Text = "會員管理";
            this.Load += new System.EventHandler(this.Form_ManageUserInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_membersRow)).EndInit();
            this.gBox_DetailInfo.ResumeLayout(false);
            this.gBox_DetailInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_QuerySearch;
        private System.Windows.Forms.TextBox txt_Query;
        private System.Windows.Forms.ComboBox cBox_QueryFieldChoose;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dGV_membersRow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBox_DetailInfo;
        private System.Windows.Forms.TextBox txt_UserRole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Pwd;
        private System.Windows.Forms.Label label7;
        private UCIcon_RoundBtn ucIcon_ShowAll;
        private UCIcon_RoundBtn ucIcon_SaveInfo;
        private UCIcon_RoundBtn ucIcon_CancelEdit;
        private UCIcon_RoundBtn ucIcon_LinkTest;
        private UCIcon_RoundBtn ucIcon_AddMember;
        private UCIcon_RoundBtn ucIcon_Refresh;
        private System.Windows.Forms.Label lbl_TitleBar;
        private UCIcon_RoundBtn ucIcon_RoundBtn1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}