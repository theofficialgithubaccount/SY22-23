using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            string name;
            string job;
            Console.WriteLine("Enter your age:");
            x = int.Parse(Console.ReadLine());
            //Console.WriteLine(x);
            Console.WriteLine($"Your age is {x}.");
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine($"Your name is {name}");
            Console.WriteLine("What is your line of work?");
            job = Console.ReadLine();
            Console.WriteLine($"Your job is ");
            Console.ReadKey();
        }
    }
}
