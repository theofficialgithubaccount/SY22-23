using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace neverminditsaformapp
{
    public partial class Form1 : Form
    {
        car c = new car(40);
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ltsButton_Click(object sender, EventArgs e)
        {
            
        }

        public void drive()
        {

        }

        private void turnSignalTimer_Tick(object sender, EventArgs e)
        {
            if (c.left)
            {
                ltsPictureBox.Visible = !ltsPictureBox.Visible;
            }
            if (c.right)
            {
                rtsPictureBox.Visible = !rtsPictureBox.Visible;
            }
            c.drive();
            speedProgressBar.Value = c.speed;
            fuelProgressBar.Value = c.fuel;
            mpgTextBox.Text = c.mpg.ToString();
        }

        private void gasPedalLabel_MouseEnter(object sender, EventArgs e)
        {
            c.Gas = true;
        }

        private void gasPedalLabel_MouseLeave(object sender, EventArgs e)
        {
            c.Gas = false;
        }

        private void ltsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            c.left = true;
            c.right = false;
            rtsPictureBox.Visible = false;
            ltsPictureBox.Visible = true;
        }

        private void rtsRadioButton_CheckedChanged(object sender, EventArgs e)
        {  
            c.left = false;            
            c.right = true;
            ltsPictureBox.Visible = false;
            rtsPictureBox.Visible = true;
        }

        private void tsoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            c.left = false;
            c.right = false;
            ltsPictureBox.Visible = false;
            rtsPictureBox.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ltsPictureBox.Visible = false;
            rtsPictureBox.Visible = false;
            hbPictureBox.Visible = false;
        }

        private void hbRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            hbPictureBox.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            hbPictureBox.Visible = false;
        }
    }
}
