using System;
using System.Collections.Generic;

namespace planet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> Planets = new List<String>();

            Planets.Add("Mercury"); // Adds a plenet to the list
            Planets.Add("Earth"); // Adds a plenet t the list
            Planets.Add("Mars"); // Adds a plenet to the list
            Planets.Add("Jupiter"); // Adds a plenet to the list
            Planets.Add("Saturn"); // Adds a plenet to the list
            Planets.Add("Uranus"); // Adds a plenet to the list
            Planets.Add("Neptune"); // Adds a plenet to the list
            Planets.Add("Pluto"); // Adds a plenet to the list
            
            Planets.ForEach(Console.WriteLine); // Prints the list of Planets

            Console.WriteLine("\n 2nd list with venus \n"); // Skips a line to make room for the next list to appear

            Planets.Insert(1, item: "Venus"); // add a the new item Venus to the list, on index 1 so it appears between Mercury and Earth

            Planets.ForEach(Console.WriteLine); // prints a new list with the new item added

            Console.WriteLine("\n 3rd list with only approved Planets\n"); // Skips a line to make room for the next list to appear

            Planets.RemoveAt(8); // Removes the item at index nr 8 / item nr 9

            Planets.ForEach(Console.WriteLine); // Prints the new list now with item nr 9 removed

            Console.WriteLine("\n 4th list, now with Pluto added once more \n"); // Skips a line to make room for the next list to appear

            Planets.Add("Pluto"); // Will add Pluto to the list again

            Planets.ForEach(Console.WriteLine); // Will print the list again, now with Pluto added

            Console.WriteLine("\n 5th list, displays the amount of items in the list \n"); // Skips a line to make room for the next list to appear

            Console.WriteLine("Count{0}", Planets.Count); // Counts the amount of items in the list and display the result

            Console.WriteLine("\n 6th list, display all the planets with a mean temperature below 0 celcius\n"); // Jumps a few lines to make room for the next list

            List<String> MeanPlanets = new List<String>(); // New list containing the low temperature planets
            MeanPlanets.Add("Mars"); // Adds a planet to the MeanPlanets list
            MeanPlanets.Add("Jupiter"); // Adds a planet to the MeanPlanets list
            MeanPlanets.Add("Saturn"); // Adds a planet to the MeanPlanets list
            MeanPlanets.Add("Uranus"); // Adds a planet to the MeanPlanets list
            MeanPlanets.Add("Neptune"); // Adds a planet to the MeanPlanets list
            MeanPlanets.Add("Pluto"); // Adds a planet to the MeanPlanets list

            MeanPlanets.ForEach(Console.WriteLine); // Prints the MeanPlanets list out to display it

            Console.WriteLine("\n 7th list that displays planets with a diameter above 10.000km but less than 50.000km\n"); // Jumps a few lines to make room for the next list

            List<String> MediumPlanets = new List<String>(); // New list containing the planets with a medium/semi large diameter
            MediumPlanets.Add("Venus"); // Adds a planet to the MediumPlanets list
            MediumPlanets.Add("Earth"); // Adds a planet to the MediumPlanets list
            MediumPlanets.Add("Neptune"); // Adds a planet to the MediumPlanets list

            MediumPlanets.ForEach(Console.WriteLine); // Prints the MediumPlanets list out and displays it

            Planets.RemoveRange(0, 9); // Removes everything within the given range, from index 0 to index 9.

            Console.WriteLine(Planets); // displays the now removed list, or rather nothing since its empty

        } 
    }
}


