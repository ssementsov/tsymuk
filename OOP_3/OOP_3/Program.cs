﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 clas = new Class1(30, "Sidorov");
            clas.PrintFields();
            Console.ReadKey();
        }
    }
}
