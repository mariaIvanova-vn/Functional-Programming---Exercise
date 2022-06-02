using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            List<string> names=Console.ReadLine().Split().ToList();
            Predicate<string> isLong = name => name.Length <= n;
            foreach (var item in names)
            {
                if (isLong(item))
                {
                    Console.WriteLine(item + " ");
                }
            }
        }
    }
}
