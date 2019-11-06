/* Y8021
 * CIS199-75 Lab 3, Due Sunday 2/11
 * Calculates from a provided radius of a circle
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

namespace Lab_3
{
    public partial class Lab3 : Form
    {
        public Lab3()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            double radius;  //  Defines variable radius
            radius = double.Parse(radiusTextbox.Text);  //  Accepts radius input from user

            double diameter = 2 * radius;  //  Calculates diameter, defines variable
            double surfaceArea = 4 * Math.PI * Math.Pow(radius, 2);  //  Calculates surface area, defines variable
            double volume = 4 * Math.PI * Math.Pow(radius, 3) / 3;  //  Calculates volume, defines variable

            diameterTxt.Text = $" {diameter:F2}";  //  Outputs diameter to label
            surfaceAreaTxt.Text = $" {surfaceArea:F2}";  //  Outputs surface area to label
            volumeTxt.Text = $" {volume:F2}";  //  Outputs volume to label

        }
    }
}
