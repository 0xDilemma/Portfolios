namespace WFA_SketchVerB
{
    partial class Form_Login
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ChooseSingin = new System.Windows.Forms.Label();
            this.lbl_SingUp = new System.Windows.Forms.Label();
            this.lbl_ChooseSingUp = new System.Windows.Forms.Label();
            this.lbl_Actual = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.uC_SingUp1 = new WFA_SketchVerB.UC_SingUp();
            this.ucIcon_Forget = new WFA_SketchVerB.UCIcon_RoundBtn();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.btn_Login.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Login.Location = new System.Drawing.Point(146, 275);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(143, 47);
            this.btn_Login.TabIndex = 10;
            this.btn_Login.Text = "登  入";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Password.Location = new System.Drawing.Point(186, 191);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(165, 27);
            this.txt_Password.TabIndex = 8;
            // 
            // txt_UserID
            // 
            this.txt_UserID.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_UserID.Location = new System.Drawing.Point(186, 135);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.Size = new System.Drawing.Size(165, 27);
            this.txt_UserID.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(81, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "密碼";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(80, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "帳號(信箱)";
            // 
            // lbl_ChooseSingin
            // 
            this.lbl_ChooseSingin.AutoSize = true;
            this.lbl_ChooseSingin.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_ChooseSingin.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_ChooseSingin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_ChooseSingin.Location = new System.Drawing.Point(120, 67);
            this.lbl_ChooseSingin.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lbl_ChooseSingin.Name = "lbl_ChooseSingin";
            this.lbl_ChooseSingin.Size = new System.Drawing.Size(48, 24);
            this.lbl_ChooseSingin.TabIndex = 6;
            this.lbl_ChooseSingin.Text = "登入";
            this.lbl_ChooseSingin.Click += new System.EventHandler(this.lbl_ChooseSingin_Click);
            this.lbl_ChooseSingin.MouseEnter += new System.EventHandler(this.lbl_ChooseSingin_MouseEnter);
            this.lbl_ChooseSingin.MouseLeave += new System.EventHandler(this.lbl_ChooseSingin_MouseLeave);
            // 
            // lbl_SingUp
            // 
            this.lbl_SingUp.AutoSize = true;
            this.lbl_SingUp.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_SingUp.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_SingUp.Location = new System.Drawing.Point(154, 328);
            this.lbl_SingUp.Name = "lbl_SingUp";
            this.lbl_SingUp.Size = new System.Drawing.Size(125, 17);
            this.lbl_SingUp.TabIndex = 12;
            this.lbl_SingUp.Tag = "";
            this.lbl_SingUp.Text = "沒有帳號? 立即註冊!";
            this.lbl_SingUp.Click += new System.EventHandler(this.lbl_ChooseSingin_Click);
            this.lbl_SingUp.MouseEnter += new System.EventHandler(this.lbl_SingUp_MouseEnter);
            this.lbl_SingUp.MouseLeave += new System.EventHandler(this.lbl_SingUp_MouseLeave);
            // 
            // lbl_ChooseSingUp
            // 
            this.lbl_ChooseSingUp.AutoSize = true;
            this.lbl_ChooseSingUp.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_ChooseSingUp.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_ChooseSingUp.Location = new System.Drawing.Point(241, 67);
            this.lbl_ChooseSingUp.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lbl_ChooseSingUp.Name = "lbl_ChooseSingUp";
            this.lbl_ChooseSingUp.Size = new System.Drawing.Size(48, 24);
            this.lbl_ChooseSingUp.TabIndex = 6;
            this.lbl_ChooseSingUp.Text = "註冊";
            this.lbl_ChooseSingUp.Click += new System.EventHandler(this.lbl_ChooseSingin_Click);
            this.lbl_ChooseSingUp.MouseEnter += new System.EventHandler(this.lbl_ChooseSingin_MouseEnter);
            this.lbl_ChooseSingUp.MouseLeave += new System.EventHandler(this.lbl_ChooseSingin_MouseLeave);
            // 
            // lbl_Actual
            // 
            this.lbl_Actual.BackColor = System.Drawing.Color.Tomato;
            this.lbl_Actual.Location = new System.Drawing.Point(95, 92);
            this.lbl_Actual.Name = "lbl_Actual";
            this.lbl_Actual.Size = new System.Drawing.Size(100, 5);
            this.lbl_Actual.TabIndex = 16;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Black;
            this.lbl_Title.Location = new System.Drawing.Point(156, 29);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(123, 35);
            this.lbl_Title.TabIndex = 6;
            this.lbl_Title.Text = "會員登入";
            // 
            // uC_SingUp1
            // 
            this.uC_SingUp1.Location = new System.Drawing.Point(0, 99);
            this.uC_SingUp1.Name = "uC_SingUp1";
            this.uC_SingUp1.Size = new System.Drawing.Size(430, 340);
            this.uC_SingUp1.TabIndex = 17;
            // 
            // ucIcon_Forget
            // 
            this.ucIcon_Forget.BackColor = System.Drawing.Color.Silver;
            this.ucIcon_Forget.BorderColor = System.Drawing.Color.Silver;
            this.ucIcon_Forget.BorderRadius = 5;
            this.ucIcon_Forget.BorderSize = 1;
            this.ucIcon_Forget.EnableHoverEffect = true;
            this.ucIcon_Forget.FlatAppearance.BorderSize = 0;
            this.ucIcon_Forget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucIcon_Forget.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ucIcon_Forget.ForeColor = System.Drawing.Color.White;
            this.ucIcon_Forget.HoverColor = System.Drawing.Color.Gray;
            this.ucIcon_Forget.Location = new System.Drawing.Point(176, 348);
            this.ucIcon_Forget.Name = "ucIcon_Forget";
            this.ucIcon_Forget.NormalColor = System.Drawing.Color.Silver;
            this.ucIcon_Forget.Size = new System.Drawing.Size(85, 22);
            this.ucIcon_Forget.TabIndex = 18;
            this.ucIcon_Forget.Text = "忘記密碼?";
            this.ucIcon_Forget.UseVisualStyleBackColor = false;
            this.ucIcon_Forget.Click += new System.EventHandler(this.ucIcon_Forget_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 450);
            this.Controls.Add(this.uC_SingUp1);
            this.Controls.Add(this.ucIcon_Forget);
            this.Controls.Add(this.lbl_ChooseSingin);
            this.Controls.Add(this.lbl_ChooseSingUp);
            this.Controls.Add(this.lbl_Actual);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_SingUp);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form_Login";
            this.Text = "會員登入";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_ChooseSingin;
        private System.Windows.Forms.Label lbl_SingUp;
        private System.Windows.Forms.Label lbl_ChooseSingUp;
        private System.Windows.Forms.Label lbl_Actual;
        private System.Windows.Forms.Label lbl_Title;
        private UC_SingUp uC_SingUp1;
        private UCIcon_RoundBtn ucIcon_Forget;
    }
}