using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Assignment Part 1
        //Three strings that will be combined together
        string lineOne = "Beware; ";
        string lineTwo = "for I am fearless, ";
        string lineThree = "and therefore powerful.";

        //Display the combined sentence
        Console.WriteLine(lineOne + lineTwo + lineThree);

        //Assignment Part 2
        //Convert a string to uppercase
        string x = "who controls the past controls the future.";
        Console.WriteLine(x.ToUpper());

        //Console App Assignment Part 1
        //Create an array of strings
        string[] words = { "This is first sentence ", "This is second sentence ", "This is third sentence " };

        //Ask the user for input
        Console.WriteLine("Please enter some text:");
        string userInput = Console.ReadLine() ?? "";

        //Loop through the array and append user text to each element
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i] + userInput;
        }

        //Loop again to print each updated string
        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine(words[i]);
        }

        //Console App Assignment Part 2
        //Initialize a counter variable
        int counter = 0;

        //Loop runs while counter is less than 5
        //The counter increments each time so the loop ends
        while (counter < 5)
        {
            Console.WriteLine("Counter value: " + counter);
            counter++;
        }

        //Console App Assignment Part 3

        //Loop using "<"
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Loop with < operator: " + i);
        }

        //Loop using "<="
        for (int j = 0; j <= 5; j++)
        {
            Console.WriteLine("Loop with <= operator: " + j);
        }

        //Console App Assignment Part 4

        //Create a list of unique colors
        List<string> colors = new List<string>() { "Red", "Blue", "Green", "Yellow", "Purple" };

        //Ask user to search for a color
        Console.WriteLine("Enter a color to search for in the list:");
        string searchText = Console.ReadLine() ?? "";

        //Boolean variable to track if the item is found
        bool found = false;

        //Loop through the list to find the matching color
        for (int i = 0; i < colors.Count; i++)
        {
            if (colors[i].Equals(searchText, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Item found at index: " + i);
                found = true;
                break; //Stops the loop after a match is found
            }
        }

        //If no match was found, notify the user
        if (!found)
        {
            Console.WriteLine("Your input is not on the list.");
        }

        //Console App Assignment Part 5

        //Create a list with duplicate items
        List<string> animals = new List<string>() { "Cat", "Dog", "Bird", "Dog", "Fish", "Cat" };

        //Ask the user to search for an animal
        Console.WriteLine("Enter an animal to search for:");
        string animalSearch = Console.ReadLine() ?? "";

        //Track if a match was found
        bool matchFound = false;

        //Loop through the list and display all matching indices
        for (int i = 0; i < animals.Count; i++)
        {
            if (animals[i].Equals(animalSearch, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Match found at index: " + i);
                matchFound = true;
            }
        }

        //If no match was found
        if (!matchFound)
        {
            Console.WriteLine("Your input is not on the list.");
        }

        //Console App Assignment Part 6

        //Create a list with duplicate strings
        List<string> letters = new List<string>() { "A", "B", "C", "D", "C" };

        //Create a HashSet to track items that have already appeared
        HashSet<string> seen = new HashSet<string>();

        //Loop through each item in the list
        foreach (string letter in letters)
        {
            //If the item is already in the HashSet, it is a duplicate
            if (seen.Contains(letter))
            {
                Console.WriteLine(letter + " - this item is a duplicate");
            }
            else
            {
                //Otherwise the item is unique
                Console.WriteLine(letter + " - this item is unique");

                //Add the item to the HashSet so we remember it
                seen.Add(letter);
            }
        }
    }
}