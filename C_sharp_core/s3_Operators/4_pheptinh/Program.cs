﻿using System;

namespace Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int a = int.Parse(Console.ReadLine());
           int b = int.Parse(Console.ReadLine());
            Console.WriteLine(" a + b = " + (a + b));
            Console.WriteLine(" a - b = " + (a - b));
            Console.WriteLine(" a * b = " + (a * b));
            Console.WriteLine(" a / b = " + (a / b));
        }
    }
}

