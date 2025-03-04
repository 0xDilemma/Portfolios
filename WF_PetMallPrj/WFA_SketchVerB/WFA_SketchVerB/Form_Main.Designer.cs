namespace WFA_SketchVerB
{
    partial class Form_Main
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
            this.panel_SubMenu = new System.Windows.Forms.Panel();
            this.panel_MainMenu = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_SubMenu
            // 
            this.panel_SubMenu.BackColor = System.Drawing.Color.White;
            this.panel_SubMenu.Location = new System.Drawing.Point(200, 0);
            this.panel_SubMenu.Name = "panel_SubMenu";
            this.panel_SubMenu.Size = new System.Drawing.Size(800, 600);
            this.panel_SubMenu.TabIndex = 1;
            this.panel_SubMenu.Visible = false;
            // 
            // panel_MainMenu
            // 
            this.panel_MainMenu.BackColor = System.Drawing.Color.White;
            this.panel_MainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.panel_MainMenu.Name = "panel_MainMenu";
            this.panel_MainMenu.Size = new System.Drawing.Size(200, 600);
            this.panel_MainMenu.TabIndex = 0;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.panel_SubMenu);
            this.Controls.Add(this.panel_MainMenu);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_SubMenu;
        private System.Windows.Forms.Panel panel_MainMenu;
    }
}