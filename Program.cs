using System;
using System.Collections.Generic;

namespace ConsoleAppArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------
            // STRING ARRAY SECTION
            // -----------------------------

            // Create a one-dimensional array of strings
            string[] fruits = { "Apple", "Banana", "Cherry", "Mango", "Orange" };

            // Ask user to select an index
            Console.WriteLine("Select an index (0-4) to see a fruit:");

            // Read user input
            string fruitInput = Console.ReadLine();

            // Convert input safely to integer
            if (int.TryParse(fruitInput, out int fruitIndex))
            {
                // Check if index exists in array
                if (fruitIndex >= 0 && fruitIndex < fruits.Length)
                {
                    Console.WriteLine("You selected: " + fruits[fruitIndex]);
                }
                else
                {
                    Console.WriteLine("That index does not exist in the fruit array.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            // -----------------------------
            // INTEGER ARRAY SECTION
            // -----------------------------

            // Create a one-dimensional array of integers
            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.WriteLine("\nSelect an index (0-4) to see a number:");

            string numberInput = Console.ReadLine();

            if (int.TryParse(numberInput, out int numberIndex))
            {
                if (numberIndex >= 0 && numberIndex < numbers.Length)
                {
                    Console.WriteLine("You selected: " + numbers[numberIndex]);
                }
                else
                {
                    Console.WriteLine("That index does not exist in the number array.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            // -----------------------------
            // LIST SECTION
            // -----------------------------

            // Create a list of strings
            List<string> colors = new List<string> 
            { 
                "Red", 
                "Blue", 
                "Green", 
                "Yellow", 
                "Purple" 
            };

            Console.WriteLine("\nSelect an index (0-4) to see a color:");

            string colorInput = Console.ReadLine();

            if (int.TryParse(colorInput, out int colorIndex))
            {
                if (colorIndex >= 0 && colorIndex < colors.Count)
                {
                    Console.WriteLine("You selected: " + colors[colorIndex]);
                }
                else
                {
                    Console.WriteLine("That index does not exist in the color list.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            // Keep console open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}