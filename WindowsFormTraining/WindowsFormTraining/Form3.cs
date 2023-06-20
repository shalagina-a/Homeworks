using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormTraining
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ans = textBox1.Text;
            if ((ans == "Печорин" || ans == "Мудак") && checkBox1.Checked && checkBox3.Checked && checkBox4.Checked && checkBox5.Checked)
            {

                Form4 fin = new Form4();
                fin.Show();

            }
            else
            {
                label3.Text = "НЕПРАВИЛЬНО!!!";
                label3.ForeColor = Color.Red;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label3.Hide();
        }
    }
}
