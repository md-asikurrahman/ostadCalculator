using System;
using System.Windows.Forms;

namespace OstadAspClass2
{
    public partial class Calculator : Form
    {
        string firstValue = "";
        string secondValue = "";
        string userInput = "";
        double result = 0.0;
        char operatorValue;
        

        public Calculator()
        {
            InitializeComponent();
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            outPutTextBox.Text += "";
            userInput = "1";
            outPutTextBox.Text += userInput;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            outPutTextBox.Text += "";
            userInput = "2";
            outPutTextBox.Text += userInput;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            outPutTextBox.Text += "";
            userInput = "3";
            outPutTextBox.Text += userInput;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            outPutTextBox.Text += "";
            userInput = "4";
            outPutTextBox.Text += userInput;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            outPutTextBox.Text += "";
            userInput = "5";
            outPutTextBox.Text += userInput;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            outPutTextBox.Text += "";
            userInput = "6";
            outPutTextBox.Text += userInput;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            outPutTextBox.Text += "";
            userInput = "7";
            outPutTextBox.Text += userInput;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            outPutTextBox.Text += "";
            userInput = "8";
            outPutTextBox.Text += userInput;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            outPutTextBox.Text += "";
            userInput = "9";
            outPutTextBox.Text += userInput;
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            outPutTextBox.Text += "";
            userInput = "0";
            outPutTextBox.Text += userInput;
        }

     

        private void plusButton_Click(object sender, EventArgs e)
        {
            operatorValue = '+';
            firstValue = userInput;
            userInput = "";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            operatorValue = '-';
            firstValue = userInput;
            userInput = "";
        }

        private void intoButton_Click(object sender, EventArgs e)
        {
            operatorValue = '*';
            firstValue = userInput;
            userInput = "";
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            operatorValue = '/';
            firstValue = userInput;
            userInput = "";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            outPutTextBox.Clear();
            
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            secondValue = userInput;
            double firtsNumber = double.Parse(firstValue);
            double secondNumber =double.Parse(secondValue);
            if (operatorValue == '+')
            {
                result = firtsNumber + secondNumber;
                outPutTextBox.Text = result.ToString();
            }
            else if (operatorValue == '-')
            {
                result = firtsNumber - secondNumber;
                outPutTextBox.Text = result.ToString();
            }
            else if (operatorValue == '*')
            {
                result = firtsNumber * secondNumber;
                outPutTextBox.Text = result.ToString();
            }
            else if (operatorValue == '/')
            {
                result = firtsNumber / secondNumber;
                outPutTextBox.Text = result.ToString();
            }
        }
    }
}
