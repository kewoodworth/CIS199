// Y8021
// CIS-199-76 Lab 6, Due Sunday 3/25
// Accepts WPM from user, searches parallel arrays to return letter grade

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class Lab6 : Form
    {
        public Lab6()
        {
            InitializeComponent();
        }

        float[] wpmGrades =         { 0, 16, 31, 51, 76 };          //  Array for grade ranges
        char[] letterGrades =       {'F', 'D', 'C', 'B', 'A'};      //  Array for letter grades
        float wpmEntered;                                           //  Variable for user input

        //  User submits input
        private void submitButton_Click(object sender, EventArgs e)
        {
            //  Checks for valid input
            if (float.TryParse(wpm.Text, out wpmEntered) && wpmEntered >= 0)
            {
                wpmEntered = float.Parse(wpm.Text);                 //  Assigns variable from user input
                bool found = false;                                 //  Sets test variable to false

                int index = wpmGrades.Length - 1;                   //  Sets test variable for array

                while (index >= 0 && !found)                         //  Checks index number, and that the answer has not yet been found
                {
                    if (wpmEntered >= wpmGrades[index])             //  Searches array for grade range
                        found = true;                               //  Reassigns test variable to true if found
                    else
                        --index;                                    //  If not yet found in array, decrease index
                }

                if (found)                                          //  If test variable is true
                    gradeLabel.Text = $"{letterGrades[index]}";     //  Output letterGrades sub index to gradeLabel
            }
            else
                MessageBox.Show("Please enter a non-negative integer");     //  Error message if input is not float
        }
    }
}
