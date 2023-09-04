using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FractionCalculator
{
    public partial class frmFractionCalculator : Form
    {
        public frmFractionCalculator()
        {
            InitializeComponent();
        }

        private void txtFirstNumerator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;
        }

        private void txtFirstDenominator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;
        }

        private void txtSecondNumerator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;
        }

        private void txtSecondDenominator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;
            
        }

        private void btnPerformOperations_Click(object sender, EventArgs e)
        {
            int firstNumerator = int.Parse(txtFirstNumerator.Text);
            int firstDenominator = int.Parse(txtFirstDenominator.Text);
            int secondNumerator = int.Parse(txtSecondNumerator.Text);
            int secondDenominator = int.Parse(txtSecondDenominator.Text);
            Fraction result = null;

           Fraction firstFraction = new Fraction(firstNumerator, firstDenominator);
           Fraction secondFraction = new Fraction(secondNumerator, secondDenominator);
            
            if (rbtnAdd.Checked == true)
            {
               result = Fraction.Add(firstFraction, secondFraction);
            }
            else if (rbtnSubtract.Checked == true)
            {
                result  = Fraction.Subtract(firstFraction, secondFraction);
            }
            else if (rbtnMultiply.Checked == true)
            {
                result = Fraction.Multiply(firstFraction, secondFraction);
            }
            else if (rbtnDivide.Checked == true)
            {
                result = Fraction.Divide(firstFraction, secondFraction);   
            }

            txtResultNumerator.Text = result.Numerator.ToString();
            txtResultDenominator.Text = result.Denominator.ToString();
        }

       
    }
}
