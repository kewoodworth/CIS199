/* Y8021
 * CIS199-75 Lab 2, Due Sunday, Feb 4
 * Takes price input from user, returns three possible tip options
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace Lab_2
{
    public partial class Lab2 : Form
    {
        public Lab2()
        {
            InitializeComponent();
        }

        // The following is a result of clicking the calculate button
        private void calcTip_Click(object sender, EventArgs e)
        {
            double mealPrice;  //  Defines variable mealPrice
            mealPrice = double.Parse(priceTextbox.Text);  //  Reads the price input by the user, converts from text to double

            const double LOW_TIP = 0.15;  //  Defines named constant for low tip amount
            const double MED_TIP = 0.18;  //  Defines named constant for med tip amount
            const double HIGH_TIP = 0.20;  //  Defines named constant for high tip amount
            double lowTipAmt = mealPrice * LOW_TIP;  //  Defines variable for the lowest tip,  calculates
            double medTipAmt = mealPrice * MED_TIP;  //  Defines variable for the medium tip,  calculates
            double highTipAmt = mealPrice * HIGH_TIP;  //  Defines variable for the highest tip,  calculates

            lowTip.Text = $"{lowTipAmt:C}";  //  Displays lowest tip in label
            medTip.Text = $"{medTipAmt:C}";  //  Displays medium tip in label
            highTip.Text = $"{highTipAmt:C}";  //  Displays highest tip in label

        }
    }
}
