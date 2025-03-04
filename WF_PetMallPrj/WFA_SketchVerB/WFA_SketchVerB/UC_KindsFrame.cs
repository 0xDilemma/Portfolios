using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SketchVerB
{
    public partial class UC_KindsFrame : UserControl
    {
        private int borderRadius = 10;  // 圓角半徑
        private float borderSize = 1f;  // 邊框粗細
        private Color borderColor = Color.LightGray;  // 邊框顏色



        public UC_KindsFrame()
        {
            InitializeComponent();
        }
    }
}
