namespace WindowsFormTraining
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //this.Width = 1920;
            //this.Height = 1080;

            this.BackColor = Color.MistyRose;

            button1.Click += button1_Click;

            
        }

        private void DrawImagePointF(PaintEventArgs e)
        {

            //// Create image.
            //Image newImage = Image.FromFile("SampImag.jpg");

            //// Create point for upper-left corner of image.
            //PointF ulCorner = new PointF(100.0F, 100.0F);

            //// Draw image to screen.
            //e.Graphics.DrawImage(newImage, ulCorner);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 ege = new Form2();
            ege.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     
    }
}