using System;
using System.Numerics;

/*
Write a program that generates a random number between 1 and 3 and asks the user to
guess what the number is. Tell the user if they guess low, high, or get the correct answer.
Also, tell the user if their answer is outside of the range of numbers that are valid guesses
(less than 1 or more than 3). You can convert the user's typed answer from a string to an
int using this code:
int guessedNumber = int.Parse(Console.ReadLine());
Note that the above code will crash the program if the user doesn't type an integer value.
For this exercise, assume the user will only enter valid guesses.
*/
internal class GuessGame
{

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 3:");
            int num = int.Parse(Console.ReadLine());

            Random rand = new Random();
            int randomnum = rand.Next(1, 4);

            if (num == randomnum)
            {
                Console.WriteLine("You guessed correct");
            }
            else if (num < randomnum)
            {
                Console.WriteLine("Guess is low");
            }
            else if (num > randomnum)
            {
                Console.WriteLine("Guess is high");
            }
            else if (num < 1 || num > 3)
            {
                Console.WriteLine("Your guess is outside limit");
            }
        }
    }
}
