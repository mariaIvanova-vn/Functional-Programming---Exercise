using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = Console.ReadLine().Split().Select(int.Parse).Distinct().ToArray();

            List<int> nn = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                bool isT = true;

                foreach (int item in nums)
                {
                    Predicate<int> isDivisible = x => i % x == 0;

                    if (!isDivisible(item))
                    {
                        isT = false;
                        break;
                    }
                }
                if (isT)
                {
                    nn.Add(i);
                }
            }
            Console.WriteLine(string.Join(' ', nn));
        }
    }
}