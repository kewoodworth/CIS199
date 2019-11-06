//  Y8021
//  CIS 199-75, Lab 7, Due Sunday, April 1
//  Uses a value returning method to calculate the present value needed from user input

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Lab7 : Form
    {
        public Lab7()
        {
            InitializeComponent();
        }

        double myFutureValue, myInterestRate, myPresentValue;   //  Declares variables for user input
        int myYears;                                            //  Declares variable for user input

        //  User inputs information, clicks to calculate
        //  Precondition:  futureValueBox, interestBox, and yearsBox all have positive, valid input
        //  Postcondition:  These values are used to call the method CalcPresentValue, and myPresentValue is shown in presentValueBox
        private void calcButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(futureValueBox.Text, out myFutureValue) && myFutureValue >= 0)
            {
                if (double.TryParse(interestBox.Text, out myInterestRate) && myInterestRate >= 0 && myInterestRate < 1)
                {
                    if (int.TryParse(yearsBox.Text, out myYears) && myYears >= 0)
                    {
                        //  Assigns values from user input
                        myFutureValue = double.Parse(futureValueBox.Text);
                        myInterestRate = double.Parse(interestBox.Text);
                        myYears = int.Parse(yearsBox.Text);

                        //  Calls method to calculate the present value
                        myPresentValue = CalcPresentValue(myFutureValue, myInterestRate, myYears);

                        //  Outputs the needed present value to the form
                        presentValueBox.Text = $"{myPresentValue:C2}";
                    }
                    else
                        MessageBox.Show("Please enter a valid number of years");
                }
                else
                    MessageBox.Show("Please enter your interest rate as a decimal");
            }
            else
                MessageBox.Show("Please enter a valid future value");
        }

        //  Precondition:  future, interest, and years values are provided
        //  Postcondition:  Math is performed to calculate presentValue
        public static double CalcPresentValue(double future, double interest, int years)
        {
            double presentValue;                                        //  Declares variable for the return value
            presentValue = future / Math.Pow(1 + interest, years);      //  Performs math with the variables provided for method arguments
            return presentValue;                                        //  Returns the variable
        }
    }
}
