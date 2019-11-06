/*  Y8021
 *  CIS 199-75  Lab1  Due Sunday, Jan 28
 *  Requests input from user, preforms calculations, displays output
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab_1
{
    class MainClass
    {
        public static void Main(string[] args)  //  Begin Main method
        {
            float firstNumber;  //  Declares variable firstNumber as float
            float secondNumber;  //  Declares variable secondNumber as float

            Write("Enter 1st floating point number >> ");  //  Requests input from the user
            firstNumber = float.Parse(ReadLine());  //  Converts firstNumber as a string to float

            Write("Enter 2nd floating point number >> ");  //  Requests input from the user
            secondNumber = float.Parse(ReadLine());  //  Converts secondNumber as a string to float

            WriteLine();  //  Enters a blank line between input and output

            float sum = firstNumber + secondNumber;  //  Defines variable sum
            float diff = firstNumber - secondNumber;  //  Defines variable diff
            float product = firstNumber * secondNumber;  //  Defines variable product
            float quotient = firstNumber / secondNumber;  //  Defines variable quotient
            float mean = (firstNumber + secondNumber) / 2;  //  Defines variable mean

            WriteLine($"{firstNumber} + {secondNumber} = {sum:F3}");  //  Displays the formula & result for sum
            WriteLine($"{firstNumber} - {secondNumber} = {diff:f3}");  //  Displays the formula & result for diff
            WriteLine($"{firstNumber} * {secondNumber} = {product:F3}");  //  Displays the formula & result for product
            WriteLine($"{firstNumber} / {secondNumber} = {quotient:F3}");  //  Displays the formula & result for quotient
            WriteLine($"... Mean of {firstNumber} , {secondNumber} = {mean:F3}");  //  Displays the formula & result for mean
        }  //  End Main method
    }
}
