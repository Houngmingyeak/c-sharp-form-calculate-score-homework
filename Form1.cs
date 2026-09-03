using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_score_hoemwork_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            // Parse input values from text boxes
            double CSharp = double.Parse(txtc.Text);
            double SQL = double.Parse(txtSQL.Text);
            double Cisco = double.Parse(txtcisco.Text);
            double Dev = double.Parse(txtweb.Text);
            double ODBW = double.Parse(txtodbw.Text);

            // Calculate sum and average
            double Total = CSharp + SQL + Cisco + Dev + ODBW;
            double AVG = Total / 5.0;

            // Display results
            txttotal.Text = Total.ToString();
            txtAvg.Text = AVG.ToString("0.00");
        }
    }
}
