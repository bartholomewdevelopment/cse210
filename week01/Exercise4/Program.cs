using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Lesson Notes
        // List<int> numbers = new List<int>();
        // List<string> words = new List<string>();

        // words.Add("phone");
        // words.Add("keyboard");
        // words.Add("Mouse");
        // numbers.Add(16);
        // numbers.Add(17);
        // numbers.Add(18);

        // Console.WriteLine(words.Count);
        // Console.WriteLine(numbers.Sum());

        // foreach (string word in words)
        // {
        //     Console.WriteLine(word);
        // }

        // for (int i = 0; i < words.Count; i++)
        // {
        //     Console.WriteLine(words[i]);
        // }

        List<int> numbers = new List<int>();
        int userNum = -1;
        while (userNum != 0)
        {
            Console.Write("Enter a number, when you are done, type 0. ");
            string userResponse = Console.ReadLine();
            userNum = int.Parse(userResponse);

            if (userNum != 0)
            {
                numbers.Add(userNum);
            }
        }
        
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is {max}");
    }
}