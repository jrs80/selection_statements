using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selection_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var fav = r.Next(1, 10);

            bool guessed = false;
            while (!guessed) {
                Console.WriteLine("\nGuess my favorite number between 1 and 10.");
                int n = int.Parse(Console.ReadLine());
                if (n < fav) Console.WriteLine("Too low.");
                else if (n > fav) Console.WriteLine("Too high.");
                else { Console.WriteLine("You got it!"); guessed = true; }
            }

            Console.WriteLine("\nWhat was your favorite subject in school?");
            string s=Console.ReadLine();

            switch (s)
            {
                case "English": Console.WriteLine("I liked English too!"); break;
                case "History": Console.WriteLine("History is very useful."); break;
                case "Math":
                case "Mathematics": Console.WriteLine("Math is great for learning programming."); break;
                case "Gym": Console.WriteLine("Gym, really?  If you say so..."); break;
                default: Console.WriteLine("I haven't heard of " + s + " but I'm glad you like it."); break;
            }

            Console.ReadKey();
            Console.WriteLine("Goodbye!");
            Console.ReadKey();

            return;
        }
    }
}
