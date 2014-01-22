/*
 * Justin Trimmer
 * CSC202 - SP14022
 * Project 1 -  Math Ops.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trimmer___CSC202_SP14022___Math_Ops
{
    class Program
    {
        //Array of stings that allows for passing an int into the fetchNumber method.
        static string[] cardinalToOrdinal = new string[3] { "first", "second", "third" };

        static void Main(string[] args)
        {
            /*
             * You must write a C# program that allows the user to input three 
             * integer values. Your program will then determine and display the
             * sum (add them up), average (add them up and divide by three), 
             * product (multiply them together), and the smallest and largest 
             * of the three integer values (find the smallest and largest by 
             * using C#’s if statement). The output of your program should be 
             * clear and easy to read.
            */


            // Declare and use at least 3 integer variables.

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int sum = 0;
            int product = 1;
            int littleNum = 0;
            int bigNum = 0;

            // Declare and use at least 1 float variable.
            float avg = 0.0f;

            // Get three integers from the user.
            // Verivy that the values that the user enters are integers.
            num1 = FetchNumber(0);
            num2 = FetchNumber(1);
            num3 = FetchNumber(2);

            // Determin the sum.
            sum = num1 + num2 + num3;

            // Determine the product.
            product = num1 * num2 * num3;

            //sum = num1 + num2 + num3;

            // Determine the average.
            avg = sum / (float)3;

            //product = num1 * num2 * num3;

            // Determine the smallest
            if (num1 < num2 && num1 < num3)
            {
                littleNum = num1;
            }
            else if (num2 < num3 && num2 < num1)
            {
                littleNum = num2;
            }
            else
            {
                littleNum = num3;
            }

            // Determine the largest.
            if (num1 > num2 && num1 > num3)
            {
                bigNum = num1;
            }
            else if (num2 > num3 && num2 > num1)
            {
                bigNum = num2;
            }
            else
            {
                bigNum = num3;
            }


            // Display the sum, average, product, smallest, and largest.
            Console.WriteLine("\n\nYou entered the numbers {0}, {1}, and {2}.\n", num1, num2, num3);
            Console.WriteLine("The sum is               {0}", sum);
            Console.WriteLine("The average is           {0}", avg);
            Console.WriteLine("The product is           {0}", product);
            Console.WriteLine("The smallest number is   {0}", littleNum);
            Console.WriteLine("The largest number is    {0}", bigNum);

            // Pause the consol so the user can read the input before it closes.
            Console.Write("\nPress any key to continue... ");
            Console.ReadKey(true);
        }

        static int FetchNumber(int numOrder)
        {
            // Method to get the integer input

            int tempNum = 0;
            Console.Write("\nEnter the {0} integer: ", cardinalToOrdinal[numOrder]);
            // Error check the input, and if input is incorrect have the user re-enter.
            while (!int.TryParse(Console.ReadLine(), out tempNum))
            {
                Console.WriteLine("\nPlease enter only an integer value.");
                Console.Write("\nEnter the {0} integer: ", cardinalToOrdinal[numOrder]);
            }
            return tempNum;
        }
    }
}
