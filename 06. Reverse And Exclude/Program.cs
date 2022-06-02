using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers=Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();    
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % n == 0)
                {
                    numbers.Remove(numbers[i]);
                    i--;
                }
            }           
            numbers.ForEach(x => Console.Write(x + " "));
        }
    }
}
