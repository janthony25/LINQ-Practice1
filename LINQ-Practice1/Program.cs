﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            OddNumbers(numbers);

            Console.ReadKey();
        }

        static void OddNumbers(int[] numbers)
        {
            Console.WriteLine("Odd Numbers");

            IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;
            Console.WriteLine(oddNumbers);
            foreach(var i in oddNumbers)
            {
                Console.WriteLine(i);
            }
        }
       
    }
}
