namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bTransport_Click(object sender, EventArgs e)
        {
            Form2 selectTransport = new Form2();
            selectTransport.Show();
            this.Hide();
        }
    }
}