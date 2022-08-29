using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharpwindowsform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            double amt = 0;
            double.TryParse(amtTextBox.Text, out amt);           
            feeTextBox.Text = fee(amt).ToString();
            this.BackColor = SystemColors.Control;
            if (amt > 500)
                {
                    this.BackColor = Color.Red;
                }
            clear();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear()
        {
            nameTextBox.Clear();
            ccTextBox.Clear();
            expTextBox.Clear();
            zipTextBox.Clear();
            amtTextBox.Clear();
        }

        public double fee(double amt)
        {
            double fee = 0;
            fee = amt * 0.03;
            return fee;
        }
    }
}
