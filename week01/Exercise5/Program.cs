using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Display welcome message
        DisplayWelcome();

        // Step 2: Get the user's name
        string username = PromptUserName();

        // Step 3: Get the user's favorite number
        int favoriteNumber = PromptUserNumber();

        // Step 4: Square the number
        int squaredNumber = SquareNumber(favoriteNumber);

        // Step 5: Display the result
        DisplayResult(username, squaredNumber);
    }

    // Function 1
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function 2
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function 3
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Function 4
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function 5
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}