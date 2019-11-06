/* Y8021
 * CIS 199-75 Lab4, Due Sun, Feb 18
 * Accept or Reject applicant based on GPA & Test score
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

namespace Lab4
{
    public partial class Lab4 : Form
    {
        public Lab4()
        {
            InitializeComponent();
        }

        float gpa, admission;  //  Declares float varaibles for GPA and admission test score
        int accept, reject;  //  Declares float variables for number of students accepted or rejected

        private void acceptLabel_Click(object sender, EventArgs e)
        {
            // oops
        }

        private void submitbutton_Click(object sender, EventArgs e)  //  Submit button clicked
        {
            if (float.TryParse(admissionBox.Text, out admission))  //  Check if admission test score entered is correct type float
            {
                if (float.TryParse(gpaBox.Text, out gpa))  //  Check if gpa entered is correct type float
                {
                    gpa = float.Parse(gpaBox.Text);  //  Assigns gpa to number entered in gpaBox
                    admission = float.Parse(admissionBox.Text);  //  Assigns admission test score to number entered in admissionBox
                    const float MIN_GPA = 3.000F;  //  Establishes the minimum GPA to be used in evaluations
                    const float LOW_TEST_SCORE = 60;  //  Establishes the low test score to be used in evaluations
                    const float HIGH_TEST_SCORE = 80;  //  Establishes the high test score to be used in evaluations

                    if (gpa >= MIN_GPA && admission >= LOW_TEST_SCORE || gpa < MIN_GPA && admission >= HIGH_TEST_SCORE)
                        resultBox.Text = $"Accepted!";  //  If above requirements are met
                    else
                        resultBox.Text = $"Rejected";  //  If above requirements are not met

                    if (gpa < 0 || gpa > 6.000)  //  Ensures GPA entered is standard
                        resultBox.Text = "Invalid GPA";

                    if (admission < 0 || admission > 120)  //  Ensures admission test score is standard
                        resultBox.Text = "Invalid admission score";

                    if (resultBox.Text == "Accepted!")
                        acceptTotal.Text = $"{++accept}";  //  Running total of accepted
                    else
                       if (resultBox.Text == "Rejected")
                        rejectTotal.Text = $"{++reject}";  //  Running total of rejected
                }
                else
                    resultBox.Text = "Enter a valid GPA";  //  Error is shown if non-float GPA is entered
            }
            else
                resultBox.Text = "Enter a valid test score";  //  Error is shown if non-float GPA is entered
        }
    }
}
