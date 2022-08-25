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
            /* string ice_cream;
            string animal;
            string Class;
            int correct = 0;
           
            Console.WriteLine("What is the best flavor of ice cream? - A) Void B) 
Death");
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
                Console.WriteLine("Please input either the letter 'A' or 'B' - 
other answers are not accepted.");
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
                Console.WriteLine("Please input either the letter 'A' or 'B' - 
other answers are not accepted.");
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
                Console.WriteLine("Please input either the letter 'A' or 'B' - 
other answers are not accepted.");
            
            Console.WriteLine($"You got {correct} answers correct.");
            */
            //Console.WriteLine($"You got {correct} questions correct.");
            int correct = 0;
            correct += ShowQuestion("What is the best flavor of ice cream?", "\n A) Vanilla", "\n B) Chocolate", "\n C) Cookie Dough", "\n D) Mint Chocolate Chip", "C");
            correct += ShowQuestion("What is the best class?", "\n A) Math", "\n B) Meth", "\n C) The Upper Middle Class", "\n D) Mandarin 5 - 6", "D");
            correct += ShowQuestion("What is the best animal?", "\n A) Brown Recluse Spider", "\n B) Goblin Shark", "\n C) Dog", "\n D) Moth", "D");
            Console.WriteLine($"You got {correct} questions correct.");
            Console.ReadKey();
        }
        public static int ShowQuestion(string question,
                                 string answer1,
                                 string answer2,
                                 string answer3,
                                 string answer4,
                                 string correct)
        {

            Console.WriteLine(question);
            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
            Console.WriteLine(answer3);
            Console.WriteLine(answer4);
            string answer = Console.ReadLine();
            if (answer.Equals(correct))
            {
                Console.WriteLine("You got it correct.");
                return 1;
            }
            else
            {
                Console.WriteLine("You got it wrong.");
            }
            return 0;
        }
    }
}