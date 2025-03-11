using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int guess = -1;
        int attempts = 0;

        while(guess != number)
        {
            Console.WriteLine("What's your guess? ");
            guess = int.Parse(Console.ReadLine());
            attempts++;

            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if(guess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it in {attempts} attempts!");
            }
        }

    }
}