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
    public partial class RemoveStudents : Form
    {
        DataTable dt = new DataTable();
        static string connection = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = E:/Computer Science/C# Programs/Midterm/StudentDatabase.mdb";
        OleDbConnection conn = new OleDbConnection(connection);

        public RemoveStudents()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            string ID = IDBox.Text;

            if(ID.All(char.IsDigit))
            {
                try
                {
                    string sql = "Delete Students.*, Grades.* from Students inner join Grades on Students.ID = Grades.ID where Students.ID = " + ID;
                    OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
                    da.Fill(dt);
                }
                catch
                {
                    errorLabel.Text = "Please enter a valid ID.";
                }
            }
            else
            {
                errorLabel.Text = "Please enter a valid ID.";
            }
        }

        public Form RefStudentListfromRemove
        {
            get;
            set;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.RefStudentListfromRemove.Show();
        }

        private void IDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RemoveStudents_Load(object sender, EventArgs e)
        {

        }
    }
}
