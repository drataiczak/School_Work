using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm
{
    public partial class MainMenu : Form
    {
        StudentList frm = new StudentList();
        GradeBook frm2 = new GradeBook();      

        public MainMenu()
        {
            InitializeComponent();
            
        }

        private void studListButton_Click(object sender, EventArgs e)
        {
            frm.RefMainMenu = this;
            this.Hide();
            frm.Visible = true ;
        }

        private void gradeBookButton_Click(object sender, EventArgs e)
        {
            frm2.RefMainMenu2 = this;
            this.Hide();
            frm2.Visible = true;
        }

        private void attendanceButton_Click(object sender, EventArgs e)
        {
            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
