﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPSPracticeProblems
{
    class program
    {
        // adding two integer values.
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        // adding three integer values.
        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }

        // Main Method
        public static void Main(String[] args)
        {
            // Creating Object
            program ob = new program();

            int sum1 = ob.Add(1, 2);
            Console.WriteLine("sum of the two "+ "integer value : " + sum1);

            int sum2 = ob.Add(1, 2, 3);
            Console.WriteLine("sum of the three "+ "integer value : " + sum2);
            Console.ReadLine();
        }
    }
}