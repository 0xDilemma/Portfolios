using System;
using System.Collections;
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
    public partial class Form_TakeOrder : Form
    {
        // Variable
        //--- 拖曳用----
        private bool beginMove = false;
        private int currentXPos; private int currentYPos;
        //UserControl_ItemsShow U1 = new UserControl_ItemsShow();

        private int shippingFee = 60; // 預設運費為60元（超商取貨）

        //-------------

        // METHOD
        public  void F_OrderLoad()
        {
            int OrderTot = 0;

            foreach (ArrayList Items in GlobalVar.listOrderCollection)
            {
                string currentItemName = Items[0].ToString();

                // 尋找是否已存在相同商品
                UC_OrderRowFrame existingFrame = null;
                foreach (Control control in fLP_OrderList.Controls)
                {
                    if (control is UC_OrderRowFrame orderFrame && orderFrame.ItemName == currentItemName)
                    {
                        existingFrame = orderFrame;
                        break;
                    }
                }

                if (existingFrame != null)
                {
                    // 更新既有商品的數量和小計
                    int newQuant = existingFrame.ItemQuant + (int)Items[2];
                    existingFrame.ItemQuant = newQuant;
                    existingFrame.txt_ShowQuant.Text = newQuant.ToString();

                    // 清理價格字串，只保留數字
                    string priceStr = existingFrame.ItemPrice
                        .Replace("$NT", "")  // 移除 $NT（不含空格）
                        .Replace("$", "")    // 以防萬一再移除 $ 符號
                        .Replace("NT", "")   // 以防萬一再移除 NT
                        .Trim();             // 移除前後空格
                    //MessageBox.Show($"{priceStr}");

                    // 計算新的小計
                    if (int.TryParse(priceStr, out int price))
                    {
                        int newTot = price * newQuant;
                        existingFrame.ItemTotPrice = newTot;
                        existingFrame.lbl_ShowthisTot.Text = $"$NT {newTot}";
                    }
                    else
                    {
                        MessageBox.Show("價格格式錯誤");
                        return;
                    }
                }
                else
                {
                    // 建立新的商品列
                    UC_OrderRowFrame ItemsFrame = new UC_OrderRowFrame();
                    ItemsFrame.Tag = (int)Items[5];
                    ItemsFrame.txt_ShowthisName.Text = currentItemName; //品名
                    ItemsFrame.ItemName = currentItemName;

                    ItemsFrame.lbl_ShowthisPrice.Text = Items[1].ToString(); //單價
                    ItemsFrame.ItemPrice = Items[1].ToString();

                    ItemsFrame.txt_ShowQuant.Text = Items[2].ToString(); //數量
                    ItemsFrame.ItemQuant = (int)Items[2];

                    ItemsFrame.lbl_ShowthisTot.Text = $"$NT {Items[3].ToString()}"; //單品小計
                    ItemsFrame.ItemTotPrice = (int)Items[3];

                    ItemsFrame.ItemImagePath = Items[4].ToString();
                    ItemsFrame.pbox_ShowthisImage.Image = Image.FromFile(ItemsFrame.ItemImagePath);


                    // 加入到 FlowLayoutPanel
                    fLP_OrderList.Controls.Add(ItemsFrame);
                }

                // 更新總金額
                OrderTot += (int)Items[3];
            }
            lbl_OrderTot.Text = $"$NT {OrderTot}";



        }
        
        // EVENT
        public Form_TakeOrder()
        {
            InitializeComponent();
            GlobalVar.TakeOrderForm = this;
        }

        private void Form_Cart_Load(object sender, EventArgs e)
        {
            F_OrderLoad();
            
            // 設定付款方式下拉選單
            comboBox1.SelectedIndex = 0;
            
            // 設定取貨方式下拉選單
            comboBox2.SelectedIndex = 0;
            
            // 根據會員狀態顯示/隱藏必填區塊
            pnl_unMembermust.Visible = (GlobalVar.CurrentUser == null);
            chk_SameAddress.Visible = (GlobalVar.CurrentUser != null);

            // 更新總價顯示（包含運費）
            UpdateTotalDisplay();
            

            comboBox2.SelectedIndex = 0; lbl_Address.Text = "超商門市地址";
            textBox1.Text = ""; txt_DeliveryAddress.Text = "";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 根據選擇的取貨方式更新運費
            shippingFee = comboBox2.SelectedIndex == 0 ? 60 : 120;
            
            // 更新運費顯示
            label10.Text = $"${shippingFee}";
            
            // 更新總價顯示
            UpdateTotalDisplay();
            if (comboBox2.SelectedIndex==0)
            {
                lbl_Address.Text = "超商門市地址";
            }
            else
            {
                lbl_Address.Text = "宅配地址";
            }
        }

        private void UpdateTotalDisplay()
        {
            int subtotal = CalculateTotalAmount() - shippingFee; // 先減去運費，因為 CalculateTotalAmount 已經包含運費
            lbl_OrderTot.Text = $"$NT {subtotal + shippingFee:N0}(已含運)";
        }

        private int CalculateTotalAmount()
        {
            int total = 0;
            foreach (ArrayList item in GlobalVar.listOrderCollection)
            {
                total += Convert.ToInt32(item[3]); // 取得項目總價
            }
            return total + shippingFee;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
            GlobalVar.MainForm.uC_CartCurrent.fLP_OrderList.Controls.Clear();
        }

        private void btn_back_MouseEnter(object sender, EventArgs e)
        {
            btn_back.Font = new System.Drawing.Font("微軟正黑體 Light", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            btn_back.ForeColor = Color.Black;
        }

        private void btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.Font = new System.Drawing.Font("微軟正黑體 Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            btn_back.ForeColor = System.Drawing.Color.Gray;
        }


        private void btn_Pay_MouseEnter(object sender, EventArgs e)
        {
            btn_Pay.BackColor = Color.Green;
        }

        private void btn_Pay_MouseLeave(object sender, EventArgs e)
        {
            this.btn_Pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(249)))), ((int)(((byte)(230)))));
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            int UserID;
            if(GlobalVar.CurrentUser !=null)
            {
                UserID = GlobalVar.CurrentUser.UserID;
            }
            else
            {
                string cleanNumber = textBox1.Text.Replace("-", "").Replace(" ", "");
                const string PHONE_PATTERN = @"^09\d{8}$"; // 手機格式
                if (!System.Text.RegularExpressions.Regex.IsMatch(cleanNumber, PHONE_PATTERN))
                {
                    MessageBox.Show("請輸入有效的手機號碼！（格式：09開頭加8碼數字）");
                    return;
                }
                int phoneNumber = Convert.ToInt32(cleanNumber);          
                UserID = phoneNumber;
            }

            if (GlobalVar.listOrderCollection.Count == 0)
            {
                MessageBox.Show("購物車是空的！");
                return;
            }

            // 檢查配送地址
            if (string.IsNullOrWhiteSpace(txt_DeliveryAddress.Text) || txt_DeliveryAddress.Text == "(地址)")
            {
                MessageBox.Show("請輸入配送地址！");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalVar.strDBConnection))
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string insertOrderSQL = @"
                                INSERT INTO Orders (
                                    UserID, OrderDate, TotalAmount, ShippingAddress,
                                    PaymentMethod, Status, ShippingFee, Discount,
                                    CreatedAt, UpdatedAt
                                ) VALUES (
                                    @UserID, GETDATE(), @TotalAmount, @ShippingAddress,
                                    @PaymentMethod, @Status, @ShippingFee, @Discount,
                                    GETDATE(), GETDATE()
                                );
                                SELECT SCOPE_IDENTITY();";

                            SqlCommand cmdOrder = new SqlCommand(insertOrderSQL, conn, transaction);
                            cmdOrder.Parameters.AddWithValue("@UserID", UserID); // 非會員使用 0
                            cmdOrder.Parameters.AddWithValue("@TotalAmount", CalculateTotalAmount());
                            cmdOrder.Parameters.AddWithValue("@ShippingAddress", txt_DeliveryAddress.Text);
                            cmdOrder.Parameters.AddWithValue("@PaymentMethod", comboBox1.Text);
                            cmdOrder.Parameters.AddWithValue("@Status", "待付款");
                            cmdOrder.Parameters.AddWithValue("@ShippingFee", shippingFee);
                            cmdOrder.Parameters.AddWithValue("@Discount", DBNull.Value);

                            int newOrderID = Convert.ToInt32(cmdOrder.ExecuteScalar());

                            // 2. 建立訂單明細記錄
                            string insertDetailSQL = @"
                                INSERT INTO OrderDetails (
                                    OrderID, ProductID, Quantity, UnitPrice, 
                                    Discount, TotalPrice
                                ) VALUES (
                                    @OrderID, @ProductID, @Quantity, @UnitPrice,
                                    @DetailDiscount, @DetailTotal
                                )";

                            // 處理每個購物車項目
                            foreach (ArrayList item in GlobalVar.listOrderCollection)
                            {
                                try 
                                {
                                    string productName = item[0].ToString();
                                    string priceString = item[1].ToString().Replace("NT$", "").Replace("$", "").Trim();
                                    int unitPrice = Convert.ToInt32(priceString);
                                    int quantity = Convert.ToInt32(item[2]);
                                    int totalPrice = Convert.ToInt32(item[3]);
                                    string imagePath = item[4].ToString();

                                    // 取得商品ID
                                    int productID = GetProductIDByName(productName, conn, transaction);

                                    // 1. 先建立訂單明細
                                    SqlCommand cmdDetail = new SqlCommand(insertDetailSQL, conn, transaction);
                                    cmdDetail.Parameters.AddWithValue("@OrderID", newOrderID);
                                    cmdDetail.Parameters.AddWithValue("@ProductID", productID);
                                    cmdDetail.Parameters.AddWithValue("@Quantity", quantity);
                                    cmdDetail.Parameters.AddWithValue("@UnitPrice", unitPrice);
                                    cmdDetail.Parameters.AddWithValue("@DetailDiscount", 0);
                                    cmdDetail.Parameters.AddWithValue("@DetailTotal", totalPrice);
                                    cmdDetail.ExecuteNonQuery();

                                    // 2. 更新商品庫存
                                    string updateStockSQL = @"
                                        UPDATE FoodProducts 
                                        SET QuantityInStock = QuantityInStock - @Quantity 
                                        WHERE ProductID = @ProductID";

                                    SqlCommand cmdUpdateStock = new SqlCommand(updateStockSQL, conn, transaction);
                                    cmdUpdateStock.Parameters.AddWithValue("@ProductID", productID);
                                    cmdUpdateStock.Parameters.AddWithValue("@Quantity", quantity);
                                    cmdUpdateStock.ExecuteNonQuery();

                                    // 3. 更新 GlobalVar 中的庫存字典
                                    if (GlobalVar.ProductStock.ContainsKey(productID))
                                    {
                                        GlobalVar.ProductStock[productID] -= quantity;

                                        // 可選：加入安全檢查，確保庫存不會變成負數
                                        if (GlobalVar.ProductStock[productID] < 0)
                                        {
                                            GlobalVar.ProductStock[productID] = 0;
                                        }
                                    }
                                    else
                                    {
                                        // 如果字典中沒有這個商品的庫存紀錄，可以加入錯誤處理
                                        MessageBox.Show($"警告：商品ID {productID} 在庫存字典中未找到");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"處理訂單時發生錯誤：{ex.Message}");
                                    throw;
                                }
                            }

                            transaction.Commit();
                            MessageBox.Show("訂單已成立！請在期限內付款！！！");

                            
                            // 清空購物車
                            GlobalVar.listOrderCollection.Clear();
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"建立訂單時發生錯誤：{ex.Message}");
            }
        }

   

        // 通過商品名稱獲取ProductID的輔助方法
        private int GetProductIDByName(string productName, SqlConnection conn, SqlTransaction transaction)
        {
            string sql = "SELECT ProductID FROM FoodProducts WHERE ProductName = @ProductName";
            using (SqlCommand cmd = new SqlCommand(sql, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@ProductName", productName);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                throw new Exception($"找不到商品：{productName}");
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXPos = MousePosition.X; currentYPos = MousePosition.Y;

            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove)
            {
                this.Left += MousePosition.X - currentXPos;
                this.Top += MousePosition.Y - currentYPos;
                currentXPos = MousePosition.X;
                currentYPos = MousePosition.Y;
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentXPos = 0; currentYPos = 0;
                beginMove = false;
            }
        }

        private void chk_SameAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_SameAddress.Checked)
            {
                // 假設用戶地址存在某個變數或屬性中
                txt_DeliveryAddress.Text = GlobalVar.CurrentUser.UserAddress;
                
            }
            else
            {
                // 當取消勾選時，清空文字框
                txt_DeliveryAddress.Text = string.Empty;
            }
        }
    }
}
