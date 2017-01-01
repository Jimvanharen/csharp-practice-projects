using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Web;


namespace ConsoleApplicationbooyah
{
    class Program 
    {
        static void Main(string[] args)
        {
            //WebsiteElementGetter v1.1

            Random randomNumber = new Random();


            int textfileID = randomNumber.Next(1, 2374890);
            int curtextfileID = textfileID;






            Red();
            Console.Write("From which site do you want the element: ");
            var website = Console.ReadLine();



            var WebsiteElement = (new System.Net.WebClient().DownloadString(website));



            


            
            System.Console.WriteLine(new System.Net.WebClient().DownloadString(website));



            Console.WriteLine("Create text file?");
            Console.WriteLine("\n[1] Yes");
            Console.WriteLine("[2] No");
            int answer = Convert.ToInt32(Console.ReadLine());


            if (answer == 1)
            {
                Console.WriteLine("Creating text file...");

                System.IO.File.WriteAllText(@"C:\Users\Gebruiker\Desktop\" + textfileID + ".txt", WebsiteElement);
                Green();
                Console.WriteLine("Done! " + website + " Saved as: {0}. LOCATION: DESKTOP", curtextfileID);
                Thread.Sleep(1500);
                Console.WriteLine("Do you want to restart the program?");
                Console.WriteLine("\n[1] Yes");
                Console.WriteLine("[2] No");
                int answer1 = Convert.ToInt32(Console.ReadLine());
                
                if(answer1 == 1)
                {
                    Console.WriteLine("Looping...");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Beginning();

                }
                

            }
            if (answer == 2)
            {
                Console.WriteLine("Press enter to quit...");
                Console.ReadKey();
                Environment.Exit(0);
            }
          
        }

        public static void Green()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public static void Red()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        public static void Beginning()
        {
            //Beggining method.
            Random randomNumber = new Random();


            int textfileID = randomNumber.Next(1, 2374890);
            int curtextfileID = textfileID;






            Red();
            Console.Write("From which site do you want the element: ");
            var website = Console.ReadLine();



            var WebsiteElement = (new System.Net.WebClient().DownloadString(website));







            System.Console.WriteLine(new System.Net.WebClient().DownloadString(website));



            Console.WriteLine("Create text file?");
            Console.WriteLine("\n[1] Yes");
            Console.WriteLine("[2] No");
            int answer = Convert.ToInt32(Console.ReadLine());


            if (answer == 1)
            {
                Console.WriteLine("Creating text file...");

                System.IO.File.WriteAllText(@"C:\Users\Gebruiker\Desktop\" + textfileID + ".txt", WebsiteElement);
                Green();
                Console.WriteLine("Done! " + website + " Saved as: {0}. LOCATION: DESKTOP", curtextfileID);
                Thread.Sleep(1500);
                Console.WriteLine("Do you want to restart the program?");
                Console.WriteLine("\n[1] Yes");
                Console.WriteLine("[2] No");
                int answer1 = Convert.ToInt32(Console.ReadLine());

                if (answer1 == 1)
                {
                    Console.WriteLine("Looping...");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Beginning();

                }


            }
            if (answer == 2)
            {
                Console.WriteLine("Press enter to quit...");
                Console.ReadKey();
                Environment.Exit(0);
            }


        }
           

       }

    }

