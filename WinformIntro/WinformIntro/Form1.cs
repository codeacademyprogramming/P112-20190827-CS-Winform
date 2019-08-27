using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformIntro
{
    public partial class Form1 : Form
    {
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void MyButtonClicked(object sender, EventArgs e)
        {
            MessageBox.Show("MyButtonClicked method worked");
        }
        private void MyButtonClicked2(object sender, EventArgs e)
        {
            Greeting();
        }

        private void Greeting()
        {
            string nameInput = txtName.Text;
            string surnameInput = txtSurname.Text;
            MessageBox.Show($"Hello {nameInput} {surnameInput}");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (counter >= 10000)
            {
                timer1.Stop();
            }
            else
            {
                if (counter >= 100)
                {
                    timer1.Interval = 10;
                } 
                lblTimer.Text = (++counter).ToString();
            }
       
        }

        private void BtnHello_MouseHover(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void CbxSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSelect.Checked)
            {
                MessageBox.Show("Test 1");
            }
        }

        private void Radio_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton item in pnlRadioButtons.Controls)
            {
                item.Text = "Unchecked";
            }
            RadioButton radio = (RadioButton)sender;
            radio.Text = "Active";
        }
    }
}
