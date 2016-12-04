using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EggTimer
{
    class Program
    {
        //EGGTIMER CREATED BY: JIM VAN HAREN



        // I put a lot of time in making this I hope you learn something from this project.
        // Well I did at least ;D
        // This is my first *finished* application I hope you like the practice idea :D
       
        //TRY TWEAKING STUFF TO MAKE IT BETTER :)




        static void Main(string[] args)
        {
            
            
            //MAIN PROGRAM, you will always begin here!

            int answer;
            string name;

            ConsoleColorRed();
            Console.WriteLine("#CREATED BY JIM VAN HAREN");
            ResetColor();
            ConsoleColorGreen();
            Console.Write("\nHey, what is your name? : ");
            ResetColor();
            name = Console.ReadLine();
            ConsoleColorYellow();
            Console.WriteLine("\nHey {0}!", name);
            Thread.Sleep(1000);
            Console.WriteLine("\nType 1 if you want to Countdown and type 2 if you want to Count to a number");
            ResetColor();
            ConsoleColorGreen();
            Console.WriteLine("\n1: Countdown");
            Console.WriteLine("2: Count to a number");
            ResetColor();
            answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1)
            {
                Console.Clear();
                CountDown();
            }
           
            if (answer == 2)
            {
                Console.Clear();
                CountTo();
            }
            if((answer != 1) || (answer != 2))
            {
                ConsoleColorRed();
                Console.WriteLine("ERROR TYPE EITHER 1 OR 2");
                Thread.Sleep(1000);
                ResetColor();
                ConsoleColorYellow();
                Console.Write("Refreshing");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(250);
                Console.Clear();
                Beginning();
            }


        }

        //The Countdown Method that counts a given number to zero; 0
        public static void CountDown()
        {
            int input;
            int answer;

            ConsoleColorYellow();
            Console.WriteLine("Hey, welcome to the CountDown timer!");
            Thread.Sleep(1000);
            ResetColor();
            ConsoleColorGreen();
            Console.Write("\nType a number to be counted to zero: ");
            ResetColor();
            input = Convert.ToInt32(Console.ReadLine());

            for (int x = input; x >= 0; x--)
            {
                ConsoleColorYellow();
                Thread.Sleep(1000);
                Console.WriteLine(x);
                if (x == 0)
                {
                    Console.ResetColor();
                    ConsoleColorGreen();
                    Console.WriteLine("DING DONG!");
                    ResetColor();
                    Thread.Sleep(1000);
                    ConsoleColorYellow();
                    Console.WriteLine("\nDo you want to start the program again? (The answer must be in numbers)");
                    ResetColor();
                    ConsoleColorGreen();
                    Console.WriteLine("\n1: Yes");
                    Console.WriteLine("2: No");
                    ResetColor();
                    answer = Convert.ToInt32(Console.ReadLine());
                    if (answer == 1)
                    {
                        ConsoleColorYellow();
                        Console.Write("\nYou will be redirected to the start of the program");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(250);
                        ResetColor();
                        Console.Clear();
                        Beginning();



                   }
                    if (answer == 2)
                    {
                        ConsoleColorYellow();
                        Console.Write("\nAlright, closing the program");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(250);
                        ResetColor();
                        Console.WriteLine("");
                        Environment.Exit(0);
                    }



                }



            }
        }

        //The CountTo method that counts to a given number.
        public static void CountTo()
        {
            int input;
            int answer;

            ConsoleColorYellow();
            Console.WriteLine("Hey, welcome to the CountTo a number section!");
            ResetColor();
            Thread.Sleep(1000);
            ConsoleColorGreen();
            Console.Write("\nType a number to be counted to: ");
            ResetColor();
            input = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i >= 0; i++)
            {
                Thread.Sleep(1000);
                ConsoleColorYellow();
                Console.WriteLine(i);
                ResetColor();

                if (i == input)
                {
                    ConsoleColorGreen();
                    Console.WriteLine("DING DONG!");
                    ResetColor();
                    Thread.Sleep(1000);
                    ConsoleColorYellow();
                    Console.WriteLine("\nDo you want to start the program again? (The answer must be in numbers)");
                    ResetColor();
                    ConsoleColorGreen();
                    Console.WriteLine("\n1: Yes");
                    Console.WriteLine("2: No");
                    ResetColor();
                    answer = Convert.ToInt32(Console.ReadLine());

                    if (answer == 1)
                    {
                        ConsoleColorYellow();
                        Console.Write("\nYou will be redirected to the start of the program");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(250);
                        ResetColor();
                        Console.Clear();
                        Beginning();

                        //The dots because it looks cool :D otherwise its just instant I dont really like that :P
                        // A nice lil' animation.
                    }

                    if (answer == 2)
                    {
                        ConsoleColorYellow();
                        Console.Write("\nAlright, closing the program");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(250);
                        ResetColor();
                        Console.WriteLine("");
                        Environment.Exit(0);
                    }

                    if ((answer != 1) || (answer != 2))
                    {
                        ConsoleColorRed();
                        Console.WriteLine("ERROR TYPE EITHER 1 OR 2");
                        Thread.Sleep(1000);
                        ResetColor();
                        ConsoleColorYellow();
                        Console.Write("Refreshing");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(250);
                        Console.Clear();
                        Beginning();

                    }



                }

            }


        }

        //This method that loops the program again.
        public static void Beginning()
        {
            int answer;
            Thread.Sleep(1000);
            ConsoleColorYellow();
            Console.WriteLine("Type 1 if you want to Countdown and type 2 if you want to Count to a number");
            ResetColor();
            Thread.Sleep(500);
            ConsoleColorGreen();
            Console.WriteLine("\n1: Countdown");
            Console.WriteLine("2: Count to");
            ResetColor();
            answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1)
            {
                Console.Clear();
                CountDown();
            }

            if (answer == 2)
            {
                Console.Clear();
                CountTo();
            }
            if ((answer != 1) || (answer != 2))
            {
                ConsoleColorRed();
                Console.WriteLine("ERROR TYPE EITHER 1 OR 2");
                ResetColor();
                ConsoleColorYellow();
                Console.Write("Refreshing");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(250);
                Console.Clear();
                Beginning();
            }
        }


        //COLOR METHODS (It's easier like this :P)

        public static void ConsoleColorRed()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        public static void ConsoleColorGreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public static void ConsoleColorYellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public static void ResetColor()
        {
            Console.ResetColor();
           
        }
        


    }
}
