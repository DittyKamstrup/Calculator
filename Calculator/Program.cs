﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tast tal");

            string input1 = Console.ReadLine();

            int tal1 = Int32.Parse(input1);

            Console.WriteLine("Tast +, -, * eller /");

            string input2 = Console.ReadLine();

            string faktora = input2;

            Console.WriteLine("Tast tal");

            string input3 = Console.ReadLine();

            int tal2 = Int32.Parse(input3);


            Calculate lommeregner = new Calculate(tal1, faktora, tal2);

            
            Console.WriteLine($"{lommeregner.UdregnFaktorer(tal1, faktora, tal2)}");

            while (true)
            {
                tal1 = lommeregner.UdregnFaktorer(tal1, faktora, tal2);
                Console.WriteLine("Tast +, -, * eller /");

                input2 = Console.ReadLine();

                faktora = input2;

                Console.WriteLine("Tast tal");

                input3 = Console.ReadLine();

                tal2 = Int32.Parse(input3);

                Console.WriteLine($"{lommeregner.UdregnFaktorer(tal1, faktora, tal2)}");
            }






        }
    }
}
