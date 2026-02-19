using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            totalLabel.Text = total.ToString("c");
        }

        const decimal fiveCent = 0.05m;
        const decimal tenCent = 0.10m;
        const decimal twentyfiveCent = 0.25m;
        const decimal fiftyCent = 0.50m;

        private decimal total;
        private void tenCentButton_Click(object sender, EventArgs e)
        {
            total = total + tenCent;
            totalLabel.Text = total.ToString("c");
        }

        private void fiveCentButton_Click(object sender, EventArgs e)
        {
            total = total + fiveCent;
            totalLabel.Text = total.ToString("c");
        }

        private void twentyfiveCentButton_Click(object sender, EventArgs e)
        {
            total = total + twentyfiveCent;
            totalLabel.Text = total.ToString("c");
        }

        private void fiftyCentButton_Click(object sender, EventArgs e)
        {
            total = total + fiftyCent;
            totalLabel.Text = total.ToString("c");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            total = total - total;
            totalLabel.Text = total.ToString("c");
        }
        private void totalLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
