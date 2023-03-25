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
    
    public partial class Form2 : Form
    {
        public static string transport = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            transport = cbTransport.GetItemText(cbTransport.SelectedItem) + ", ";
            transport = transport + cbSeat.GetItemText(cbSeat.SelectedItem);
            if (cbWifi.Checked || cbTrunk.Checked || cbStop.Checked)
            {
                if(cbWifi.Checked)
                {
                    transport = transport + ", " + "has wifi";
                }

                if (cbTrunk.Checked)
                {
                    transport = transport + ", " + "has big trunk";
                }

                if (cbStop.Checked)
                {
                    transport = transport + ", " + "has stopover station";
                }
            }
            else
            {
                transport = transport + ", No Service";
            }
            Form3 selectDestination = new Form3();
            selectDestination.Show();
            this.Hide();
        }

        private void cbTransport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
