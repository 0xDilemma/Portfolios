namespace WFA_SketchVerB
{
    partial class UC_SingUp
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
            this.btn_SingUp = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Password2 = new System.Windows.Forms.TextBox();
            this.chk_Agree = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_UserPhone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_SingUp
            // 
            this.btn_SingUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.btn_SingUp.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_SingUp.Location = new System.Drawing.Point(146, 250);
            this.btn_SingUp.Name = "btn_SingUp";
            this.btn_SingUp.Size = new System.Drawing.Size(143, 47);
            this.btn_SingUp.TabIndex = 15;
            this.btn_SingUp.Text = "確認註冊";
            this.btn_SingUp.UseVisualStyleBackColor = false;
            this.btn_SingUp.Click += new System.EventHandler(this.btn_SingUp_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Password.Location = new System.Drawing.Point(186, 120);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(165, 27);
            this.txt_Password.TabIndex = 13;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // txt_UserID
            // 
            this.txt_UserID.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_UserID.Location = new System.Drawing.Point(186, 34);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.Size = new System.Drawing.Size(165, 27);
            this.txt_UserID.TabIndex = 14;
            this.txt_UserID.TextChanged += new System.EventHandler(this.txt_UserID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(81, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "密碼";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(80, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "帳號(信箱)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(81, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "確認密碼";
            // 
            // txt_Password2
            // 
            this.txt_Password2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Password2.Location = new System.Drawing.Point(186, 159);
            this.txt_Password2.Name = "txt_Password2";
            this.txt_Password2.Size = new System.Drawing.Size(165, 27);
            this.txt_Password2.TabIndex = 13;
            this.txt_Password2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chk_Agree
            // 
            this.chk_Agree.Location = new System.Drawing.Point(110, 210);
            this.chk_Agree.Name = "chk_Agree";
            this.chk_Agree.Size = new System.Drawing.Size(214, 34);
            this.chk_Agree.TabIndex = 16;
            this.chk_Agree.Text = "本人同意 隱私權政策 與 條款細則";
            this.chk_Agree.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(80, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "手機";
            // 
            // txt_UserPhone
            // 
            this.txt_UserPhone.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_UserPhone.Location = new System.Drawing.Point(186, 73);
            this.txt_UserPhone.Name = "txt_UserPhone";
            this.txt_UserPhone.Size = new System.Drawing.Size(165, 27);
            this.txt_UserPhone.TabIndex = 14;
            this.txt_UserPhone.TextChanged += new System.EventHandler(this.txt_UserID_TextChanged);
            // 
            // UC_SingUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chk_Agree);
            this.Controls.Add(this.btn_SingUp);
            this.Controls.Add(this.txt_Password2);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_UserPhone);
            this.Controls.Add(this.txt_UserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "UC_SingUp";
            this.Size = new System.Drawing.Size(430, 340);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SingUp;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Password2;
        private System.Windows.Forms.CheckBox chk_Agree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_UserPhone;
    }
}
