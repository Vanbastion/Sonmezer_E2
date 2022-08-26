using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonmezer_E2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press space, then type a number between grades that would get you an A in this course");
            Random random = new Random();
            bool replay = true;
            int g = 0; // Amount of guesses
            string r;
            r = Console.ReadLine();
            if (r == "QUIT") // Quits program
                Environment.Exit(1);

            while (replay) //In order for player to play again should they want it
                for (int j = 0; j < 1; j++)

                {
                    j = random.Next(93, 101); // Syllabus says we need 93 or higher for an A
                    int i = Convert.ToInt32(Console.ReadLine()); // Input number

                    {
                        if (i < j) // If the user guesses too low
                            Console.WriteLine("Nope. You can do better than that.");

                        if (i > j) // If the user guesses too high
                            Console.WriteLine("We both know that's too much.");

                        if (i == j) // If the user guesses right 
                            Console.WriteLine("Congratulations! You have chosen wisely. Would you like to win again?");

                        if (i != j)
                            g++; //Counts each guess

                        if (g == 9) //Epic failure
                            Console.WriteLine("WOW! WAY too many tries. Sorry, that's not how you graduate. Care for another try?");

                        if (g == 9)
                            Console.WriteLine("Type another number to continue or type QUIT to exit");

                        if (i == j)
                            Console.WriteLine("Type another number to continue or type QUIT to exit");

                        if (i == j)
                            g = 0;

                        if (g == 9)  //Resets guess count
                            g = 0;
                    }
                }
        }
    }
}