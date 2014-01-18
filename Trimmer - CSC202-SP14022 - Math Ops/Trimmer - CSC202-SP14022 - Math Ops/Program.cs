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
            int product = 0;
            int littleNum = 0;
            int bigNum = 0;

            // Declare and use at least 1 float variable.
            float avg = 0.0f;

            // Get three integers from the user.
            // Verivy that the values that the user enters are integers.
            Console.Write("\nEnter the first integer: ");
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("\nPlease enter only an integer value.");
                Console.Write("Enter the first integer: ");
            }

            Console.Write("\nEnter the second integer: ");
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("\nPlease enter only an integer value.");
                Console.Write("Enter the second integer: ");
            }

            Console.Write("\nEnter the third integer: ");
            while (!int.TryParse(Console.ReadLine(), out num3))
            {
                Console.WriteLine("\nPlease enter only an integer value.");
                Console.Write("Enter the third integer: ");
            }

            // Determin the sum.
            sum = num1 + num2 + num3;

            // Determine the average.
            avg = sum / 3.0f;

            // Determine the product.
            product = num1 * num2 * num3;

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
            Console.WriteLine("\n\nThe sum is " + sum.ToString());
            Console.WriteLine("The average is {0}.", avg);
            Console.WriteLine("The product is {0}.", product);
            Console.WriteLine("The smallest number is {0}.", littleNum);
            Console.WriteLine("The largest number is {0}.", bigNum);

            // Pause the consol so the user can read the input before it closes.
            Console.Write("\nPress any key to continue... ");
            Console.ReadKey(true);
        }
    }
}
