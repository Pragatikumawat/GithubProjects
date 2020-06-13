using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerform = "";
        bool isOperation = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            resultValue = 0;
            labelCurrentOperation.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBoxResult.Text == "0")||(isOperation))
            {
                textBoxResult.Clear();
            }
            isOperation = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBoxResult.Text.Contains("."))
                {
                    textBoxResult.Text = textBoxResult.Text + button.Text;
                }
            }else
            textBoxResult.Text = textBoxResult.Text + button.Text;
           
        }

        private void TextBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                button16.PerformClick();
                operationPerform = button.Text;
                labelCurrentOperation.Text = resultValue + "" + operationPerform;
                isOperation = true;
            }
            else
            {
                operationPerform = button.Text;
                resultValue = Double.Parse(textBoxResult.Text);
                labelCurrentOperation.Text = resultValue + "" + operationPerform;
                isOperation = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (operationPerform)
            {
                case "+":
                    textBoxResult.Text = (resultValue + double.Parse(textBoxResult.Text)).ToString() ;
                    break;
                case "-":
                    textBoxResult.Text = (resultValue - double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "*":
                    textBoxResult.Text = (resultValue * double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "/":
                    textBoxResult.Text = (resultValue / double.Parse(textBoxResult.Text)).ToString();
                    break;
                default:
                    break;

            }
            resultValue = Double.Parse(textBoxResult.Text);
            labelCurrentOperation.Text = "";
            }
        }
}

