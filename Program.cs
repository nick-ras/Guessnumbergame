// See https://aka.ms/new-console-template for more information
using System;

namespace Guessnumber // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int guessCount = 6;
            int amountGuesses = 6;
            int randomNumber = rand.Next(1, 101);

            for (int i = amountGuesses; i > 0; i--)
            {
                Console.WriteLine("Guess a number from 1-100, you have {0} guesses left", guessCount);
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guessCount <= 0)
                {
                    Console.WriteLine("your out of guesses");
                }
                else if (guess == randomNumber)
                {
                    Console.WriteLine("You guessed it!");
                }
                else if (guessCount > 0)
                {
                    if (guess > randomNumber)
                    {
                        Console.WriteLine("Too high!");
                        guessCount--;
                        if (Enumerable.Range(randomNumber - 5, randomNumber + 5).Contains(guess))
                        {
                            Console.WriteLine("Your close!");
                        }
                    }
                    else if (guess < randomNumber)
                    {
                        Console.WriteLine("Too low!");
                        guessCount--;
                        if (Enumerable.Range(randomNumber - 5, randomNumber + 5).Contains(guess))
                        {
                            Console.WriteLine("Your close!");
                        }
                    }

                    else
                    {
                        Console.WriteLine("Incorrect answer, the answer needs to be a number between 1-100");
                        guessCount++;
                    }
                }



                
            }
            


        }
        
       
    }
}