using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RouletteSimulator
{
    class Program
    {
        public static ConsoleKey BetModeCheck;
        public static ConsoleKey EscapeCheck;
    
        static void DrawRoulleteFrame()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(19,2);
            Console.WriteLine("┌");
            Console.SetCursorPosition(19,3);
            Console.WriteLine("│");
            Console.SetCursorPosition(19,4);
            Console.WriteLine("└");
            Console.SetCursorPosition(20,4);
            Console.WriteLine("─");
            Console.SetCursorPosition(21,4);
            Console.WriteLine("─");
            Console.SetCursorPosition(22,4);
            Console.WriteLine("┘");
            Console.SetCursorPosition(22,3);
            Console.WriteLine("│");
            Console.SetCursorPosition(22,2);
            Console.WriteLine("┐");
            Console.SetCursorPosition(20,2);
            Console.WriteLine("─");
            Console.SetCursorPosition(21,2);
            Console.WriteLine("─");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(0, 1);
        }
        static void BetOnColor()
        {
        FinishedGame:
            string userChoice ;
            int firstnumber = 0;
            int secondnumber = 0;
            Random rand = new Random();
            Random rand1 = new Random();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

        InputError:
            
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter the color you want to bet on!");
            Console.SetCursorPosition(48, 0);
            Console.Write("Enter '1' for");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" Red ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("and '2' for ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Blue");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            DrawRoulleteFrame();


            EscapeCheck = Console.ReadKey().Key;
            if (EscapeCheck == ConsoleKey.Escape)
            {
                Console.Clear();
                return;
            }
            userChoice = EscapeCheck.ToString();

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {

                if (userChoice != "D1" && userChoice != "D2")
                {
                    Console.Clear();
                    goto InputError;
                }

                for (int i = 0; i <= 35; i++)
                {
                    firstnumber = rand.Next(0, 4);

                    if (firstnumber == 3)
                    {
                        secondnumber = rand.Next(0, 7);
                        if (secondnumber % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            if (firstnumber == 0)
                            {
                                Console.SetCursorPosition(20, 3);
                                Console.WriteLine(" ");
                            }
                            else
                            {
                                Console.SetCursorPosition(20, 3);
                                Console.WriteLine(firstnumber);
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            if (firstnumber == 0)
                            {
                                Console.SetCursorPosition(20, 3);
                                Console.WriteLine(" ");
                            }
                            else
                            {
                                Console.SetCursorPosition(20, 3);
                                Console.WriteLine(firstnumber);
                            }
                        }
                        Console.SetCursorPosition(21, 3);
                        Console.WriteLine(secondnumber);
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    }
                    else
                    {
                        secondnumber = rand.Next(0, 10);
                        if (secondnumber % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            if (firstnumber == 0)
                            {
                                Console.SetCursorPosition(20, 3);
                                Console.WriteLine(" ");
                            }
                            else
                            {
                                Console.SetCursorPosition(20, 3);
                                Console.WriteLine(firstnumber);
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            if (firstnumber == 0)
                            {
                                Console.SetCursorPosition(20, 3);
                                Console.WriteLine(" ");
                            }
                            else
                            {
                                Console.SetCursorPosition(20, 3);
                                Console.WriteLine(firstnumber);
                            }
                        }
                        if (secondnumber == 0 && firstnumber == 0) Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.SetCursorPosition(21, 3);
                        Console.WriteLine(secondnumber);
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    }

                    Thread.Sleep(50);
                }
                switch (userChoice)
                {
                    case "D1":
                        if (secondnumber % 2 != 0)
                        {


                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("YOU WON!!!");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Press any key to continue with the same bet mode or press Escape to change it!");
                            if (Console.ReadKey().Key == ConsoleKey.Escape)
                            {
                                Console.Clear();
                                return;
                            }
                            else
                            {
                                Console.Clear();
                                goto FinishedGame;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("YOU LOST!!!");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Press any key to continue with the same bet mode or press Escape to change it!");
                            if (Console.ReadKey().Key == ConsoleKey.Escape)
                            {
                                Console.Clear();
                                return;
                            }
                            else
                            {
                                Console.Clear();
                                goto FinishedGame;
                            }
                        }

                        break;

                    case "D2":
                        if (secondnumber % 2 == 0)
                        {
                            if (secondnumber == 0 && firstnumber == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("YOU LOST!!!");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Press any key to continue with the same bet mode or press Escape to change it!");
                                if (Console.ReadKey().Key == ConsoleKey.Escape)
                                {
                                    Console.Clear();
                                    return;
                                }
                                else
                                {
                                    Console.Clear();
                                    goto FinishedGame;
                                }
                            }

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("YOU WON!!!");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Press any key to continue with the same bet mode or press Escape to change it!");
                            if (Console.ReadKey().Key == ConsoleKey.Escape)
                            {
                                Console.Clear();
                                return;
                            }
                            else
                            {
                                Console.Clear();
                                goto FinishedGame;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("YOU LOST!!!");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Press any key to continue with the same bet mode or press Escape to change it!");
                            if (Console.ReadKey().Key == ConsoleKey.Escape)
                            {
                                Console.Clear();
                                return;
                            }
                            else
                            {
                                Console.Clear();
                                goto FinishedGame;
                            }
                        }
                        break;
                }
            }
            else
            {
                Console.Clear();
                goto FinishedGame;
            }
        }
        static void BetOnThird()
        {

            FinishedGame:
                string userChoice;
                int firstnumber = 0;
                int secondnumber = 0;
                Random rand = new Random();
                Random rand1 = new Random();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;

        InputError:
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Enter which one third you want to bet on!");
                Console.SetCursorPosition(48,0);
                Console.WriteLine("Press '1' for the numbers from 1 to 12");
                Console.SetCursorPosition(48, 1);
                Console.WriteLine("Press '2' for the numbers from 13 to 24");   
                Console.SetCursorPosition(48, 2);
                Console.WriteLine("Press '3' for the numbers from 25 to 36");
                DrawRoulleteFrame();


            EscapeCheck = Console.ReadKey().Key; 
             if (EscapeCheck == ConsoleKey.Escape)
             {
                Console.Clear();
                return;
             }
               userChoice = EscapeCheck.ToString();

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {


                if (userChoice != "D1" && userChoice != "D2" && userChoice != "D3")
                {
                    Console.Clear();
                    goto InputError;
                }

                for (int i = 0; i <= 35; i++)
                {
                    firstnumber = rand.Next(0, 4);

                    if (firstnumber == 3)
                    {
                        secondnumber = rand.Next(0, 7);
                        if (secondnumber % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            if (firstnumber == 0)
                            {
                                Console.SetCursorPosition(20, 3);
                                Console.WriteLine(" ");
                            }
                            else
                            {
                                Console.SetCursorPosition(20, 3);
                                Console.WriteLine(firstnumber);
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            if (firstnumber == 0)
                            {
                                Console.SetCursorPosition(20, 3);
                                Console.WriteLine(" ");
                            }
                            else
                            {
                                Console.SetCursorPosition(20, 3);
                                Console.WriteLine(firstnumber);
                            }
                        }
                        Console.SetCursorPosition(21, 3);
                        Console.WriteLine(secondnumber);
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    }
                    else
                    {
                        secondnumber = rand.Next(0, 10);
                        if (secondnumber % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            if (firstnumber == 0)
                            {
                                Console.SetCursorPosition(20, 3);
                                Console.WriteLine(" ");
                            }
                            else
                            {
                                Console.SetCursorPosition(20, 3);
                                Console.WriteLine(firstnumber);
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            if (firstnumber == 0)
                            {
                                Console.SetCursorPosition(20, 3);
                                Console.WriteLine(" ");
                            }
                            else
                            {
                                Console.SetCursorPosition(20, 3);
                                Console.WriteLine(firstnumber);
                            }
                        }
                        if (secondnumber == 0 && firstnumber == 0) Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.SetCursorPosition(21, 3);
                        Console.WriteLine(secondnumber);
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    }

                    Thread.Sleep(50);
                }


                switch (userChoice)
                {
                    case "D1":
                        if ((firstnumber * 10 + secondnumber) >= 1 && (firstnumber * 10 + secondnumber) <= 12)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("YOU WON!!!");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Press any key to continue with the same bet mode or press Escape to change it!");
                            if (Console.ReadKey().Key == ConsoleKey.Escape)
                            {
                                Console.Clear();
                                return;
                            }
                            else
                            {
                                Console.Clear();
                                goto FinishedGame;
                            }

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("YOU LOST!!!");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Press any key to continue with the same bet mode or press Escape to change it!");
                            if (Console.ReadKey().Key == ConsoleKey.Escape)
                            {
                                Console.Clear();
                                return;
                            }
                            else
                            {
                                Console.Clear();
                                goto FinishedGame;
                            }
                        }
                        break;
                    case "D2":
                        if ((firstnumber * 10 + secondnumber) >= 13 && (firstnumber * 10 + secondnumber) <= 24)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("YOU WON!!!");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Press any key to continue with the same bet mode or press Escape to change it!");
                            if (Console.ReadKey().Key == ConsoleKey.Escape)
                            {
                                Console.Clear();
                                return;
                            }
                            else
                            {
                                Console.Clear();
                                goto FinishedGame;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("YOU LOST!!!");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Press any key to continue with the same bet mode or press Escape to change it!");
                            if (Console.ReadKey().Key == ConsoleKey.Escape)
                            {
                                Console.Clear();
                                return;
                            }
                            else
                            {
                                Console.Clear();
                                goto FinishedGame;
                            }
                        }
                        break;
                    case "D3":
                        if ((firstnumber * 10 + secondnumber) >= 25 && (firstnumber * 10 + secondnumber) <= 36)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("YOU WON!!!");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Press any key to continue with the same bet mode or press Escape to change it!");
                            if (Console.ReadKey().Key == ConsoleKey.Escape)
                            {
                                Console.Clear();
                                return;
                            }
                            else
                            {
                                Console.Clear();
                                goto FinishedGame;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("YOU LOST!!!");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Press any key to continue with the same bet mode or press Escape to change it!");
                            if (Console.ReadKey().Key == ConsoleKey.Escape)
                            {
                                Console.Clear();
                                return;
                            }
                            else
                            {
                                Console.Clear();
                                goto FinishedGame;
                            }
                        }
                        break;
                }
            }
            else
            {
                Console.Clear();
                goto FinishedGame;
            }

        }
        static void Main()
        {
        Finish:
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Choose your type of bet!");
            Console.WriteLine("Bet on different thirds ---> Press 'T' to select this bet type");
            Console.WriteLine("Bet on Color (Red or Blue) ---> Press 'C' to select this bet type");
            EnteringError:
            BetModeCheck = Console.ReadKey().Key;
            if(BetModeCheck != ConsoleKey.C && BetModeCheck != ConsoleKey.T)
            {
                Console.SetCursorPosition(0, 3);
                Console.Write(" ");
                Console.SetCursorPosition(0, 3);
                goto EnteringError;
            }
            EscapeCheck = Console.ReadKey().Key;
            if (BetModeCheck == ConsoleKey.T)
            {
                Console.Clear();
                BetOnThird();
                BetModeCheck = ConsoleKey.Clear;
            }
            
            if(BetModeCheck == ConsoleKey.C)
            {
                Console.Clear();
                BetOnColor();
                BetModeCheck = ConsoleKey.Clear;
            }
            goto Finish;
           
           
        }
    }
}
