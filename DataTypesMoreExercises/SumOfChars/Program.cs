﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                char input = char.Parse(Console.ReadLine());
                result = result + input;
            }

            Console.WriteLine("The sum equals: " + result);

        }
    }
}
