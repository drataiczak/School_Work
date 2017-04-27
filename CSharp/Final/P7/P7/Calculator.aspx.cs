using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P7
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                    if (DropDownList1.SelectedIndex == 1)
                        TextBox3.Text = Convert.ToString(Convert.ToDouble(TextBox2.Text) + Convert.ToDouble(TextBox1.Text));
                    if (DropDownList1.SelectedIndex == 2)
                        TextBox3.Text = Convert.ToString(Convert.ToDouble(TextBox1.Text) - Convert.ToDouble(TextBox2.Text));
                    if (DropDownList1.SelectedIndex == 3)
                        TextBox3.Text = Convert.ToString(Convert.ToDouble(TextBox2.Text) * Convert.ToDouble(TextBox1.Text));
                    if (DropDownList1.SelectedIndex == 4)
                        TextBox3.Text = Convert.ToString(Convert.ToDouble(TextBox1.Text) / Convert.ToDouble(TextBox2.Text));
                
            }
            catch(Exception ex)
            {
                TextBox3.Text = ex.Message;
            }
        }
    }
}