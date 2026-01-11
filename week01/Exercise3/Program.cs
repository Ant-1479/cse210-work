using System;

class Program
{
    static void Main(string[] args)
    {  Console.WriteLine("Hello World! This is the Exercise3 Project.");

    {
        // For Parts 1 and 2, where the user specified the number...
        // Console.Write("What is the favourite number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        
        // For Part 3, where we use a random number
        Random randomGenerator = new Random();
        int favouriteNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        // We could also use a do-while loop here...
        while (guess != favouriteNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (favouriteNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (favouriteNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    
    }
}
    }
