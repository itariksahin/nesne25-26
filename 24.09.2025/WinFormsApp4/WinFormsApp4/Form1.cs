namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {   Random rnd= new Random();
            int eksen_x = rnd.Next(-50, 50);
            int eksen_y = rnd.Next(-50, 50);
            button1.Location = new Point(button1.Location.X + eksen_x, button1.Location.Y + eksen_y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TIKLADIN");
        }
    }
}
