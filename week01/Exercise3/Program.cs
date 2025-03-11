using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is your magic number? ");
        // int magicnum = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicnum = randomGenerator.Next(1, 11);

        int guess = -1;

        Console.WriteLine("I have randomly chosen a number between 1-10.  Try to guess it!");
        
        while (guess != magicnum)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
        
            if (guess > magicnum)
            {
                Console.WriteLine("Your guess is too high");
            }
            else if (guess < magicnum)
            {
                Console.WriteLine("Your guess is too low");
            }
        }
         
        Console.Write("You guessed correctly!");
            

    }
}