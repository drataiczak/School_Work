using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P8
{
    public partial class BillingCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double price = Convert.ToDouble(TextBox3.Text);
                double qty = Convert.ToDouble(TextBox2.Text);
                double tax = 1.07;
                double total;
                double newTotal;

                total = Convert.ToDouble(Label5.Text) + tax * price * qty;
                TextBox1.Text = Convert.ToString(total);

                Label5.Text = Convert.ToString(total);
            }
            catch (Exception ex)
            {
                TextBox1.Text = ex.Message;
            }
        }

        
    }
}