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

namespace P5
{
    public partial class Program : Form
    {
        static string StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=G:/Computer Science/C# Programs/Final/P5/P5/TestDatabase.mdb";
        OleDbConnection conn = new OleDbConnection(StrConn);
        OleDbDataAdapter da;
        OleDbCommandBuilder cb;
        DataTable dt;

        public Program()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            da = new OleDbDataAdapter("SELECT * FROM " + comboBox1.SelectedItem.ToString(), conn);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

            foreach (DataRow row in dt.Rows)
                comboBox1.Items.Add(row[2].ToString());
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
