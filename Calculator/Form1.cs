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
    public partial class Calculatorform : Form
    {
        public Calculatorform()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            RemoveZero("1");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RemoveZero("2");
        }

        private void RemoveZero(String number)
        {
            if (ResultTextBox.Text == "0")
                ResultTextBox.Text = number; 
            else
                ResultTextBox.Text += number;
        }
    }
}
