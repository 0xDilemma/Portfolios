namespace WFA_SketchVerB
{
    partial class UC_HomePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.fLP_GoodsMainShow = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "熱銷排行！！！";
            // 
            // fLP_GoodsMainShow
            // 
            this.fLP_GoodsMainShow.AutoScroll = true;
            this.fLP_GoodsMainShow.BackColor = System.Drawing.Color.White;
            this.fLP_GoodsMainShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fLP_GoodsMainShow.Location = new System.Drawing.Point(33, 44);
            this.fLP_GoodsMainShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fLP_GoodsMainShow.Name = "fLP_GoodsMainShow";
            this.fLP_GoodsMainShow.Size = new System.Drawing.Size(948, 650);
            this.fLP_GoodsMainShow.TabIndex = 1;
            // 
            // UC_HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(223)))), ((int)(((byte)(207)))));
            this.Controls.Add(this.fLP_GoodsMainShow);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_HomePage";
            this.Size = new System.Drawing.Size(1012, 730);
            this.Load += new System.EventHandler(this.UC_HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.FlowLayoutPanel fLP_GoodsMainShow;
    }
}
