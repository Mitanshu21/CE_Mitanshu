using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Task1
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                numbers.Add(i);
            }
            var x = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("All even numbers between 1 to 100 :- \n");
            foreach (int t in x)
            {
                Console.Write("{0} ", t);
            }
            Console.WriteLine("\n");

            var y = numbers.Where(n => n % 2 != 0);
            Console.WriteLine("All Odd numbers between 1 to 100 :- \n");
            foreach (int t in y)
            {
                Console.Write("{0} ", t);
            }
            Console.WriteLine("\n");

            var z = numbers.Select(n => n * 1);
            Console.WriteLine("All numbers :- \n");
            foreach (int t in z)
            {
                Console.Write("{0} ", t);
            }
            Console.WriteLine("\n");
            var a = numbers.Max();
            Console.WriteLine("Maximum of all :- {0}", a);
            Console.WriteLine("\n");
            var b = numbers.Min();
            Console.WriteLine("Minimum of all :- {0}", b);
            Console.WriteLine("\n");
            var c = numbers.Average();
            Console.WriteLine("Average of all :- {0}", c);
            Console.ReadKey();

        }
    }
}
