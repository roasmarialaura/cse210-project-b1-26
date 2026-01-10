using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        int number = randomGenerator.Next(1, 101);

        int guess = -1;
        int counter = 0;

        while (number != guess)
        {
            Console.Write("What is your guess? (from 0 to 100) ");
            string guessNumber = Console.ReadLine();
            guess = int.Parse(guessNumber);
            counter += 1;

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        }
        
        Console.WriteLine("You guessed it!");

        Console.WriteLine($"you did {counter} guesses");
    }
}