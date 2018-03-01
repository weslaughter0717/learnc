using System;

//namespace
namespace NumberGuesser
{
    //main class
    class Program
    {
        //entry point method
        static void Main(string[] args)
        {
            //// start here //
            //string name = "Eric Slaughter";
            //int age = 29;
            //Console.WriteLine("Hello " + name);
            //Console.WriteLine(age);
            //Console.WriteLine("{0} is {1}", name, age);
            GetAppInfo();
            // ask user their name

            GreetUser();

            while (true)
            {

                // set correct number

                //int correctNumber = 7;
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // init guess var

                int guess = 0;

                ColorChoice(ConsoleColor.Green, "Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();


                    if (!int.TryParse(input, out guess))
                    {
                        ColorChoice(ConsoleColor.Red, "Please Use A Number!");

                        continue;
                    }

                    // cast to int and put into guess

                    guess = Int32.Parse(input);

                    // match guess to correct number

                    if (guess != correctNumber)
                    {
                        ColorChoice(ConsoleColor.Red, "Try Again!");
                    }
                }

                if (guess == correctNumber)
                {
                    ColorChoice(ConsoleColor.Green, "Great Your Guess Was Right!");
                }

                ColorChoice(ConsoleColor.Green, "Do You Wish To Play Again? [Y of N]");

                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y"){
                    continue;
                }else{
                    return;
                }
            }
        }
        static void GetAppInfo(){
            // set app vars
            string app = "Number Guesser";
            string version = "1.0.0";
            string author = "Eric Slaughter";

            // change text color

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: version {1} by {2}", app, version, author);

            Console.ResetColor();
            
        }
        static void GreetUser(){

            Console.WriteLine("What is your name?");

            String inputName = Console.ReadLine();

            Console.WriteLine("Hello {0} Let's Play A Game...", inputName);
            
        }
        static void ColorChoice(ConsoleColor color, string message) {

            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
