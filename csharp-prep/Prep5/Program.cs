using System;

class Program
{
    static void Main()
    {
        DisplayWelcome();
        
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNumber);
        
        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        // Loop until a valid integer is entered
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                return number;
            }
            Console.Write("Invalid input. Please enter a valid number: ");
        }
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }
}
