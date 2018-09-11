using System;

namespace a_whole_new_world
{
    class Program
    {
        static void Greeting()
        {
            var userName = "";
            Console.WriteLine("Hello user! What shall I call you?");
            userName = Console.ReadLine();
            System.Console.WriteLine($"Well {userName}..");
        }

        // function for guesses
        // static void UpdateGame(double guess)
        // {
        //     double lower = 0.00;
        //     double upper = 0.00;
        //     var response = "";
        //     lower = MIN;
        //     upper = MAX;
        //     guess = Math.Round((lower + upper) / 2, 0);
        //     var tries = 0.00;
        //     tries = Math.Round(Math.Log(MAX) / Math.Log(2));
        //     // Output # of guesses
        //     System.Console.WriteLine($"I want you think of a number {MIN} to {MAX}");
        //     System.Console.WriteLine($"I can guess the number you chose in {tries} tries");
        //     System.Console.WriteLine("What do you say to that?");
        //     response = Console.ReadLine();
        //     // output guess
        //     System.Console.WriteLine($"I bet you do, anyway... Is your number {guess}?");
        //     UserChoice(guess);
        // }

        // static void UserChoice(double guess)
        // {
        //     var userInput = 0;
        //     // ask user for a lower/higher response
        //     System.Console.WriteLine("Choose 1 for lower and 2 for upper");
        //     userInput = int.Parse(Console.ReadLine());
        //     if (userInput == 1)
        //     {
        //         GuessLower(guess);
        //     }
        //     else
        //     {
        //         GuessUpper(guess);
        //     }
        // }
        // static void GuessUpper(double userGuess)
        // {
        //     double upperChoice = userGuess + 1;
        //     UpdateGame(upperChoice);
        // }
        // static void GuessLower(double userGuess)
        // {
        //     double lowerChoice = userGuess - 1;
        //     UpdateGame(lowerChoice);
        // }
        const double MIN = 1;
        const double MAX = 100;
        static void Main(string[] args)
        {
            var guess = 0.00;
            var tries = 0.00;
            double lower = 0.00;
            double upper = 0.00;
            var userInput = 0;
            int response = 0;
            Greeting();
            // UpdateGame(guess);
            // Calculates # of guesses
            lower = MIN;
            upper = MAX;
            guess = Math.Round((lower + upper) / 2, 0);
            tries = Math.Round(Math.Log(MAX) / Math.Log(2));
            // Output # of guesses
            System.Console.WriteLine($"I want you think of a number {MIN} to {MAX}");
            System.Console.WriteLine($"I can guess the number you chose in {tries} tries");
            // output guess
            System.Console.WriteLine($"I bet you do, anyway... Is your number {guess}?");
            System.Console.WriteLine("What do you say to that? 1 for Yes, 2 for No");
            response = int.Parse(Console.ReadLine());
            while (response != 1)
            {
                // ask user for a lower/higher response
                System.Console.WriteLine("Choose 1 for lower and 2 for upper");
                userInput = int.Parse(Console.ReadLine());
                if (userInput == 1)
                {
                    // GuessLower(guess);
                    upper = guess - 1;
                    guess = Math.Round((lower + upper) / 2, 0);
                    System.Console.WriteLine($"Is your number {guess}?");
                    tries--;
                    System.Console.WriteLine($"Tries left are {tries}");
                }
                else
                {
                    // GuessUpper(guess);
                    lower = guess + 1;
                    guess = Math.Round((lower + upper) / 2, 0);
                    System.Console.WriteLine($"Is your number {guess}?");
                    tries--;
                    System.Console.WriteLine($"Tries left are {tries}");
                }
            }
        }
    }
}
