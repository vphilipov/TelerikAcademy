using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _6.WebCalculator
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn0_Click(object sender, EventArgs e)
        {
            this.Display.Text = this.Display.Text + "0";
        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
            this.Display.Text = this.Display.Text + "1";
        }

        protected void Btn2_Click(object sender, EventArgs e)
        {
            this.Display.Text = this.Display.Text + "2";
        }

        protected void Btn3_Click(object sender, EventArgs e)
        {
            this.Display.Text = this.Display.Text + "3";
        }

        protected void Btn4_Click(object sender, EventArgs e)
        {
            this.Display.Text = this.Display.Text + "4";
        }

        protected void Btn5_Click(object sender, EventArgs e)
        {
            this.Display.Text = this.Display.Text + "5";
        }

        protected void Btn6_Click(object sender, EventArgs e)
        {
            this.Display.Text = this.Display.Text + "6";
        }

        protected void Btn7_Click(object sender, EventArgs e)
        {
            this.Display.Text = this.Display.Text + "7";
        }

        protected void Btn8_Click(object sender, EventArgs e)
        {
            this.Display.Text = this.Display.Text + "8";
        }

        protected void Btn9_Click(object sender, EventArgs e)
        {
            this.Display.Text = this.Display.Text + "9";
        }

        protected void Plus_Click(object sender, EventArgs e)
        {
            if (ViewState["currentOperator"] != null)
            {
                this.PerformMathOperation();
            }

            ViewState["currentNumber"] = double.Parse(this.Display.Text);
            ViewState["currentOperator"] = Operator.Add;
            this.Display.Text = "";
        }

        protected void Minus_Click(object sender, EventArgs e)
        {
            if (ViewState["currentOperator"] != null)
            {
                this.PerformMathOperation();
            }

            ViewState["currentNumber"] = double.Parse(this.Display.Text);
            ViewState["currentOperator"] = Operator.Subtract;
            this.Display.Text = "";
        }

        protected void Multiply_Click(object sender, EventArgs e)
        {
            if (ViewState["currentOperator"] != null)
            {
                this.PerformMathOperation();
            }

            ViewState["currentNumber"] = double.Parse(this.Display.Text);
            ViewState["currentOperator"] = Operator.Multiply;
            this.Display.Text = "";
        }

        protected void Divide_Click(object sender, EventArgs e)
        {
            if (ViewState["currentOperator"] != null)
            {
                this.PerformMathOperation();
            }

            ViewState["currentNumber"] = double.Parse(this.Display.Text);
            ViewState["currentOperator"] = Operator.Divide;
            this.Display.Text = "";
        }

        protected void Sqrt_Click(object sender, EventArgs e)
        {
            if (ViewState["currentOperator"] != null)
            {
                this.PerformMathOperation();
            }

            ViewState["currentNumber"] = double.Parse(this.Display.Text);
            ViewState["currentOperator"] = Operator.Sqrt;
            this.PerformMathOperation();
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            this.Display.Text = "";
            ViewState.Remove("currentNumber");
            ViewState.Remove("currentOperator");
        }

        protected void Equals_Click(object sender, EventArgs e)
        {
            this.PerformMathOperation();
        }

        private void PerformMathOperation()
        {
            Operator currentOperator = Operator.None;

            if (ViewState["currentOperator"] != null)
            {
                currentOperator = (Operator)ViewState["currentOperator"];
            }

            switch (currentOperator)
            {
                case Operator.None:
                    break;
                case Operator.Add: PerformAdd();
                    break;
                case Operator.Subtract: PerformSubtract();
                    break;
                case Operator.Multiply: PerformMultiply();
                    break;
                case Operator.Divide: PerformDivide();
                    break;
                case Operator.Sqrt: PerformSqrt();
                    break;
                default: this.Display.Text = "Ooops!";
                    break;
            }

            ViewState.Remove("currentOperator");
        }

        private void PerformSqrt()
        {
            double firstNum = double.Parse(ViewState["currentNumber"].ToString());
            double result = Math.Sqrt(firstNum);
            ViewState["currentNumber"] = result;
            this.Display.Text = result.ToString();
        }

        private void PerformDivide()
        {
            double firstNum = double.Parse(ViewState["currentNumber"].ToString());
            double secondNum = double.Parse(this.Display.Text);
            double result = firstNum / secondNum;
            ViewState["currentNumber"] = result;
            this.Display.Text = result.ToString();
        }

        private void PerformMultiply()
        {
            double firstNum = double.Parse(ViewState["currentNumber"].ToString());
            double secondNum = double.Parse(this.Display.Text);
            double result = firstNum * secondNum;
            ViewState["currentNumber"] = result;
            this.Display.Text = result.ToString();
        }

        private void PerformSubtract()
        {
            double firstNum = double.Parse(ViewState["currentNumber"].ToString());
            double secondNum = double.Parse(this.Display.Text);
            double result = firstNum - secondNum;
            ViewState["currentNumber"] = result;
            this.Display.Text = result.ToString();
        }

        private void PerformAdd()
        {
            double firstNum = double.Parse(ViewState["currentNumber"].ToString());
            double secondNum = double.Parse(this.Display.Text);
            double result = firstNum + secondNum;
            ViewState["currentNumber"] = result;
            this.Display.Text = result.ToString();
        }
    }
}