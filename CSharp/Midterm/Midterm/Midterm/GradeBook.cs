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
    public partial class GradeBook : Form
    {
        EditGrades frm = new EditGrades();
        static string connection = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = E:/Computer Science/C# Programs/Midterm/StudentDatabase.mdb";
        DataTable dt = new DataTable();

        public GradeBook()
        {
            InitializeComponent();
        }

        private void load()
        {         
            string sql = "Select ID, Grade_A, Grade_B, Grade_C, Grade_D, Grade_E from Grades order by ID";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, connection);
            da.Fill(dt);
            gradeGrid.DataSource = dt;
        }
        private void updateButton_Click(object sender, EventArgs e)
        {

            dt.Clear();
            load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm.RefGradeBook = this;
            frm.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.RefMainMenu2.Show();
        }

        public Form RefMainMenu2
        {
            get;
            set;
        }

        private void GradeBook_Load(object sender, EventArgs e)
        {
            load();
        }

        private void highButton_Click(object sender, EventArgs e)
        {
           

            string sql2 = "Select * from Grades";
            errorLabel.Text = "";
            dt.Clear();
            
            if (aButton.Checked)
            {
                sql2 = "Select Grades.ID, Grades.Grade_A, Students.fName from Grades inner join Students on Grades.ID = Students.ID where Grade_A = (Select max(Grade_A) from Grades)";
            }
            else if (bButton.Checked)
            { 
                sql2 = "Select Grades.ID, Grades.Grade_B, Students.fName from Grades inner join Students on Grades.ID = Students.ID where Grade_B = (Select max(Grade_B) from Grades)";
            }
            else if (cButton.Checked)
            {
                sql2 = "Select Grades.ID, Grades.Grade_C, Students.fName from Grades inner join Students on Grades.ID = Students.ID where Grade_C = (Select max(Grade_C) from Grades)";
            }
            else if (dButton.Checked)
            {
                sql2 = "Select Grades.ID, Grades.Grade_D, Students.fName from Grades inner join Students on Grades.ID = Students.ID where Grade_D = (Select max(Grade_D) from Grades)";
            }
            else if (eButton.Checked)
            {
                sql2 = "Select Grades.ID, Grades.Grade_E, Students.fName from Grades inner join Students on Grades.ID = Students.ID where Grade_E = (Select max(Grade_E) from Grades)";
            }
            else
                error(); 

            OleDbDataAdapter da = new OleDbDataAdapter(sql2, connection);
            da.Fill(dt);
            gradeGrid.DataSource = dt; 
        }

        private void error()
        {
            errorLabel.Text = "Please select a grade.";
        }

        private void lowButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            string sql2 = "Select * from Grades";
            dt.Clear();

            if (aButton.Checked)
            {
                sql2 = "Select Grades.ID, Grades.Grade_A, Students.fName from Grades inner join Students on Grades.ID = Students.ID where Grade_A = (Select min(Grade_A) from Grades)";
            }
            else if (bButton.Checked)
            {
                sql2 = "Select Grades.ID, Grades.Grade_B, Students.fName from Grades inner join Students on Grades.ID = Students.ID where Grade_B = (Select min(Grade_B) from Grades)";
            }
            else if (cButton.Checked)
            {
                sql2 = "Select Grades.ID, Grades.Grade_C, Students.fName from Grades inner join Students on Grades.ID = Students.ID where Grade_C = (Select min(Grade_C) from Grades)";

            }
            else if (dButton.Checked)
            {
                sql2 = "Select Grades.ID, Grades.Grade_D, Students.fName from Grades inner join Students on Grades.ID = Students.ID where Grade_D = (Select min(Grade_D) from Grades)";
            }
            else if (eButton.Checked)
            {
                sql2 = "Select Grades.ID, Grades.Grade_E, Students.fName from Grades inner join Students on Grades.ID = Students.ID where Grade_E = (Select min(Grade_E) from Grades)";
            }
            else
                error();

            OleDbDataAdapter da = new OleDbDataAdapter(sql2, connection);
            da.Fill(dt);
            gradeGrid.DataSource = dt;
           
        }

        private void gradeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
