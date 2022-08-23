using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();

            while (true)
            {

                //Initial correct number
                //int correctNumber = 7;

                //Create a new Random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //Initial guess variable
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10:");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    //Get user's input
                    string input = Console.ReadLine();

                    //Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {

                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        //Keep going
                        continue;

                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                //Output success message
                //Change text color
                PrintColorMessage(ConsoleColor.Yellow, "Correct!!! You guessed it!");

                //Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

        }

        static void GetAppInfo()
        {
            //Set app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Bishal Adhikari";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            //Ask user's name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        static void PrintColorMessage(ConsoleColor Color, string Message)
        {
            //Change text color
            Console.ForegroundColor = Color;

            //Tell user its not a number
            Console.WriteLine(Message);

            //Reset text color
            Console.ResetColor();
        }
    }
}
