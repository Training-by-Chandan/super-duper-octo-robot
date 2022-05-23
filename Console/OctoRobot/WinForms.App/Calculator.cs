using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.App
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            changeNumber(btn.Text);
        }

        private void changeNumber(string num)
        {
            if (num == "." && txtDisplay.Text.ToString().Contains("."))
            {
                return;
            }
            var temp = txtDisplay.Text.ToString();
            temp += num;
            // displayNum = ;
            txtDisplay.Text = temp;
        }

        private double numberOne = 0;
        private double numberTwo = 0;
        private string op = "";

        private void addOperator(string operators)
        {
            numberOne = Convert.ToDouble(txtDisplay.Text);
            op = operators;
            txtDisplay.Clear();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            addOperator(btn.Text);
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            numberTwo = Convert.ToDouble(txtDisplay.Text);
            double result = 0;
            switch (op)
            {
                case "+":
                    result = numberOne + numberTwo;
                    break;

                case "-":
                    result = numberOne - numberTwo;
                    break;

                case "x":
                    result = numberOne * numberTwo;
                    break;

                case "/":
                    result = numberOne / numberTwo;
                    break;

                default:
                    break;
            }
            txtDisplay.Text = result.ToString();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearCalc();
        }

        private void clearCalc()
        {
            numberOne = 0;
            numberTwo = 0;
            op = "";
            txtDisplay.Clear();
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    clearCalc();
                    break;
                case Keys.NumPad0:
                    changeNumber("0");
                    break;
                    case Keys.NumPad1:
                        changeNumber("1");
                    break;
                case Keys.NumPad2:
                    changeNumber("2");
                    break;

                default:
                    break;
            }
        }

        private void Calculator_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}