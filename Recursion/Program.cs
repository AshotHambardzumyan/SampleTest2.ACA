using System;

namespace SampleTest2.ACA
{
    class Program
    {
        /// <summary>
        /// Recursion
        /// Write a recursive function to find sum of numbers from 1 to n
        /// </summary>

        static void Main(string[] args)
        {
            Recursion(1);
        }

        public static void Recursion(int num)
        {
            if (num < 50)
            {
                Console.WriteLine(num);
                Recursion(num + 1);
            }
        }
    }
}