﻿using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            string userName = "";
            int chosenMenu = 0;
            int totalScore = 0;
            int dieA = 0, dieB = 0, dieC = 0, dieD = 0;
            int sum = 0;
            //float centerX = Console.WindowWidth / 2;
            //float centerY = Console.WindowHeight / 2;

            Console.WriteLine("Please enter your name:");
            userName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                             ##########################################################");
            Console.WriteLine("                                                     - MENU -                          ");
            Console.WriteLine("                                                    Player: {0}                            ", userName);
            Console.WriteLine("                                         Game Modes:                                   ");
            Console.WriteLine("                                      1 - Game Mode 1: Throw dice randomly              ");
            Console.WriteLine("                                      2 - Game Mode 2: Throw dice yourself (debugging)  ");
            Console.WriteLine("                                      3 - Score Table                                   ");
            Console.WriteLine("                                      4 - Exit                                          ");
            Console.WriteLine("                             ##########################################################");
            chosenMenu = Convert.ToInt32(Console.ReadLine());
            if(chosenMenu == 4)
            {
                return;
            }else if(chosenMenu == 3)
            {
                Console.WriteLine("");
            }else if (chosenMenu == 1)
            {
                dieA = rng.Next(1, 7);
                dieB = rng.Next(1, 7);
                dieC = rng.Next(1, 7);
                dieD = rng.Next(1, 7);
            }else if(chosenMenu == 2)
            {
                Console.WriteLine("please enter the first die: (dice has 6 face)");
                dieA = Convert.ToInt32(Console.ReadLine());
                if(dieA < 1 || dieA > 6)
                {
                    Console.WriteLine("!!!Please enter a number between 1 and 6!!!");
                    dieA = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("please enter the second die: (dice has 6 face)");
                dieB = Convert.ToInt32(Console.ReadLine());
                if (dieB < 1 || dieB > 6)
                {
                    Console.WriteLine("!!!Please enter a number between 1 and 6!!!");
                    dieB = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("please enter the third die: (dice has 6 face)");
                dieC = Convert.ToInt32(Console.ReadLine());
                if (dieC < 1 || dieC > 6)
                {
                    Console.WriteLine("!!!Please enter a number between 1 and 6!!!");
                    dieC = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("please enter the fourth die: (dice has 6 face)");
                dieD = Convert.ToInt32(Console.ReadLine());
                if (dieD < 1 || dieD > 6)
                {
                    Console.WriteLine("!!!Please enter a number between 1 and 6!!!");
                    dieD = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("First die is: " + dieA);
            if(dieA == 1)
            {
                Console.WriteLine("|     |");
                Console.WriteLine("|  *  |");
                Console.WriteLine("|     |");
            }
            if (dieA == 2)
            {
                Console.WriteLine("|    *|");
                Console.WriteLine("|     |");
                Console.WriteLine("|*    |");
            }
            if (dieA == 3)
            {
                Console.WriteLine("|    *|");
                Console.WriteLine("|  *  |");
                Console.WriteLine("|*    |");
            }
            if (dieA == 4)
            {
                Console.WriteLine("|*   *|");
                Console.WriteLine("|     |");
                Console.WriteLine("|*   *|");
            }
            if (dieA == 5)
            {
                Console.WriteLine("|*   *|");
                Console.WriteLine("|  *  |");
                Console.WriteLine("|*   *|");
            }
            if (dieA == 6)
            {
                Console.WriteLine("|*   *|");
                Console.WriteLine("|*   *|");
                Console.WriteLine("|*   *|");
            }

            Console.WriteLine("Second die is: " + dieB);
            if (dieB == 1)
            {
                Console.WriteLine("|     |");
                Console.WriteLine("|  *  |");
                Console.WriteLine("|     |");
            }
            if (dieB == 2)
            {
                Console.WriteLine("|    *|");
                Console.WriteLine("|     |");
                Console.WriteLine("|*    |");
            }
            if (dieB == 3)
            {
                Console.WriteLine("|    *|");
                Console.WriteLine("|  *  |");
                Console.WriteLine("|*    |");
            }
            if (dieB == 4)
            {
                Console.WriteLine("|*   *|");
                Console.WriteLine("|     |");
                Console.WriteLine("|*   *|");
            }
            if (dieB == 5)
            {
                Console.WriteLine("|*   *|");
                Console.WriteLine("|  *  |");
                Console.WriteLine("|*   *|");
            }
            if (dieB == 6)
            {
                Console.WriteLine("|*   *|");
                Console.WriteLine("|*   *|");
                Console.WriteLine("|*   *|");
            }
            Console.WriteLine("third die is: " + dieC);
            if (dieC == 1)
            {
                Console.WriteLine("|     |");
                Console.WriteLine("|  *  |");
                Console.WriteLine("|     |");
            }
            if (dieC == 2)
            {
                Console.WriteLine("|    *|");
                Console.WriteLine("|     |");
                Console.WriteLine("|*    |");
            }
            if (dieC == 3)
            {
                Console.WriteLine("|    *|");
                Console.WriteLine("|  *  |");
                Console.WriteLine("|*    |");
            }
            if (dieC == 4)
            {
                Console.WriteLine("|*   *|");
                Console.WriteLine("|     |");
                Console.WriteLine("|*   *|");
            }
            if (dieC == 5)
            {
                Console.WriteLine("|*   *|");
                Console.WriteLine("|  *  |");
                Console.WriteLine("|*   *|");
            }
            if (dieC == 6)
            {
                Console.WriteLine("|*   *|");
                Console.WriteLine("|*   *|");
                Console.WriteLine("|*   *|");
            }
            Console.WriteLine("Fourth die is: " + dieD);
            if (dieD == 1)
            {
                Console.WriteLine("|     |");
                Console.WriteLine("|  *  |");
                Console.WriteLine("|     |");
            }
            if (dieD == 2)
            {
                Console.WriteLine("|    *|");
                Console.WriteLine("|     |");
                Console.WriteLine("|*    |");
            }
            if (dieD == 3)
            {
                Console.WriteLine("|    *|");
                Console.WriteLine("|  *  |");
                Console.WriteLine("|*    |");
            }
            if (dieD == 4)
            {
                Console.WriteLine("|*   *|");
                Console.WriteLine("|     |");
                Console.WriteLine("|*   *|");
            }
            if (dieD == 5)
            {
                Console.WriteLine("|*   *|");
                Console.WriteLine("|  *  |");
                Console.WriteLine("|*   *|");
            }
            if (dieD == 6)
            {
                Console.WriteLine("|*   *|");
                Console.WriteLine("|*   *|");
                Console.WriteLine("|*   *|");
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
            //Console.WriteLine(totalScore);
            // 1, 2, 3, 4 and 5th rule
            if(dieA == dieB && dieB == dieC && dieC == dieD)
            {
                //adds 300 points for rule 1
                totalScore += 300;
            }else if(dieA == dieB && dieB == dieC ||dieA == dieB && dieB == dieD 
                || dieA == dieC && dieC == dieD ||dieB == dieC && dieC == dieD)
            {
                // adds 16 points for rule 2
                totalScore += 16;
            }else if (dieA == dieB && dieC == dieD || dieA == dieC && dieB == dieD 
                || dieB == dieC && dieA == dieD || dieB == dieD && dieA == dieC 
                || dieC == dieD && dieA == dieB)
            {
                // adds 20 points for rule 3
                totalScore += 20;
            }else if(dieA == dieB || dieA == dieC || dieA == dieD || dieB == dieD || dieC == dieD)
            {
                // adds 3 points for rule 4
                totalScore += 3;
            }
            else
            {
                // if none of the rules above are false then only possible combination
                // is when all the dice are different which is rule 5
                totalScore += 5;
            }
            //Console.WriteLine(totalScore);
            // 6th rule
            if(dieA % 2 == dieB % 2 && dieB % 2 == dieC % 2 && dieC % 2 == dieD % 2)
            {
                totalScore += 12;
            }
            Console.WriteLine(" Your total score is: " + totalScore);
            Console.ReadLine();

        }
    }
}