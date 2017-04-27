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
    public partial class StudentList : Form
    {
        AddStudent frm = new AddStudent();
        RemoveStudents frm2 = new RemoveStudents();
        static string connection = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = E:/Computer Science/C# Programs/Midterm/StudentDatabase.mdb";
        DataTable dt = new DataTable();

        public StudentList()
        {
            InitializeComponent();
        }

        public Form RefMainMenu
        {
            get;
            set;
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            string sql = "SELECT ID, fName, lName, Address FROM Students order by ID";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, connection);
            da.Fill(dt);
            studentGrid.DataSource = dt;
        }
        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.RefMainMenu.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            frm.RefStudentList = this;
            this.Hide();
            frm.ShowDialog();
        }

        private void studentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            dt.Clear();
            load();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            frm2.RefStudentListfromRemove = this;
            this.Visible = false;
            frm2.Show();
        }
    }
}
