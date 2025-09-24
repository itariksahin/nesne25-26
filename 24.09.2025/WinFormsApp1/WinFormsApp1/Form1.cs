namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            /*MessageBox.Show("Mouse üzerindedir");*/
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("Mouse artýk üzerinde deðil.");
        }
    }
}
