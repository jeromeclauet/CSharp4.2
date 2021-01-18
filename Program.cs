using System;
using System.Collections.Generic;

namespace Exercice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(new int[] 
            {
                67, 98, 53, 9
            });
            int sum = 0;
            string calc = "";
            for (int y = 0; y < numbers.Count; y++)
            {
                sum = sum + numbers[y];
            }
            calc = calc + numbers[0];
            for (int x = 1; x < numbers.Count; x++)
            {
                calc = calc + " + " + numbers[x];
            }
            calc = calc + " = " + sum;
            Console.WriteLine(calc);
        }
    }
}