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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            label4.Text = "а";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label4.Text = "б";
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            label4.Text = "в";
        }
    }
}
