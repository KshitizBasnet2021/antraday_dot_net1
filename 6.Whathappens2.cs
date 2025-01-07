using System;
using System.Numerics;

/*
Create a console application and enter the preceding code. Run the console application
and view the output. What happens?
What code could you add (don’t change any of the preceding code) to warn us about the
problem?
Your program can create a random number between 1 and 3 with the following code:
int correctNumber = new Random().Next(3) + 1
*/
internal class WhatHappens
{

    public static void Main(string[] args)
    {
        // Maximum number of iterations
        int max = 500;

        // Create Random object once, outside the loop
        Random random = new Random();

        for (byte i = 0; i < max; i++)
        {
            // Generate a random number between 1 and 3
            int correctNumber = random.Next(3) + 1;

            // Optionally, print a warning message once to
            // indicate that frequent creation of Random objects may lead to poor randomization
            if (i == 0)
            {
                // Warning: Generating a new Random object in each iteration may lead to less randomness.
                // Create Random outside the loop for better performance.
                Console.WriteLine("Warning: Generating a new Random object in each iteration may lead to less randomness. Create Random outside the loop for better performance.");
            }

            // Print the current iteration and generated random number
            Console.WriteLine($"Iteration {i}: Generated number is {correctNumber}");
        }
    }
}
