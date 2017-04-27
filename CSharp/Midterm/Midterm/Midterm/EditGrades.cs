using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Midterm
{
    public partial class EditGrades : Form
    {
        static string connection = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =E:/Computer Science/C# Programs/Midterm/StudentDatabase.mdb";
        DataTable dt = new DataTable();
        OleDbConnection conn = new OleDbConnection(connection);

        public Form RefGradeBook
        {
            get;
            set;
        }

        public EditGrades()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.RefGradeBook.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            string ID = IDBox.Text;
            string a = aBox.Text;
            string b = bBox.Text;
            string c = cBox.Text;
            string d = dBox.Text;
            string f = eBox.Text;
            errorLabel.Text = "";

            if ((string.IsNullOrEmpty(ID)) || (!a.All(char.IsDigit)) || (string.IsNullOrEmpty(a))
                || (string.IsNullOrEmpty(b)) || (string.IsNullOrEmpty(c)) || (string.IsNullOrEmpty(d))
                || (string.IsNullOrEmpty(f)) || (!b.All(char.IsDigit)) || (!c.All(char.IsDigit))
                || (!d.All(char.IsDigit)) || (!f.All(char.IsDigit)) || (!ID.All(char.IsDigit)))
                errorLabel.Text = "Please enter a valid ID.";
            else
            {
                string sql = "Update Grades set Grade_A = '" + a
                    + "', Grade_B = '" + b
                    + "', Grade_C = '" + c
                    + "', Grade_D = '" + d
                    + "', Grade_E = '" + f
                    + "' where ID = " + ID;

                OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
                da.Fill(dt); 
            }
        }

        private void EditGrades_Load(object sender, EventArgs e)
        {

        }
    }
}
