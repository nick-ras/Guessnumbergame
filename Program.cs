// See https://aka.ms/new-console-template for more information
using System;

namespace Guessnumber // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int randomNumber = rand.Next(1, 101); 
            int guessCount = 6;
            
            int startAmountGuesses = 6;

            for (int i = startAmountGuesses; i > 0; i--)
            {
                Console.WriteLine($"Guess a number from 1-100, you have {guessCount} guesses left");
                int guess = Convert.ToInt32(Console.ReadLine());


                if (guess == randomNumber)
                {
                    Console.WriteLine("You guessed it!");
                    break;
                }

                if (guess > randomNumber)
                {
                    Console.WriteLine("Too high!");
                    guessCount--;
                }

                if (guess < randomNumber)
                {
                    Console.WriteLine("Too low!");
                    guessCount--;
                }

                if (guess <= randomNumber + 5 && guess >= randomNumber - 5)
                {
                    Console.WriteLine("Your close!");
                }

                if (guess < 1 && guess > 100)
                {
                    Console.WriteLine("The answer needs to be a number between 1-100");
                    guessCount++;
                }

                if (guessCount < 1)
                {
                    Console.WriteLine("Your out of guesses! <--{()}--->");
                    break;
                }
                
            }
        }
    }
}



    