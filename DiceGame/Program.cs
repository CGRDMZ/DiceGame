using System;

namespace DiceGame
{
    class Program
    {
        //when the game ends, print a message (press any key to exit)
        static void Main(string[] args)
        {
            Random rng = new Random();
            string userName = "";
            
            int chosenMenu = 0;
            int totalScore = 0;
            int dieA = 0, dieB = 0, dieC = 0, dieD = 0;
            int sum = 0;

            string name_player2 = "Cem Ak";

            bool running = true;
            
            //float centerX = Console.WindowWidth / 2;
            //float centerY = Console.WindowHeight / 2;

            Console.WriteLine("Please enter your name:");
            
            userName = Console.ReadLine();
            while (running)
            {
                //Console.Clear();
                //Console.WriteLine();
                //Console.WriteLine();
                //Console.WriteLine();
                //Console.WriteLine();
                //Console.WriteLine();
                //Console.WriteLine("                             ##########################################################");
                //Console.WriteLine("                                                     - MENU -                          ");
                //Console.WriteLine("                                                    Player: {0}                            ", userName);
                //Console.WriteLine("                                         Game Modes:                                   ");
                //Console.WriteLine("                                      1 - Game Mode 1: Throw dice randomly              ");
                //Console.WriteLine("                                      2 - Game Mode 2: Throw dice yourself (debugging)  ");
                //Console.WriteLine("                                      3 - Score Table                                   ");
                //Console.WriteLine("                                      4 - Exit                                          ");
                //Console.WriteLine("                             ##########################################################");


                while (true)
                {
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
                    Console.WriteLine();
                    Console.WriteLine("please enter a value between 1 and 4!");
                    chosenMenu = Convert.ToInt32(Console.ReadLine());
                    if (chosenMenu == 4)
                    {
                        return;
                    }
                    else if (chosenMenu == 3)
                    {

                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("                             ##########################################################");
                        Console.WriteLine("                                               - High Score Table -                    ");
                        Console.WriteLine("                                                                                       ");
                        Console.WriteLine("                                          NAME              SCORE                      ");
                        Console.WriteLine("                                      1 - Cem Ak              30                       ");
                        Console.WriteLine("                                      2 - Sibel Yaman         18                       ");
                        Console.WriteLine("                                      3 - {0}", userName);
                        Console.SetCursorPosition(63, 11);
                        Console.Write(totalScore);
                        Console.WriteLine("                                                                                       ");
                        Console.WriteLine("                             ##########################################################");
                        Console.WriteLine();
                        Console.WriteLine("press any key to go to main menu...");
                        Console.ReadLine();
                        continue;

                    }
                    else if (chosenMenu == 1)
                    {

                        dieA = rng.Next(1, 7);
                        dieB = rng.Next(1, 7);
                        dieC = rng.Next(1, 7);
                        dieD = rng.Next(1, 7);
                        break;

                    }
                    else if (chosenMenu == 2)
                    {
                        // for the first die
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
                        Console.WriteLine("please enter the first die: (dice has 6 face)");
                        dieA = Convert.ToInt32(Console.ReadLine());
                        if (dieA < 1 || dieA > 6)
                        {
                            while (true)
                            {
                                //Console.Clear();
                                //Console.WriteLine();
                                //Console.WriteLine();
                                //Console.WriteLine();
                                //Console.WriteLine();
                                //Console.WriteLine();
                                //Console.WriteLine("                             ##########################################################");
                                //Console.WriteLine("                                                     - MENU -                          ");
                                //Console.WriteLine("                                                    Player: {0}                            ", userName);
                                //Console.WriteLine("                                         Game Modes:                                   ");
                                //Console.WriteLine("                                      1 - Game Mode 1: Throw dice randomly              ");
                                //Console.WriteLine("                                      2 - Game Mode 2: Throw dice yourself (debugging)  ");
                                //Console.WriteLine("                                      3 - Score Table                                   ");
                                //Console.WriteLine("                                      4 - Exit                                          ");
                                //Console.WriteLine("                             ##########################################################");
                                Console.SetCursorPosition(0, 16);
                                Console.WriteLine("                                                                                             ");
                                Console.WriteLine("                                                                                             ");
                                Console.SetCursorPosition(0, 16);
                                Console.WriteLine("please enter the first die again: (dice has 6 face)");
                                dieA = Convert.ToInt32(Console.ReadLine());
                                if (dieA > 0 && dieA < 7)
                                {
                                    break;
                                }
                            }
                        }
                            
                        while (true)
                        {
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
                            Console.WriteLine("please enter the second die again: (dice has 6 face)");
                            dieB = Convert.ToInt32(Console.ReadLine());
                            if (dieB > 0 && dieB < 7)
                            {
                                break;
                            }
                        }
                        while (true)
                        {
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
                            Console.WriteLine("please enter the third die again: (dice has 6 face)");
                            dieC = Convert.ToInt32(Console.ReadLine());
                            if (dieC > 0 && dieC < 7)
                            {
                                break;
                            }
                        }
                        while (true)
                        {
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
                            Console.WriteLine("please enter the fourth die again: (dice has 6 face)");
                            dieD = Convert.ToInt32(Console.ReadLine());
                            if (dieD > 0 && dieD < 7)
                            {
                                break;
                            }
                        }
                        break;
                    }
                    if (chosenMenu == 3)
                    {
                        break;
                    }
                }
                

                Console.Clear();
                Console.WriteLine("First die is: " + dieA);
                // these statements should be rewritten as else if's because if a dice is 1 it can't be 2, too so no need to check it.
                // shows dices visually
                if (dieA == 1)
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

                Console.WriteLine("Dice are {0}, {1}, {2}, {3}", dieA, dieB, dieC, dieD);

                string rulesPassedText = "Rules passed are:";




                //Console.WriteLine(totalScore);
                // 1, 2, 3, 4 and 5th rule

                if (dieA == dieB && dieB == dieC && dieC == dieD)
                {
                    //adds 300 points for rule 1
                    totalScore += 300;
                    rulesPassedText += " 1";
                }
                else if (dieA == dieB && dieB == dieC || dieA == dieB && dieB == dieD
                    || dieA == dieC && dieC == dieD || dieB == dieC && dieC == dieD)
                {
                    // adds 16 points for rule 2
                    totalScore += 16;
                    rulesPassedText += " 2";
                }
                else if (dieA == dieB && dieC == dieD || dieA == dieC && dieB == dieD
                    || dieB == dieC && dieA == dieD || dieB == dieD && dieA == dieC
                    || dieC == dieD && dieA == dieB)
                {
                    // adds 20 points for rule 3
                    totalScore += 20;
                    rulesPassedText += " 3";
                }

                if (dieA == dieB || dieA == dieC || dieA == dieD || dieB == dieD || dieC == dieD)
                {
                    // adds 3 points for rule 4
                    totalScore += 3;
                    rulesPassedText += " 4";
                }
                else
                {
                    // if none of the rules above are false then only possible combination
                    // is when all the dice are different which is rule 5
                    totalScore += 5;
                    rulesPassedText += " 5";
                }

                //Console.WriteLine(totalScore);
                // 6th rule

                if (dieA % 2 == dieB % 2 && dieB % 2 == dieC % 2 && dieC % 2 == dieD % 2)
                {
                    totalScore += 12;
                    rulesPassedText += ", 6";
                }
                // calculates sum of the dice for rule 7, 8, 9
                sum = dieA + dieB + dieC + dieD;

                //rule 7,8,9
                if (12 <= sum && sum <= 16)
                {
                    totalScore += 2;

                    rulesPassedText += ", 7";
                }
                else if ((8 <= sum && sum <= 11) || (17 <= sum && sum <= 20))
                {
                    totalScore += 4;

                    rulesPassedText += ", 8";
                }
                else if ((4 <= sum && sum <= 7) || (21 <= sum && sum <= 24))
                {
                    totalScore += 30;

                    rulesPassedText += ", 9";
                }

                //Passes rule numbers are appended to rulesPassedText string and we are displaying it here
                Console.WriteLine(rulesPassedText);

                Console.WriteLine("Your total score is: " + totalScore);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("NAME                  SCORE");

                if (totalScore > 30)
                {
                    Console.Write(userName);
                    Console.SetCursorPosition(22, 23);
                    Console.WriteLine(totalScore);
                    Console.Write("Cem Ak");
                    Console.SetCursorPosition(22, 24);
                    Console.WriteLine("30");
                    Console.Write("Sibel Yaman");
                    Console.SetCursorPosition(22, 25);
                    Console.WriteLine("18");
                }
                else if (totalScore > 18)
                {
                    Console.Write("Cem Ak");
                    Console.SetCursorPosition(22, 23);
                    Console.WriteLine("30");
                    Console.Write(userName);
                    Console.SetCursorPosition(22, 24);
                    Console.WriteLine(totalScore);
                    Console.Write("Sibel Yaman");
                    Console.SetCursorPosition(22, 25);
                    Console.WriteLine("18");
                }
                else
                {
                    Console.Write("Cem Ak");
                    Console.SetCursorPosition(22, 23);
                    Console.WriteLine("30");
                    Console.Write("Sibel Yaman");
                    Console.SetCursorPosition(22, 24);
                    Console.WriteLine("18");
                    Console.Write(userName);
                    Console.SetCursorPosition(22, 25);
                    Console.WriteLine(totalScore);
                }


                Console.WriteLine("# write anything to play again (write '-1' to exit) #");
                // to make the console window not close after the program the program finished
                if (Console.ReadLine() == "-1")
                {
                    running = false;
                }
            }

        }
    }
}
