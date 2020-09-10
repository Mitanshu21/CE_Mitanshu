using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "mitanshu", "raj", "viraj", "bhautik", "Kevin", "matt", "jay", "brij", "shashank", "dhruv" };
            var x = names.Where(s => s.StartsWith("K"));
            Console.WriteLine("Names starts with 'K' :- ");
            foreach (string s in x)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Names length less than 4 :-");
            var y = names.Where(s => s.Length < 4);
            foreach (string s in y)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Names length equal to 3 :- ");
            var z = names.Where(s => s.Length == 3);
            foreach (string s in z)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Sorting of names in ascending order :- ");
            x = names.OrderBy(s => s);
            
            foreach (string s in x)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
