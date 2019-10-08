using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            string userName = "";
            int choosenMenu = 0;
            int totalScore = 0;
            int dieA = 0, dieB = 0, dieC = 0, dieD = 0;
            int sum = 0;
            float centerX = Console.WindowWidth / 2;
            float centerY = Console.WindowHeight / 2;

            Console.WriteLine("Please enter your name:");
            userName = Console.ReadLine();
            Console.WriteLine("#############################################");
            Console.WriteLine("                                            " + userName);
            Console.SetCursorPosition((int)centerX, (int)centerY);
            Console.WriteLine("Please select from the options below");
            Console.WriteLine("1 - GAME MODE 1: THROW DICE RANDOMLY");
            Console.WriteLine("2 - GAME MODE 2: THROW DICE YOURSELF (DEBUGGING)");
            Console.WriteLine("3 - SHOW HIGHSCORE TABLE");
            Console.WriteLine("4 - EXIT");
            choosenMenu = Convert.ToInt32(Console.ReadLine());
            if(choosenMenu == 4)
            {
                return;
            }else if(choosenMenu == 3)
            {
                Console.WriteLine("");
            }else if (choosenMenu == 1)
            {
                dieA = rng.Next(1, 7);
                dieB = rng.Next(1, 7);
                dieC = rng.Next(1, 7);
                dieD = rng.Next(1, 7);
            }else if(choosenMenu == 2)
            {
                Console.WriteLine("please enter 4 number in a sequance (dice has 6 face)");
                dieA = Convert.ToInt32(Console.ReadLine());
                dieB = Convert.ToInt32(Console.ReadLine());
                dieC = Convert.ToInt32(Console.ReadLine());
                dieD = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Dice are {0},{1},{2},{3}", dieA, dieB, dieC, dieD);
            sum = dieA + dieB + dieC + dieD;

            //rule 7,8,9
            if(12 <= sum && sum <= 16)
            {
                totalScore += 2;
            }else if ((8 <= sum && sum <= 11) || (17 <= sum && sum <= 20))
            {
                totalScore += 4;
            }else if ((4 <= sum && sum <= 7) || (21 <= sum && sum <= 24))
            {
                totalScore += 30;
            }
            // 1, 2, 3, 4 and 5th rule

            Console.WriteLine(totalScore);
        }
    }
}
