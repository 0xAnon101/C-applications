using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //GLOBAL VARIABLES DECLARED
        bool checkOperatorPressed = false;
        double textValue;
        string operators = "";
        

        //NUMBER CLICK
        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            
            if((ResultBox.Text.StartsWith("0")) || (checkOperatorPressed))
            {
                ResultBox.Text = "";
            }

            checkOperatorPressed = false; // for double digit enterance

            if(b.Text == ".")
            {
                if(!ResultBox.Text.Contains("."))
                {
                    ResultBox.Text = ResultBox.Text + b.Text;
                    equal.Focus();
                }
            }
            else
            {
                ResultBox.Text = ResultBox.Text + b.Text;
                equal.Focus();
            }
          
        }


        //OPERATOR CLICK
        private void operator_Click(object sender, EventArgs e)
        {
            
            Button b = (Button)sender;
            if (textValue != 0)
            {
                equal.PerformClick();
                operators = b.Text;
                displaySide.Text = textValue + " " + operators;
                checkOperatorPressed = true;
                equal.Focus();
            }
            else
            {
                textValue = Double.Parse(ResultBox.Text);
                operators = b.Text;
                displaySide.Text = textValue + " " + operators;
                checkOperatorPressed = true;
                equal.Focus();
            }
        }



        //RESULT BUTTON
        private void button19_Click(object sender, EventArgs e)
        {
            equal.Focus();
            displaySide.Text = "";
            switch(operators)
            {
                case "+":
                    ResultBox.Text = Operator.add(textValue , Double.Parse(ResultBox.Text)).ToString();
                    break;
                case "-":
                    ResultBox.Text = Operator.sub(textValue , Double.Parse(ResultBox.Text)).ToString();
                    break;
                case "*":
                    ResultBox.Text = Operator.mul(textValue , Double.Parse(ResultBox.Text)).ToString();
                    break;
                case "/":
                    ResultBox.Text = Operator.div(textValue ,  Double.Parse(ResultBox.Text)).ToString();
                    break;

            }
            checkOperatorPressed = false;
         
            textValue = Double.Parse( ResultBox.Text);

            operators = "";
        }

        //CLEAR E
        private void button17_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "0";
            displaySide.Text = "";
            equal.Focus();
        }

        //CLEAR ALL
        private void button18_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "0";
            textValue = 0;
            displaySide.Text = "";
            equal.Focus();
        }

        //mod of plus minus
        private void PLUS_MINUS_CLICK(object sender, EventArgs e)
        {

            double Result = Double.Parse(ResultBox.Text);
            
            if (Result < 0)
                ResultBox.Text = Math.Abs(Result).ToString();
            else
                ResultBox.Text = (Result * Double.Parse("-1")).ToString();
            equal.Focus();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case "0":
                    zero.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case "*":
                    mul.PerformClick();
                    break;
                case "+":
                    add.PerformClick();
                    break;
                case "-":
                    sub.PerformClick();
                    break;
                case ".":
                    dec.PerformClick();
                    break;
                case "+/-":
                    plusminus.PerformClick();
                    break;
                case "=":
                    equal.PerformClick();
                    break;
          

            }
        }
    }
}
