using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ice_cream;
            string animal;
            string Class;
            int correct = 0;
           
            Console.WriteLine("What is the best flavor of ice cream? - A) Void B) Death");
            ice_cream = Console.ReadLine();
            if (ice_cream.ToUpper() == "A")
                Console.WriteLine("You are wrong! -99999 social credit!");
            else if (ice_cream.ToUpper()
                == "B")
            { 
                Console.WriteLine("Good job! +1 social credit!");            
                correct += 1;
            }          
            else
                Console.WriteLine("Please input either the letter 'A' or 'B' - other answers are not accepted.");
           
            Console.WriteLine("What is your favorite animal? - A) Dog B) Wallaby");
            animal = Console.ReadLine();
            if (animal.ToUpper() == "B")
                Console.WriteLine("You are wrong! -982341 social credit!");
            else if (animal.ToUpper() == "A")
            {
                Console.WriteLine("Good job! +0.3 social credit!");
                correct += 1;
            }
            else

                Console.WriteLine("Please input either the letter 'A' or 'B' - other answers are not accepted.");
            
            Console.WriteLine("What is your favorite class? - A) Math B) Math");
            Class = Console.ReadLine();
            if (Class.ToUpper() == "A")
                Console.WriteLine("You are wrong! -539274 social credit!");
            else if (Class.ToUpper() == "B")
            {
                Console.WriteLine("Good job! +0.00054 social credit!");
                correct += 1;
            }
            else
                Console.WriteLine("Please input either the letter 'A' or 'B' - other answers are not accepted.");

            Console.WriteLine($"You got {correct} answers correct.");
            Console.ReadKey();
        }
    }
}
