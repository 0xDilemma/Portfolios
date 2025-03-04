using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SketchVerB
{
    public partial class UC_RoundedTextBox : UserControl
    {
        private int borderRadius = 15;  // 圓角半徑
        private float borderSize = 2f;  // 邊框粗細
        private Color borderColor = Color.Gray;  // 邊框顏色

         // 添加自定義顏色屬性
        //private Color userColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
        private Color userColor = System.Drawing.Color.White;
        public Color UserColor
        {
            get { return userColor; }
            set 
            { 
                userColor = value;
                this.BackColor = userColor;
                // 更新所有 TextBox 的顏色
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        textBox.BackColor = userColor;
                    }
                }
                this.Invalidate();
            }
        }

        // 美觀用============================
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -1, -1);

            using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
            using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1))
            using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                //this.Region = new Region(pathSurface);
                // 只繪製背景和邊框
                using (SolidBrush brushSurface = new SolidBrush(this.BackColor))
                {
                    e.Graphics.FillPath(brushSurface, pathSurface);
                }
                e.Graphics.DrawPath(penSurface, pathSurface);

                if (borderSize >= 1)
                    e.Graphics.DrawPath(penBorder, pathBorder);
            }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();

            return path;
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Invalidate();
        }
        //================================
        public UC_RoundedTextBox()
        {
            InitializeComponent();
            this.BackColor = Color.White; // 顏色同步
            this.DoubleBuffered = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    // 設定 TextBox 背景透明
                    textBox.BackColor = UserColor;  // 顏色同步
                    textBox.BorderStyle = BorderStyle.None;  // 移除邊框
                    
                    // 訂閱 TextBox 的背景重繪事件
                    textBox.Paint += TextBox_Paint;
                }
            }
        }

        private void TextBox_Paint(object sender, PaintEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                e.Graphics.Clear(this.BackColor);
            }
        }
    }
}
