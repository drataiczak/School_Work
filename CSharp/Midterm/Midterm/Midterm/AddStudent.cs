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
    public partial class AddStudent : Form
    {
        static string connection = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = E:/Computer Science/C# Programs/Midterm/StudentDatabase.mdb";
        DataTable dt = new DataTable();
        OleDbConnection conn = new OleDbConnection(connection);

        public AddStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";

                string fName = fNameBox.Text;
                string lName = lNameBox.Text;
                string address = addressBox.Text;

            if ((string.IsNullOrEmpty(fName))  || (fName.All(Char.IsDigit)) || (lName.All(Char.IsDigit)) || (string.IsNullOrEmpty(lName)) || (string.IsNullOrEmpty(address)))
                errorLabel.Text = "Please make sure all fields are filled with proper data.";
            else
            {
                string sql = "Insert into Students (fName, lName, Address) values ('" + fName + "', '" + lName + "', '" + address + "')";
                string sqlGrades = "Insert into Grades (Grade_A, Grade_B, Grade_C, Grade_D, Grade_E) values ('99', '99', '99', '99', '99')";

                OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
                OleDbDataAdapter daGrades = new OleDbDataAdapter(sqlGrades, conn);
                da.Fill(dt);
                daGrades.Fill(dt);
                    

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.RefStudentList.Show();
        }

        public Form RefStudentList
        {
            get;
            set;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            string fName = fNameBox.Text;
            string lName = lNameBox.Text;
            string address = addressBox.Text;
            string ID = IDBox.Text;

            if ((string.IsNullOrEmpty(fName)) || (fName.All(char.IsDigit)) || (lName.All(Char.IsDigit)) || (string.IsNullOrEmpty(lName)) || (string.IsNullOrEmpty(address)) || (!ID.All(char.IsDigit)) || (string.IsNullOrEmpty(ID)))
                errorLabel.Text = "Please make sure all fields are filled with proper data.";
            else
            {
                string sql = "Update Students set fName = '" + fName + "', lName = '" + lName + "', Address = '" + address + "'where ID = " + ID;
                OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
                da.Fill(dt);
            }
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
