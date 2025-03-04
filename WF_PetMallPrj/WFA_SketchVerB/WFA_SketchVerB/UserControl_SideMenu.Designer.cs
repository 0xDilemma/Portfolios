namespace WFA_SketchVerB
{
    partial class UserControl_SideMenu
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
            this.panel_SubMenu = new System.Windows.Forms.Panel();
            this.panel_MainMenu = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_SubMenu
            // 
            this.panel_SubMenu.BackColor = System.Drawing.Color.White;
            this.panel_SubMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_SubMenu.Location = new System.Drawing.Point(118, 0);
            this.panel_SubMenu.Name = "panel_SubMenu";
            this.panel_SubMenu.Size = new System.Drawing.Size(332, 200);
            this.panel_SubMenu.TabIndex = 1;
            this.panel_SubMenu.Visible = false;
            // 
            // panel_MainMenu
            // 
            this.panel_MainMenu.BackColor = System.Drawing.Color.White;
            this.panel_MainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.panel_MainMenu.Name = "panel_MainMenu";
            this.panel_MainMenu.Size = new System.Drawing.Size(118, 200);
            this.panel_MainMenu.TabIndex = 0;
            // 
            // UserControl_SideMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_SubMenu);
            this.Controls.Add(this.panel_MainMenu);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControl_SideMenu";
            this.Size = new System.Drawing.Size(450, 200);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel_SubMenu;
        public System.Windows.Forms.Panel panel_MainMenu;
    }
}
