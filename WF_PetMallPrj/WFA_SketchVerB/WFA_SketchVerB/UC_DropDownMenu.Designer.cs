using System.Windows.Forms;

namespace WFA_SketchVerB
{
    partial class UC_DropDownMenu
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
            this.panel_MainMenu = new System.Windows.Forms.Panel();
            this.btn_Main = new System.Windows.Forms.Button();
            this.panel_SubMenu = new System.Windows.Forms.Panel();
            this.panel_MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_MainMenu
            // 
            this.panel_MainMenu.BackColor = System.Drawing.Color.White;
            this.panel_MainMenu.Controls.Add(this.btn_Main);
            this.panel_MainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.panel_MainMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_MainMenu.Name = "panel_MainMenu";
            this.panel_MainMenu.Size = new System.Drawing.Size(200, 32);
            this.panel_MainMenu.TabIndex = 0;
            // 
            // btn_Main
            // 
            this.btn_Main.BackColor = System.Drawing.Color.White;
            this.btn_Main.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Main.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Main.Location = new System.Drawing.Point(0, 0);
            this.btn_Main.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Main.Name = "btn_Main";
            this.btn_Main.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Main.Size = new System.Drawing.Size(200, 32);
            this.btn_Main.TabIndex = 0;
            this.btn_Main.Text = "管理選單";
            this.btn_Main.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Main.UseVisualStyleBackColor = true;
            // 
            // panel_SubMenu
            // 
            this.panel_SubMenu.BackColor = System.Drawing.Color.White;
            this.panel_SubMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_SubMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_SubMenu.Location = new System.Drawing.Point(0, 32);
            this.panel_SubMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_SubMenu.Name = "panel_SubMenu";
            this.panel_SubMenu.Size = new System.Drawing.Size(200, 120);
            this.panel_SubMenu.TabIndex = 0;
            this.panel_SubMenu.Visible = false;
            // 
            // UC_DropDownMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_SubMenu);
            this.Controls.Add(this.panel_MainMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_DropDownMenu";
            this.Size = new System.Drawing.Size(200, 152);
            this.Load += new System.EventHandler(this.UC_DropDownMenu_Load);
            this.panel_MainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_MainMenu;
        private System.Windows.Forms.Panel panel_SubMenu;
        private System.Windows.Forms.Button btn_Main;
    }
}
