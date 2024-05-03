using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = CollectNumbers();
        
        int sum = CalculateSum(numbers);
        Console.WriteLine("The sum is: " + sum);

        if (numbers.Count > 0)  // Ensure the list isn't empty
        {
            double average = CalculateAverage(numbers, sum);
            Console.WriteLine("The average is: " + average);

            int maxNumber = FindMaxNumber(numbers);
            Console.WriteLine("The largest number is: " + maxNumber);
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }

    static List<int> CollectNumbers()
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 0)
            {
                break;
            }
            numbers.Add(number);
        }

        return numbers;
    }

    static int CalculateSum(List<int> numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    static double CalculateAverage(List<int> numbers, int totalSum)
    {
        return (double)totalSum / numbers.Count;
    }

    static int FindMaxNumber(List<int> numbers)
    {
        int maxNumber = numbers[0];
        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }
        return maxNumber;
    }
}
