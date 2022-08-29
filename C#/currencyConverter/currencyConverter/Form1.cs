using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace currencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            convert(usdTextBox.Text);
        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        public void convert(string input)
        {
            double usd = 0;
            double.TryParse(input, out usd);
            double eur = usd * 1.00;
            double gbp = usd * 0.85;
            double krw = usd * 0.00075;
            double jpy = usd * 137.08;
            double cad = usd * 1.30;
            double rub = usd * 60.38;

            eurTextBox.Text = eur.ToString();
            gbpTextBox.Text = gbp.ToString();
            krwTextBox.Text = krw.ToString();
            jpyTextBox.Text = jpy.ToString();
            cadTextBox.Text = cad.ToString();
            rubTextBox.Text = rub.ToString();
        }

        public void clear()
        {
            eurTextBox.Clear(); 
            gbpTextBox.Clear();
            krwTextBox.Clear();
            jpyTextBox.Clear();
            cadTextBox.Clear();
            rubTextBox.Clear();

        }

    }
}
