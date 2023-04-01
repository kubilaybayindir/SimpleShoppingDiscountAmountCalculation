using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingDiscountAmountCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int bookQuantity;
        public int unitPrice =8;
        public double DiscountAmount;
        double WithoutDiscountedresult=0;
        double Discountedresult = 0;
        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bookQuantity = Convert.ToInt16(BookQuantityTbx.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                if (bookQuantity > 0)
                {
                    if ((bookQuantity > 0) && (bookQuantity <= 10))
                    {
                        DiscountAmount = 0.2;
                    }
                    else
                    {
                        if ((bookQuantity >= 11) && (bookQuantity <= 20))
                        {
                            DiscountAmount = 0.3;
                        }
                        else
                        {
                            DiscountAmount = 0.4;
                        }
                    }
                    WithoutDiscountedresult = unitPrice * bookQuantity;
                    Discountedresult = unitPrice * (1 - DiscountAmount) * bookQuantity;
                    PriceLbl.Text = "Without Discount:      " + WithoutDiscountedresult.ToString() + " $";
                    DiscountedPriceLbl.Text = "Discounted Price: " + Discountedresult.ToString() + " $";

                    ProfitLbl.Text = "Profit:                    " + (WithoutDiscountedresult - Discountedresult).ToString() + " $";
                }
                else
                {
                    MessageBox.Show("Quantity can not be negative!", "Error");
                    BookQuantityTbx.Text = "";
                    PriceLbl.Text = "";
                    DiscountedPriceLbl.Text = "";
                    ProfitLbl.Text = "";
                }
            }



            


        }
    }
}
