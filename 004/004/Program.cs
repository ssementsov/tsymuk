﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Hello World");

            for (int i = 0; i < 15; i++)
            {
                Console.BackgroundColor++;
                Console.WriteLine("Hello World");
            }
            Console.ReadLine();
        }
    }
}
