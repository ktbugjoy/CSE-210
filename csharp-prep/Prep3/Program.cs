using System;

class Program {
    static void Main() {
        Console.Write("What is the magic number? ");
        int magicNumber = Convert.ToInt32(Console.ReadLine());

        // Initialize the guess to a value
        int guess = 0;

        // Loop until the guess is correct
        while (guess != magicNumber) {
            // Ask the user for a guess
            Console.Write("What is your guess? ");
            guess = Convert.ToInt32(Console.ReadLine());

            // Determine the response using if statements
            if (guess < magicNumber) {
                Console.WriteLine("Higher");
            } else if (guess > magicNumber) {
                Console.WriteLine("Lower");
            }
        }
        // The correct guess exits the loop, so we print the success message here
        Console.WriteLine("You guessed it!");
    }
}
