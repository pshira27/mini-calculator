using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Calculator
{
    public partial class Calculator : Form
    {
        Result result;

        public Calculator()
        {
            InitializeComponent();
            result = new Result();
        }

        private float readTextBox()
        {
            if (txnDigit.Text.Length <= 0) return 0;
            return float.Parse(txnDigit.Text);
        }

        private void clearTextBox()
        {
            txnDigit.Text = String.Empty;
        }

        private void updateTextBox(String str)
        {
            txnDigit.Text = str;
        }

        private void appendTextBox(String str)
        {
            if (txnDigit.Text.Length >= 12) return;

            txnDigit.Text += str;
        }

        private void popTextBox()
        {
            if (txnDigit.Text.Length <= 0) return;

            txnDigit.Text = txnDigit.Text.Substring(0, txnDigit.Text.Length - 1);
        }

        // NUMBER

        private void btnNum00_Click(object sender, EventArgs e)
        {
            if (txnDigit.Text.Length <= 0) return;
            appendTextBox("00");
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            if (txnDigit.Text.Length <= 0) return;
            appendTextBox("0");
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            appendTextBox("1");
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            appendTextBox("2");
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            appendTextBox("3");
        }


        private void btnNum4_Click(object sender, EventArgs e)
        {
            appendTextBox("4");
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            appendTextBox("5");
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            appendTextBox("6");
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            appendTextBox("7");
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            appendTextBox("8");
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            appendTextBox("9");
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            appendTextBox(".");
        }

        // MATH OPERATION

        private void CalculateAndUpdate()
        {
            result.modifyNumber = readTextBox();
            result.Calculate();
            updateTextBox(result.baseNumber.ToString());
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (result.status == "waitResult")
            {
                result.modifyNumber = readTextBox();
                result.Calculate();
            }

            result.status = "waitOpt";
            updateTextBox(result.baseNumber.ToString());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            popTextBox();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (result.status == "waitOpt")
            {
                result.opt = "div";
                result.status = "waitResult";
                result.baseNumber = readTextBox();
                clearTextBox();
            }
            else if (result.status == "waitResult")
            {
                CalculateAndUpdate();
                result.opt = "div";
                result.status = "waitResult";
                result.baseNumber = readTextBox();
                clearTextBox();
            }
        }

        private void btnPerc_Click(object sender, EventArgs e)
        {
            result.modifyNumber = (readTextBox() * result.baseNumber) / 100;
            result.Calculate();
            result.status = "waitOpt";
            updateTextBox(result.baseNumber.ToString());
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (result.status == "waitOpt")
            {
                result.opt = "mult";
                result.status = "waitResult";
                result.baseNumber = readTextBox();
                clearTextBox();
            }
            else if (result.status == "waitResult")
            {
                CalculateAndUpdate();
                result.opt = "mult";
                result.status = "waitResult";
                result.baseNumber = readTextBox();
                clearTextBox();
            }
        }

        private void btnSqr_Click(object sender, EventArgs e)
        {
            result.opt = "sqr";
            result.status = "waitResult";
            result.baseNumber = readTextBox();
            result.Calculate();
            updateTextBox(result.baseNumber.ToString());
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (result.status == "waitOpt")
            {
                result.opt = "minus";
                result.status = "waitResult";
                result.baseNumber = readTextBox();
                clearTextBox();
            }
            else if (result.status == "waitResult")
            {
                CalculateAndUpdate();
                result.opt = "minus";
                result.status = "waitResult";
                result.baseNumber = readTextBox();
                clearTextBox();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (result.status == "waitOpt")
            {
                result.opt = "plus";
                result.status = "waitResult";
                result.baseNumber = readTextBox();
                clearTextBox();
            }
            else if(result.status == "waitResult")
            {
                CalculateAndUpdate();
                result.opt = "plus";
                result.status = "waitResult";
                result.baseNumber = readTextBox();
                clearTextBox();
            }
        }
    }
}
