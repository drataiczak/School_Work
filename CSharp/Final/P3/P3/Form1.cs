using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3
{
    public partial class Form1 : Form
    {
        ArrayList aList1 = new ArrayList();
        ArrayList aList2 = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Devin");
            listBox1.Items.Add("Meghan");
            listBox1.Items.Add("Colton");
            listBox1.Items.Add("Tyler");
            listBox1.Items.Add("Alex");

            listBox2.Items.Add("1");
            listBox2.Items.Add("2");
            listBox2.Items.Add("3");
            listBox2.Items.Add("4");
            listBox2.Items.Add("5");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            for (int i = 0; i < listBox1.Items.Count; i++)
                listBox2.Items.Add(listBox1.Items[i].ToString());

            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            for (int i = 0; i < listBox2.Items.Count; i++)
                listBox1.Items.Add(listBox2.Items[i].ToString());

            listBox2.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if(listBox1.Items.Count > 0)
                {
                    listBox2.Items.Add(listBox1.SelectedItem.ToString());
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBox1.Items.Count > 0)
                listBox1.SelectedIndex = 0;

            listBox2.SelectedIndex = listBox2.Items.Count - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox2.Items.Count > 0)
                {
                    listBox1.Items.Add(listBox2.SelectedItem.ToString());
                    listBox2.Items.Remove(listBox2.SelectedItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBox2.Items.Count > 0)
                listBox1.SelectedIndex = 0;

            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
    }
}
