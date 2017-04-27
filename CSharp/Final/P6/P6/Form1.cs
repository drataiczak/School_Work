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

namespace P6
{
    public partial class Form1 : Form
    {
        static string StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=G:/Computer Science/C# Programs/Final/P6/P6/Employees.mdb";
        OleDbConnection conn = new OleDbConnection(StrConn);
        OleDbDataAdapter da;
        DataTable dt;
        OleDbCommandBuilder cb;
        int ID;
        int count;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            dt = new DataTable();
            da = new OleDbDataAdapter("SELECT * FROM EmployeeDB WHERE ID = 2", conn);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            ID = 2;
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string name;
            string DOB;
            string salary;
            string userID;
            string pass;

            if ((textBox2.Text.Equals(textBox3.Text)) && (!textBox1.Text.Equals("")) && (!textBox4.Text.Equals("")) && (!textBox5.Text.Equals("")) && (!textBox6.Text.Equals("")))
            {
                name = textBox4.Text;
                DOB = textBox5.Text;
                salary = textBox6.Text;
                userID = textBox1.Text;
                pass = textBox3.Text;

                conn.Open();
                
                string SQL2 = "INSERT INTO EmployeeDB(Name, DOB, UserID, Salary, Cell, Pass) values('" + name + "', '" + DOB + "', '" + userID + "', '" + salary + "', 'TBD', '" + pass + "')";
                
                dt = new DataTable();
                da = new OleDbDataAdapter(SQL2, conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.Close();

                using (OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM EmployeeDB", conn))
                {
                    conn.Open();
                    count = (int)cmd.ExecuteScalar();
                }

                dt = new DataTable();
                da = new OleDbDataAdapter("SELECT * FROM EmployeeDB WHERE ID = " + Convert.ToString(count), conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                ID = count;

                conn.Close();
            }
            else
                label7.Text = "Please make sure your passwords are the same.";

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                cb = new OleDbCommandBuilder(da);
                da.Update(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            label8.Text = "";
            da = new OleDbDataAdapter("SELECT * FROM EmployeeDB WHERE ID = 1", conn);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            ID = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label8.Text = "";

            using (OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM EmployeeDB", conn))
            {
                conn.Open();
                count = (int)cmd.ExecuteScalar();
            }

            dt = new DataTable();
            da = new OleDbDataAdapter("SELECT * FROM EmployeeDB WHERE ID = " + Convert.ToString(count), conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            ID = count;

            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ID++;
            dt = new DataTable();

            using (OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM EmployeeDB", conn))
            {
                conn.Open();
                count = (int)cmd.ExecuteScalar();
            }

            if (ID <= count)
            {
                da = new OleDbDataAdapter("SELECT * FROM EmployeeDB WHERE ID = " + Convert.ToString(ID), conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                label8.Text = "You have reached the end of the database.";
                ID--;
            }

            conn.Close();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Text = "";
            ID--;
            dt = new DataTable();

            conn.Open();

            if (ID < 1)
            {
                label8.Text = "You have reached the beginning of the database.";
                ID++;
            }
            else
            {
                da = new OleDbDataAdapter("SELECT * FROM EmployeeDB WHERE ID = " + Convert.ToString(ID), conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            conn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label8.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
