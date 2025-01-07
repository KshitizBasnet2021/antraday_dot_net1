﻿using System;

/*Modify your console application to display a different message. Go ahead and
intentionally add some mistakes to your program, so you can see what kinds of error
messages you get from the compiler. The more familiar you are with these messages, and
what causes them, the better you'll be at diagnosing problems in your programs that you /
didn't/ intend to add!
Using just the ReadLine and WriteLine methods and your current knowledge of variables,
you can have the user pass in quite a few bits of information. Using this approach, create a
console application that asks the user a few questions and then generates some custom
output for them. For instance, your program could generate their "hacker name" by asking
them their favorite color, their astrology sign, and their street address number. The result
might be something like "Your hacker name is RedGemini480."*/
internal class Play_hacker_game
{
    public static void Main(string[] args)
    {
       
        try
        {
            Console.WriteLine("Write hacker's Name: ");
            String input_hacker = Console.ReadLine();

            Console.WriteLine("Write astrology sign: ");
            String input_hacker_astrology = Console.ReadLine();

            Console.WriteLine("Write color of the Hacker: ");
            String input_hacker_color = Console.ReadLine();

            Console.WriteLine("hacker's username is: " +input_hacker_astrology +"_" + input_hacker+"_"+input_hacker_color);
        }
        catch(Exception e)
        {
            Console.WriteLine("This is error!Restart", e);
        }


    }
}