using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OstadAspClass2
{
    public partial class Calculator : Form
    {
        Double totalResult = 0;
        String operatorValue = "";

        public Calculator()
        {
            InitializeComponent();
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            KeyPressMethod(1);
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            KeyPressMethod(2);
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            KeyPressMethod(3);
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            KeyPressMethod(4);
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            KeyPressMethod(5);
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            KeyPressMethod(6);
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            KeyPressMethod(7);
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            KeyPressMethod(8);
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            KeyPressMethod(9);
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            KeyPressMethod(0);


        }

        private void KeyPressMethod(int i)
        {
            if (outPutTextBox.Text == i.ToString())
            {
                outPutTextBox.Text = i.ToString();
            }
            else
            {
                outPutTextBox.Text += i.ToString();
            }
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            
        }

        private void intoButton_Click(object sender, EventArgs e)
        {
            
        }

        private void divButton_Click(object sender, EventArgs e)
        {
           
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            outPutTextBox.Clear();
            outPutTextBox.Text = "0";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {

        }
    }
}
