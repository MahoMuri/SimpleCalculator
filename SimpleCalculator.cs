using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class SimpleCalculator : Form
    {
        private bool hasDecimal = false;
        private bool isOperation = false;
        private readonly DataTable dt = new DataTable();
        private double result = 0;
        private double initResult = 0;
        private bool hasResult = false;
        private string num1 = "";
        private string num2 = "";
        private string operation = "";
        private string expression = "";
        private readonly char[] operators = { '+', '-', '×', '÷' };

        public SimpleCalculator()
        {
            InitializeComponent();
        }

        private void SimpleCalculator_Load(object sender, EventArgs e)
        {
            UtilityDisplay.Text = null;
            MainDisplay.Text = "0";
        }

        // First Row
        private void Number7_Click(object sender, EventArgs e)
        {
            if (hasResult)
            {
                Clear();
            }
            if (isOperation)
            {
                MainDisplay.Text = null;
                isOperation = false;
            }
            _ = MainDisplay.Text == "0" ? MainDisplay.Text = "7" : MainDisplay.Text += "7";
        }

        private void Number8_Click(object sender, EventArgs e)
        {
            if (hasResult)
            {
                Clear();
            }
            if (isOperation)
            {
                MainDisplay.Text = null;
                isOperation = false;
            }
            _ = MainDisplay.Text == "0" ? MainDisplay.Text = "8" : MainDisplay.Text += "8";
        }

        private void Number9_Click(object sender, EventArgs e)
        {
            if (hasResult)
            {
                Clear();
            }
            if (isOperation)
            {
                MainDisplay.Text = null;
                isOperation = false;
            }
            _ = MainDisplay.Text == "0" ? MainDisplay.Text = "9" : MainDisplay.Text += "9";
        }

        // Second Row
        private void Number4_Click(object sender, EventArgs e)
        {
            if (hasResult)
            {
                Clear();
            }
            if (isOperation)
            {
                MainDisplay.Text = null;
                isOperation = false;
            }
            _ = MainDisplay.Text == "0" ? MainDisplay.Text = "4" : MainDisplay.Text += "4";
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            if (hasResult)
            {
                Clear();
            }
            if (isOperation)
            {
                MainDisplay.Text = null;
                isOperation = false;
            }
            _ = MainDisplay.Text == "0" ? MainDisplay.Text = "5" : MainDisplay.Text += "5";
        }

        private void Number6_Click(object sender, EventArgs e)
        {
            if (hasResult)
            {
                Clear();
            }
            if (isOperation)
            {
                MainDisplay.Text = null;
                isOperation = false;
            }
            _ = MainDisplay.Text == "0" ? MainDisplay.Text = "6" : MainDisplay.Text += "6";
        }

        // Third Row
        private void Number1_Click(object sender, EventArgs e)
        {
            if (hasResult)
            {
                Clear();
            }
            if (isOperation)
            {
                MainDisplay.Text = null;
                isOperation = false;
            }
            _ = MainDisplay.Text == "0" ? MainDisplay.Text = "1" : MainDisplay.Text += "1";
        }

        private void Number2_Click(object sender, EventArgs e)
        {
            if (hasResult)
            {
                Clear();
            }
            if (isOperation)
            {
                MainDisplay.Text = null;
                isOperation = false;
            }
            _ = MainDisplay.Text == "0" ? MainDisplay.Text = "2" : MainDisplay.Text += "2";
        }

        private void Number3_Click(object sender, EventArgs e)
        {
            if (hasResult)
            {
                Clear();
            }
            if (isOperation)
            {
                MainDisplay.Text = null;
                isOperation = false;
            }
            _ = MainDisplay.Text == "0" ? MainDisplay.Text = "3" : MainDisplay.Text += "3";
        }

        // Fourth Row
        private void Number0_Click(object sender, EventArgs e)
        {
            if (hasResult)
            {
                Clear();
            }
            if (isOperation)
            {
                MainDisplay.Text = null;
                isOperation = false;
            }
            _ = MainDisplay.Text == "0" ? MainDisplay.Text = "0" : MainDisplay.Text += "0";
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (isOperation)
            {
                MainDisplay.Text = "0";
                isOperation = false;
            }
            if (!hasDecimal)
            {
                MainDisplay.Text += ".";
                hasDecimal = true;
            }
        }

        // Start Calculating
        private void EnterButton_Click(object sender, EventArgs e)
        {
            string[] stringArr = (UtilityDisplay.Text + MainDisplay.Text).Split(' ');
            //if (stringArr.Length != 3)
            //{
            //    UtilityDisplay.Text = stringArr[0] + " =";
            //    return;
            //}
            num1 = stringArr[0];
            operation = stringArr[1];
            num2 = stringArr[2];


            expression = result == 0 ? num1 + " " + operation + " " + num2 : result.ToString() + " " + operation + " " + num2;
            result = Calculate(expression);
            if (result == Double.PositiveInfinity)
            {
                MainDisplay.Text = "Cannot divide by zero";
                return;
            }

            if (result == Double.NaN)
            {
                MainDisplay.Text = "NaN";
                return;
            }

            UtilityDisplay.Text = expression + " =";
            MainDisplay.Text = result.ToString();
            hasResult = true;
        }

        // Operation Buttons
        private void AdditionButton_Click(object sender, EventArgs e)
        {
            // If the calculator is not in operation state
            if (!isOperation)
            {
                if (UtilityDisplay.Text.Length > 0 && result == 0)
                {
                    initResult = Calculate(UtilityDisplay.Text + MainDisplay.Text);
                    UtilityDisplay.Text = initResult.ToString() + " + ";
                    MainDisplay.Text = initResult.ToString();

                }
                else
                {
                    UtilityDisplay.Text = result == 0 ? UtilityDisplay.Text += MainDisplay.Text + " + " : result.ToString() + " + ";
                    hasResult = false;
                }
            }
            else
            {
                foreach (char oper in operators)
                {
                    UtilityDisplay.Text = UtilityDisplay.Text.Replace(oper, '+');
                }
            }
            isOperation = true;
            hasDecimal = false;
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            if (!isOperation)
            {
                if (UtilityDisplay.Text.Length > 0 && result == 0)
                {
                    initResult = Calculate(UtilityDisplay.Text + MainDisplay.Text);
                    UtilityDisplay.Text = initResult.ToString() + " - ";
                    MainDisplay.Text = initResult.ToString();

                }
                else
                {
                    UtilityDisplay.Text = result == 0 ? UtilityDisplay.Text += MainDisplay.Text + " - " : result.ToString() + " - ";
                    hasResult = false;
                }
            }
            else
            {
                foreach (char oper in operators)
                {
                    UtilityDisplay.Text = UtilityDisplay.Text.Replace(oper, '-');
                }
            }
            string[] stringArr = UtilityDisplay.Text.Split(' ');
            num1 = stringArr[0];
            operation = stringArr[1];
            num2 = MainDisplay.Text;
            isOperation = true;
            hasDecimal = false;
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            if (!isOperation)
            {
                if (UtilityDisplay.Text.Length > 0 && !hasResult)
                {
                    initResult = Calculate(UtilityDisplay.Text + MainDisplay.Text);
                    UtilityDisplay.Text = initResult.ToString() + " × ";
                    MainDisplay.Text = initResult.ToString();

                }
                else
                {
                    UtilityDisplay.Text = result == 0 ? UtilityDisplay.Text += MainDisplay.Text + " × " : result.ToString() + " × ";
                    hasResult = false;
                }
            }
            else
            {
                foreach (char oper in operators)
                {
                    UtilityDisplay.Text = UtilityDisplay.Text.Replace(oper, '×');
                }
            }
            string[] stringArr = UtilityDisplay.Text.Split(' ');
            num1 = stringArr[0];
            operation = stringArr[1];
            num2 = MainDisplay.Text;
            isOperation = true;
            hasDecimal = false;
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (!isOperation)
            {
                if (UtilityDisplay.Text.Length > 0 && result == 0)
                {
                    initResult = Calculate(UtilityDisplay.Text + MainDisplay.Text);
                    UtilityDisplay.Text = initResult.ToString() + " ÷ ";
                    MainDisplay.Text = initResult.ToString();
                }
                else
                {
                    UtilityDisplay.Text = result == 0 ? UtilityDisplay.Text += MainDisplay.Text + " ÷ " : result.ToString() + " ÷ ";
                    hasResult = false;
                }
            }
            else
            {
                foreach (char oper in operators)
                {
                    UtilityDisplay.Text = UtilityDisplay.Text.Replace(oper, '÷');
                }
            }
            string[] stringArr = UtilityDisplay.Text.Split(' ');
            num1 = stringArr[0];
            operation = stringArr[1];
            num2 = MainDisplay.Text;
            isOperation = true;
            hasDecimal = false;
        }

        // Misc. 
        private void ClearButton_Click(object sender, EventArgs e)
        {
            MainDisplay.Text = "0";
            UtilityDisplay.Text = null;
            hasDecimal = false;
            hasResult = false;
            result = 0;
        }

        private void MainDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the pressed character is not a number, do nothing
            var regex = new Regex(@"[^0-9\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                Console.WriteLine("Not a number");
                e.Handled = true;
                return;
            }

            if (isOperation)
            {
                MainDisplay.Text = null;
                isOperation = false;
            }
        }

        private void MainDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    EnterButton_Click(sender, e);
                    break;
                case Keys.Add:
                    AdditionButton_Click(sender, e);
                    break;
                case Keys.Subtract:
                    SubtractButton_Click(sender, e);
                    break;
                case Keys.Divide:
                    DivideButton_Click(sender, e);
                    break;
                case Keys.Multiply:
                    MultiplyButton_Click(sender, e);
                    break;
                case Keys.OemPeriod:
                case Keys.Decimal:
                    DecimalButton_Click(sender, e);
                    break;
                default:
                    break;
            }
        }


        private void UtilityDisplay_Click(object sender, EventArgs e)
        {

        }

        // Method for Calculating the expression
        private double Calculate(string expression)
        {
            return Double.Parse(dt.Compute(expression.Replace('×', '*').Replace('÷', '/'), "").ToString());
        }

        private void Clear()
        {
            UtilityDisplay.Text = null;
            MainDisplay.Text = null;
            hasResult = false;
        }

    }
}
