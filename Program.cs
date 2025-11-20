using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int month, guess;
            int score = 5;
            Console.Write("Enter number your month:");
            month = int.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("your guess?");
                guess = int.Parse(Console.ReadLine());
                if (guess == month)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("you win");
                    Console.WriteLine("your score: {0}", score);
                    break;
                }
                else
                {
                    score -= 1;
                    if (score == 0)
                    {
                        Console.WriteLine("you lose");
                        Console.WriteLine(month);
                        break;
                            }
                   
                }
                Console.WriteLine("try again !");
            }
            Console.ReadKey();
        }
    }
}
