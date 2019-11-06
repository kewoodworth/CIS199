/*  Y8021
 *  CIS 199-75 Lab 5 Due Sunday, March 4
 *  Displays four patterns of stars in rows of 10
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_ROWS = 10;  //  Establishes the row cieling

            //  Pattern A:  Sets row to 1; Tests if the number of rows is less than or equal to the maximum number; Adds a row
            //  Sets stars to 1; tests if number of stars is less than or equal to the number of rows; Adds a star
            WriteLine("Pattern A\n");

            for (int row = 1; row <= MAX_ROWS; row++)
            {
                for (int star = 1; star <= row; star++)
                    Write("*");
                WriteLine();
            }

            //  Pattern B:  Sets row to 1; Tests if the number of rows is less than or equal to the maximum number; Adds a row
            //  Sets stars to 10; Tests if number of stars is more than or equal to the number of rows; Subtracts a star
            WriteLine("\nPattern B\n");

            for (int row = 1; row <= MAX_ROWS; row++)
            {
                for (int star = 10; star >= row; star--)
                    Write("*");
                WriteLine();
            }

            //  Pattern C:  Sets row to 0; Tests if the number of rows is less than or equal to the maximum number; Adds a row
            //  Sets spaces to 0; Tests if number of spaces is less the number of rows; Adds a space
            //  Sets stars to 10; Tests if number of stars is more than the number of rows; Subtracts a star
            WriteLine("\nPattern C\n");

            for (int row = 0; row <= MAX_ROWS; row++)
            {
                for (int space = 0; space < row; space++)
                    Write(" ");
                for (int star = 10; star > row; star--)
                    Write("*");
                WriteLine();
            }

            //  Pattern D:  Sets row to 0; Tests if the number of rows is less than or equal to the maximum number; Adds a row
            //  Sets spaces to 10; Tests if number of spaces is more than the number of rows; Subtracts a space
            //  Sets stars to 0; Tests if number of stars is less than the number of rows; Adds a star
            WriteLine("Pattern D");

            for (int row = 0; row <= MAX_ROWS; row++)
            {
                for (int space = 10; space > row; space--)
                    Write(" ");
                for (int star = 0; star < row; star++)
                    Write("*");
                WriteLine();
            }

        }
    }
}
