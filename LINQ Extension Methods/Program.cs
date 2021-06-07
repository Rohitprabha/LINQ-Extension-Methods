using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> EvenNumbers = Enumerable.Where(intList, n => n % 2 == 0);
            foreach (int x in EvenNumbers)
                Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
