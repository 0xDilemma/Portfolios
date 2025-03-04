using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace WFA_SketchVerB
{
    public partial class UCIcon_RoundBtn : Button
    {
        // 私有變數宣告
        private int borderRadius = 20;
        private Color borderColor = Color.Silver;
        private int borderSize = 1;
        private Color normalColor = Color.MediumSlateBlue;  // 原本的顏色
        private Color hoverColor = Color.FromArgb(128, 128, 255);  // 淺藍色


        // 自定義屬性
        [Category("自定義")]
        [Description("設定滑鼠懸停時的顏色")]
        public Color HoverColor
        {
            get => hoverColor;
            set
            {
                hoverColor = value;
                Invalidate();
        }
        }

        [Category("自定義")]
        [Description("設定按鈕預設顏色")]
        public Color NormalColor
        {
            get => normalColor;
            set
            {
                normalColor = value;
                BackColor = value;  // 同時更新當前背景色
                Invalidate();
            }
        }

        [Category("自定義")]
        [Description("設定按鈕圓角半徑")]
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; Invalidate(); }
        }

        [Category("自定義")]
        [Description("設定按鈕邊框顏色")]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }

        [Category("自定義")]
        [Description("設定按鈕邊框寬度")]
        public int BorderSize
        {
            get => borderSize;
            set { borderSize = value; Invalidate(); }
        }

        public bool EnableHoverEffect { get; set; } = true; // 預設啟用

        public UCIcon_RoundBtn()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(150, 40);
            BackColor = Color.MediumSlateBlue;
            ForeColor = Color.White;
            Resize += new EventHandler(Button_Resize);

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > Height)
                borderRadius = Height;
        }
        

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;

            // 確保邊框大小不會超過控制項的一半
            borderSize = Math.Min(borderSize, Math.Min(rectSurface.Width, rectSurface.Height) / 2);
    
            // 確保圓角半徑不會超過控制項的最小邊長的一半
            int maxRadius = Math.Min(rectSurface.Width, rectSurface.Height) / 2;
            borderRadius = Math.Min(borderRadius, maxRadius);

            using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
            using (GraphicsPath pathBorder = GetFigurePath(rectBorder, Math.Max(borderRadius - borderSize, 1)))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // 清除原有背景
                this.Region = new Region(pathSurface);

                // 繪製表面
                using (SolidBrush brushSurface = new SolidBrush(this.BackColor))
                {
                    e.Graphics.FillPath(brushSurface, pathSurface);
                }

                // 繪製邊框
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        e.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }

                // 繪製文字
                TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
                TextRenderer.DrawText(e.Graphics, Text, Font, rectSurface, ForeColor, flags);
            }
        }      
    


        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
    
            // 確保圓角半徑不會超過矩形的一半
            radius = Math.Min(radius, Math.Min(rect.Width / 2, rect.Height / 2));
    
            // 確保圓角半徑為正數
            radius = Math.Max(radius, 0);
    
            float curveSize = radius * 2F;

            path.StartFigure();
    
            // 左上角
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            // 右上角
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            // 右下角
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            // 左下角
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            
            path.CloseFigure();

            return path;
        }


        protected override void OnMouseEnter(EventArgs e)
        {
            if (!EnableHoverEffect) return;
            
            base.OnMouseEnter(e);
            BackColor = hoverColor;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (!EnableHoverEffect) return;
            
            base.OnMouseLeave(e);
            BackColor = normalColor;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (!EnableHoverEffect) return;
            
            base.OnMouseDown(e);
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (!EnableHoverEffect) return;
            
            base.OnMouseUp(e);
            Invalidate();
        }

        

        
    }
}
