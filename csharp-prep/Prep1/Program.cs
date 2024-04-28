using System;

class Program
{
    static void Main(string[] args)
    {
         // Ask the user for their grade percentage
        Console.Write("Please enter your grade percentage: ");
        string input = Console.ReadLine();
        int grade;
        
        // Check if the input is a valid integer
        if (!int.TryParse(input, out grade))
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
            return;
        }

        string letter; // Variable to hold the letter grade

        // Determine the letter grade using if-elif-else statements
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Print the letter grade
        Console.WriteLine($"Your letter grade is: {letter}");

        // Determine if the user passed the class
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass the class.");
        }
    }
    }