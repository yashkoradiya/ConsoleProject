﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class arrrays
    {
        public static void Main1()
        {
            string[] names = { "Mexico", "India", "Brazil", "Paris", "NYC", "Nepal", "SriLanka", "Bhutan" };
            Console.WriteLine(names.Count());
            foreach (string name in names)
                Console.WriteLine(name);
            Array.Sort(names);
            foreach (string name in names)
                Console.WriteLine(name);

            string input;
            Console.WriteLine("Which name do you want to look for?");
            input = Console.ReadLine();

            if (names.Contains(input))
            {
                Console.WriteLine($"{input} is present!");
            }
            else
            {
                Console.WriteLine($"{input} is not present!");
            }
        }
    }
}
