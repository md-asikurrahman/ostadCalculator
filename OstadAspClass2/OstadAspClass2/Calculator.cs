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
            
            outPutTextBox.Text = outPutTextBox.Text + 1.ToString();
            
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            outPutTextBox.Text = outPutTextBox.Text + 2.ToString();
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            outPutTextBox.Text = outPutTextBox.Text + 3.ToString();  
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            outPutTextBox.Text = outPutTextBox.Text + 4.ToString();
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            outPutTextBox.Text = outPutTextBox.Text + 5.ToString();
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            outPutTextBox.Text = outPutTextBox.Text + 6.ToString();
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            outPutTextBox.Text = outPutTextBox.Text + 7.ToString();
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            outPutTextBox.Text = outPutTextBox.Text + 8.ToString();
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            outPutTextBox.Text = outPutTextBox.Text + 9.ToString();
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            outPutTextBox.Text = outPutTextBox.Text + 0.ToString();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            outPutTextBox.Text = outPutTextBox.Text + "+";
            operatorValue = outPutTextBox.Text;
           // totalResult = double.Parse(outPutTextBox.Text);
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            outPutTextBox.Text = outPutTextBox.Text + "-";
            operatorValue = outPutTextBox.Text;
        }

        private void intoButton_Click(object sender, EventArgs e)
        {
            outPutTextBox.Text = outPutTextBox.Text + "*";
            operatorValue = outPutTextBox.Text;
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            outPutTextBox.Text = outPutTextBox.Text + "/";
            operatorValue = outPutTextBox.Text;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            outPutTextBox.Clear();
        }

        private void equalButton_Click(object sender, EventArgs e)
        {

        }
    }
}
