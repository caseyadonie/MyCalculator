using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        string operand = "";
        double firstInput = 0;
        double initialInput = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void bttn0_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            firstInput =int.Parse(button.Text);
            LblDisplay.Text = button.Text;

        }

        private void bttnPlus_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            initialInput = firstInput;
            operand = button.Text;

        }

        private void bttnEqual_Click(object sender, EventArgs e)
        {
            try
            {


                switch (operand)
                {
                    case "+":
                        LblDisplay.Text = (firstInput + initialInput).ToString();
                        break;
                    default:

                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
            LblDisplay.Text = "0";
             operand = "";
             firstInput = 0;
             initialInput = 0;

        }
    }
}
