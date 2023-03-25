using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 vote = new Form5();
            vote.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            lbTransport.Text = Form2.transport.ToString();
            lbDestination.Text = Form3.destination.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form5 vote = new Form5();
            vote.Show();
            this.Hide();
        }

        private void lbDestination_Click(object sender, EventArgs e)
        {

        }
    }
}
