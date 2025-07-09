using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // Try parsing user input
            if (double.TryParse(txtInput.Text, out double temp))
            {
                double result;

                if (rbCelsius.Checked)
                {
                    // Fahrenheit to Celsius
                    result = (temp - 32) * 5 / 9;
                    lblResult.Text = "Result: " + result.ToString("F2") + " °C";
                }
                else if (rbFahrenheit.Checked)
                {
                    // Celsius to Fahrenheit
                    result = (temp * 9 / 5) + 32;
                    lblResult.Text = "Result: " + result.ToString("F2") + " °F";
                }
                else
                {
                    lblResult.Text = "Please select a conversion unit.";
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric temperature.");
            }
        }
    }
}
