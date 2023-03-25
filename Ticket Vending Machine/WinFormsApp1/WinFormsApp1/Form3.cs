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
    public partial class Form3 : Form
    {
        public static String destination = "";
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            destination = cbStreet.SelectedText + ", " + cbDistrict.SelectedText + ", " + cbCity.SelectedText;
            Form4 selectPayment = new Form4();
            selectPayment.Show();
            this.Hide();
        }

        private void cbTransport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
