using System;

namespace a_whole_new_world
{
    class Program
    {
        static void Greeting()
        {
            Console.WriteLine("Hello user! What shall I call you?");
            var userName = Console.ReadLine();
            System.Console.WriteLine($"Well {userName}.. I would like you to choose a number from 1 to 100:");
        }

        static int AddGuess()
        {
            var userInput = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"This works, the number is {userInput}");
            return userInput;
        }

        static int CalculateNumber()
        {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 100);
            System.Console.WriteLine(randomNumber);
            return randomNumber;
        }

        static void Main(string[] args)
        {
            Greeting();
            AddGuess();
            // TODO pass user's guess to calculate random number and compare
            CalculateNumber();
        }
    }
}
