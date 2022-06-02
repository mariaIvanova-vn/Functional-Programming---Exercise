using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            int startNum = int.Parse(input.Split()[0]);
            int endNum = int.Parse(input.Split()[1]);  
            List<int> numbers = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                numbers.Add(i);
            }
            string type=Console.ReadLine();
            Predicate<int> isEven = num => num % 2 == 0;
            if (type=="even")
            {
                foreach (var item in numbers)
                {
                    if (isEven(item))
                    {
                        Console.Write(item + " ");
                    }
                }
            }
            else if(type=="odd")
            {
                foreach (var item in numbers)
                {
                    if (!isEven(item))
                    {
                        Console.Write(item + " ");
                    }
                }
            }
        }
    }
}
