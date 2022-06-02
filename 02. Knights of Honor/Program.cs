using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            Func<string,string> addPrefix=name=>"Sir " + name;
 
            foreach (var item in names)
            {
                Console.WriteLine(addPrefix(item));
            }
        }
    }
}
