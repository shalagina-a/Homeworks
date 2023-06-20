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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //public Form2 (Form1 f)
        //{
        //    InitializeComponent ();
        //    //f.BackColor = Color.PeachPuff;
    
        //}

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                Form3 ege2 = new Form3();
                ege2.Show();
            }
            else
            {
                //Label label3 = new Label();
                label3.Text = "ФУУУ СТЫДНА НЕ ЗНАТЬ....";
                label3.ForeColor = Color.Red;

                label3.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Hide();
        }
    }
}
