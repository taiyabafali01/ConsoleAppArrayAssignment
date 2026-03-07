using System;
using System.Collections.Generic;

namespace ConsoleAppArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of integers
            List<int> numbers = new List<int>() { 10, 20, 30, 40, 50 };

            try
            {
                // Ask the user to enter a number
                Console.WriteLine("Enter a number to divide each number in the list by:");

                // Convert user input to integer
                int divisor = Convert.ToInt32(Console.ReadLine());

                // Loop through each number in the list
                foreach (int number in numbers)
                {
                    // Divide and display result
                    Console.WriteLine(number + " divided by " + divisor + " = " + (number / divisor));
                }
            }

            // Catch divide by zero error
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: You cannot divide by zero.");
                Console.WriteLine(ex.Message);
            }

            // Catch invalid string input
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Please enter a valid number.");
                Console.WriteLine(ex.Message);
            }

            // Catch any other unexpected errors
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine(ex.Message);
            }

            // Message showing program continued
            Console.WriteLine("The program continued after the try/catch block.");

            Console.ReadKey();
        }
    }
}