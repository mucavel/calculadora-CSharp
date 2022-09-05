using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_v1
{
    public partial class Calculator_Form : Form
    {
        string firstNumber = "";
        string secondNumber = "";
        string input = "";
        string MathOperator = "";
        dynamic num1, num2, result;
        public Calculator_Form()
        {
            InitializeComponent();
        }

        private void ClearScreenBtn_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "0";
            firstNumber = "";
            secondNumber = "";
            input = "";
            MathOperator = "";
        }

        private void Num1Btn_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            input += "1";
            calculatorDisplay.Text = input;
        }

        private void Num2Btn_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            input += "2";
            calculatorDisplay.Text = input;
        }

        private void Num3Btn_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            input += "3";
            calculatorDisplay.Text = input;
        }

        private void Num4Btn_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            input += "4";
            calculatorDisplay.Text = input;
        }

        private void Num5Btn_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            input += "5";
            calculatorDisplay.Text = input;
        }

        private void Num6Btn_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            input += "6";
            calculatorDisplay.Text = input;
        }

        private void Num7Btn_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            input += "7";
            calculatorDisplay.Text = input;
        }

        private void Num8Btn_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            input += "8";
            calculatorDisplay.Text = input;
        }

        private void Num9Btn_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            input += "9";
            calculatorDisplay.Text = input;
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            input += "0";
            calculatorDisplay.Text = input;
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            input += ".";
            calculatorDisplay.Text = input;
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            firstNumber = input;
            calculatorDisplay.Text = "0";
            input = "";
            MathOperator = "*";
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {

        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {

        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {

        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            secondNumber = input;
            //num1 = Convert.ToDecimal(firstNumber)
            //num2 = Convert.ToDouble(secondNumber);
            //result = num1 * num2;
            calculatorDisplay.Text = Convert.ToString(Convert.ToDouble(firstNumber) * Convert.ToDouble(secondNumber));
        }
    }
}
