using System;
using System.Numerics;

/*
FizzBuzzis a group word game for children to teach them about division. Players take turns
to count incrementally, replacing any number divisible by three with the word /fizz/, any
number divisible by five with the word /buzz/, and any number divisible by both with /
fizzbuzz/.
Create a console application in Chapter03 named Exercise03 that outputs a simulated
FizzBuzz game counting up to 100. The output should look something like the following
screenshot:"*/
internal class Exercise03
{
    private static string FizzBuzz(int i)
    {
        Console.Write(i+ ": ");
        if (i % 3 == 0 && i % 5 == 0)
        {
            return ("FizzBuzz");
        }
        if (i % 3 == 0)
        {
            return("Fizz");
        }
        if (i % 5 == 0)
        {
            return("Buzz");
        }
        return "";

    }
    public static void Main(string[] args)
    {
            try
        {
            for(int i=1; i<=100; i++)
            {
                Console.WriteLine(Exercise03.FizzBuzz(i));
                
            }
         

        }
        catch(Exception e)
        {
            Console.WriteLine("This is error!Restart", e);
        }


    }
}