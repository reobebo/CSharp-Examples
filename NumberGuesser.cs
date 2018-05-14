using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            getAppInfo();
            greetUser();

            while (true)
            {

                //Create new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 11);

                //Init guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10: ");
                while (guess != correctNumber)
                {
                    //Get user input
                    string input = Console.ReadLine();

                    //make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        //change text color
                        printColorMessage(ConsoleColor.Red, "Please use an actual number");
                      
                        continue;

                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);


                    if (guess != correctNumber)
                    {
                        //change text color
                        printColorMessage(ConsoleColor.Red, "Wrong number, please try again!!");


                    }
                }

                //Output Success Message

                printColorMessage(ConsoleColor.Yellow, "You are Correct!!!!!");

                //Ask to play again
                Console.WriteLine("Want to play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer=="Y")
                {
                    continue;
                }else if (answer == "N")
                {
                    return;
                }
            }
           

           
        }

        static void getAppInfo()
        {
            //app vars
            String appName = "Number Guesser";
            String appVersion = "1.0.0";
            String appAuthor = "Rakip Bebo";

            //change text color
            Console.ForegroundColor = ConsoleColor.Green;


            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }

        static void greetUser()
        {
            // Ask Users name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game...", inputName);

        }

        //print color message
        static void printColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
