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

namespace WFA_SketchVer
{
    public partial class Form_Cart : Form
    {
        
        // METHOD
        void F_CalOrderTot()
        {
            int OrderTot = 0;

            foreach (ArrayList goods in GlobalVar.listOrderCollection)
            {
                int goodsTot = (int)goods[3];
                OrderTot += goodsTot;
            }



        }
        
        // EVENT
        public Form_Cart()
        {
            InitializeComponent();
        }

        private void Form_Cart_Load(object sender, EventArgs e)
        {
            //foreach (ArrayList ActualList in GlobalVar.listOrderCollection)
            //{
            //    string GoodName = ((List<string>)ActualList[0])[0];
                
            //    int Price = ((List<int>)ActualList[1])[1];
            //    int Count = (int)ActualList[2];
            //    int PriceTot = (int)ActualList[3];


            //    lbox_OrderList.Items.Add($"{GoodName} {Price} 元 x{Count} , 單品總價:{PriceTot} ");
            //}

            for (int i = 0; i < GlobalVar.listOrderCollection.Count; i++)
            {
                ArrayList ActualList = GlobalVar.listOrderCollection[i];

                string GoodName = ((List<string>)ActualList[0])[i];
                int Price = ((List<int>)ActualList[1])[i];
                int Count = (int)ActualList[2];
                int PriceTot = (int)ActualList[3];

                lbox_OrderList.Items.Add($"{GoodName} {Price} 元 x{Count} , 單品總價:{PriceTot} ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
