using System;
using System.Numerics;

/*
What will happen if this code executes?"
*/
internal class WhatHappens
{

    public static void Main(string[] args)
    {
        int max = 500;
        for (byte i = 0; i < max; i++)
        {
            Console.WriteLine(i);//added cuz missing
        }


    }
}
/* 
 * The Answer is that the loop will go on and on forever
 */