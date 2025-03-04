using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WFA_SketchVerB
{
    public partial class User_TopPnl : UserControl
    {
        // 定義顏色
        private Color originalColor = Color.White;  // 原始顏色
        private Color hoverColor = Color.FromArgb(255, 168, 170);  // 淡紅色

        // 添加新的成員變數
        private const int MAX_SEARCH_RESULTS = 20; // 限制最大搜尋結果數
        private Label lblLoading; // 載入提示標籤

        public User_TopPnl()
        {
            InitializeComponent();
            SetupHoverEffects();
            InitializeSearchControls();
        }

        private void InitializeSearchControls()
        {
            // 初始化載入中提示標籤
            lblLoading = new Label
            {
                Text = "搜尋中...",
                AutoSize = true,
                Visible = false,
                Font = new Font("微軟正黑體", 12),
                Location = new Point(ucIcon_QuerySearch.Right + 10, ucIcon_QuerySearch.Top + 5)
            };
            this.Controls.Add(lblLoading);

            // 為搜尋框添加按鍵事件
            txt_Query.KeyPress += (sender, e) =>
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true; // 防止發出提示音
                    PerformSearch();
                }
            };

            // 修改搜尋按鈕點擊事件
            ucIcon_QuerySearch.Click += (sender, e) => PerformSearch();
        }

        private async void PerformSearch()
        {
            string searchKeyword = txt_Query.Text.Trim();
            
            if (string.IsNullOrEmpty(searchKeyword))
            {
                MessageBox.Show("請輸入搜尋關鍵字", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // 顯示載入提示
                lblLoading.Visible = true;
                ucIcon_QuerySearch.Enabled = false;
                uC_RoundedTextBox1.Enabled = false;

                // 清除現有商品列表
                GlobalVar.MainForm.uC_HomePage1.fLP_GoodsMainShow.Controls.Clear();

                // 使用 Task.Run 執行耗時的資料庫操作
                var results = await Task.Run(() => SearchProducts(searchKeyword));

                if (results == 0)
                {
                    MessageBox.Show(
                        "找不到符合的商品\n請嘗試其他關鍵字", 
                        "搜尋結果", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information
                    );
                    GlobalVar.MainForm.uC_HomePage1.F_ReloadHomePage(); // 重新載入原始商品列表
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"搜尋時發生錯誤：{ex.Message}", 
                    "錯誤", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                // 隱藏載入提示
                lblLoading.Visible = false;
                ucIcon_QuerySearch.Enabled = true;
                uC_RoundedTextBox1.Enabled = true;
            }
        }

        private int SearchProducts(string searchKeyword)
        {
            using (SqlConnection conn = new SqlConnection(GlobalVar.strDBConnection))
            {
                conn.Open();
                string sql = @"
                    SELECT TOP (@MaxResults) f.*, pi.ImageFileName 
                    FROM FoodProducts f 
                    LEFT JOIN ProductImages pi ON f.ProductID = pi.ProductID 
                    WHERE f.IsActive = 1 
                    AND (
                        f.ProductName LIKE @Keyword 
                        OR f.Brand LIKE @Keyword 
                        OR f.Category LIKE @Keyword
                        OR f.Description LIKE @Keyword
                    )
                    AND (pi.isPrimary = 1 OR pi.isPrimary IS NULL)
                    ORDER BY 
                        CASE 
                            WHEN f.ProductName LIKE @Keyword THEN 1
                            WHEN f.Brand LIKE @Keyword THEN 2
                            WHEN f.Category LIKE @Keyword THEN 3
                            ELSE 4
                        END";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Keyword", $"%{searchKeyword}%");
                cmd.Parameters.AddWithValue("@MaxResults", MAX_SEARCH_RESULTS);

                // 使用委派在主執行緒上更新 UI
                if (this.InvokeRequired)
                {
                    return (int)this.Invoke(new Func<int>(() => 
                    {
                        GlobalVar.MainForm.uC_HomePage1.LoadFilteredProducts(cmd);
                        return GlobalVar.MainForm.uC_HomePage1.fLP_GoodsMainShow.Controls.Count;
                    }));
                }
                else
                {
                    GlobalVar.MainForm.uC_HomePage1.LoadFilteredProducts(cmd);
                    return GlobalVar.MainForm.uC_HomePage1.fLP_GoodsMainShow.Controls.Count;
                }
            }
        }

        public void AdjustButtonsPosition(bool isLoggedIn)
        {
            if (isLoggedIn)
            {
                fLPnl_Login.Visible = false;
                GlobalVar.MainForm.uC_DownUserMenu1.Visible = true;

               
                // 向左移動首頁和購物車按鈕
                // 假設要移動的距離是 38 像素，請根據實際需求調整
                fLPnl_HomePage.Location = new Point(fLPnl_HomePage.Location.X - 38, fLPnl_HomePage.Location.Y);
                fLPnl_ShopCart.Location = new Point(fLPnl_ShopCart.Location.X - 38, fLPnl_ShopCart.Location.Y);
            }
            else
            {
                // 登出後顯示登入按鈕
                fLPnl_Login.Visible = true;

                // 回復首頁和購物車按鈕的原始位置
                fLPnl_HomePage.Location = new Point(fLPnl_HomePage.Location.X + 38, fLPnl_HomePage.Location.Y);
                fLPnl_ShopCart.Location = new Point(fLPnl_ShopCart.Location.X + 38, fLPnl_ShopCart.Location.Y);
            }
        }

        private void SetupHoverEffects()
        {
            // 為每個 FlowLayoutPanel 添加事件處理
            foreach (FlowLayoutPanel panel in new[] { fLPnl_Login, fLPnl_ShopCart, fLPnl_HomePage })
            {
                // 滑鼠進入事件
                panel.MouseEnter += (sender, e) =>
                {
                    if (sender is FlowLayoutPanel flPanel)
                    {
                        flPanel.BackColor = hoverColor;
                        // 同時改變內部控制項的背景色
                        foreach (Control control in flPanel.Controls)
                        {
                            control.BackColor = hoverColor;
                        }
                    }
                };

                // 滑鼠離開事件
                panel.MouseLeave += (sender, e) =>
                {
                    if (sender is FlowLayoutPanel flPanel)
                    {
                        flPanel.BackColor = originalColor;
                        // 同時恢復內部控制項的背景色
                        foreach (Control control in flPanel.Controls)
                        {
                            control.BackColor = originalColor;
                        }
                    }
                };

                // 為面板內的控制項也添加相同的效果
                foreach (Control control in panel.Controls)
                {
                    control.MouseEnter += (sender, e) =>
                    {
                        panel.BackColor = hoverColor;
                        foreach (Control c in panel.Controls)
                        {
                            c.BackColor = hoverColor;
                        }
                    };

                    control.MouseLeave += (sender, e) =>
                    {
                        // 檢查滑鼠是否真的離開了整個面板區域
                        Point mousePos = panel.PointToClient(Control.MousePosition);
                        if (!panel.ClientRectangle.Contains(mousePos))
                        {
                            panel.BackColor = originalColor;
                            foreach (Control c in panel.Controls)
                            {
                                c.BackColor = originalColor;
                            }
                        }
                    };
                }
            }
        }

        // 開啟登入介面
        private void fLPnl_Login_Click(object sender, EventArgs e)
        {
            Form_Login myFormLogin = new Form_Login();

            myFormLogin.ShowDialog();
        }

        private void fLPnl_ShopCart_Click(object sender, EventArgs e)
        {
            GlobalVar.MainForm.uC_CartCurrent.BringToFront();
            GlobalVar.MainForm.uC_CartCurrent.Visible = !GlobalVar.MainForm.uC_CartCurrent.Visible;
            if (GlobalVar.MainForm.uC_CartCurrent.Visible == true)
            {
                //在 UC_Cart 中寫入方法來載入 GV 的訂購清單
                GlobalVar.MainForm.uC_CartCurrent.F_CartLoad();
            }
            else
            {
                GlobalVar.MainForm.uC_CartCurrent.fLP_OrderList.Controls.Clear();
            }

        }

        private void fLPnl_HomePage_Click(object sender, EventArgs e)
        {
            GlobalVar.MainForm.uC_GoodsDetailCurrent.Visible = false;
            // 直接通過 GlobalVar.MainForm 存取 uC_HomePage1
            GlobalVar.MainForm.uC_HomePage1.F_ReloadHomePage();
            GlobalVar.MainForm.uC_HomePage1.Visible = true;
            GlobalVar.MainForm.uC_HomePage1.BringToFront();
            GlobalVar.MainForm.UC_ManageMenu.BringToFront();
        }

        

        private void User_TopPnl_Load(object sender, EventArgs e)
        {
            txt_Query.Text = "";
        }
    }
}
