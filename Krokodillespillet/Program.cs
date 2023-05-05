using System;

namespace Krokodillespillet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            bool validInput = false;

            while (!validInput)
            {

                int randomNum1 = GetRandomNum();
                int randomNum2 = GetRandomNum();
                string answer = checkNumbers(randomNum1, randomNum2);

                Console.WriteLine(randomNum1 + "_" + randomNum2);
                string userAnswer = Console.ReadLine();
                //ConsoleKeyInfo key = Console.ReadKey(true);
                //char input = key.KeyChar;

                if (userAnswer == ">" || userAnswer == "<" || userAnswer == "=")
                {
                    bool isCorrect = CheckUserAnswer(answer, userAnswer);
                    if (isCorrect)
                    {
                        points++;
                        Console.WriteLine("Correct! You got " + points + " points");
                    }
                    else
                    {
                        points--;
                        Console.WriteLine("Wrong. You now got " + points + " points");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please enter either '<' or '>' or '='");
                }
            }



            Console.WriteLine(); /* Stops window from closing */
        }
        static int GetRandomNum()
        {
            Random random = new Random();
            return random.Next(1, 11);
        }
        static string checkNumbers(int num1, int num2)
        {
            if (num1 > num2)
            {
                return ">";
            }
            else if (num1 < num2)
            {
                return "<";
            }
            else
            {
                return "=";
            }
        }
        static bool CheckUserAnswer(string answer, string userAnswer)
        {
            if (answer == userAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}