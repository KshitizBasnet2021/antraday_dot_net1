using System;
using System.Numerics;

/*
2. Write program to enter an integer number of centuries and convert it to years, days, hours,
minutes, seconds, milliseconds, microseconds, nanoseconds. Use an appropriate data
type for every data conversion. Beware of overflows!"*/
internal class ConvertCenturyToNanosAndBetween
{
    public static void Main(string[] args)
    {
       
        try
        {
            Console.WriteLine("Enter the number of centuries:");
            int century = int.Parse(Console.ReadLine());

            int years = century * 100;            // Years (int)
            long days = years * 365;              // Days (long)
            long hours = days * 24;               // Hours (long)
            long minutes = hours * 60;            // Minutes (long)
            long seconds = minutes * 60;         // Seconds (long)
            BigInteger milliseconds = (BigInteger)seconds * 1000;      // Milliseconds (BigInteger)
            BigInteger microseconds = milliseconds * 1000;  // Microseconds (BigInteger)
            BigInteger nanoseconds = microseconds * 1000; // Nanoseconds (BigInteger)

            Console.WriteLine($"Years: {years}");
            Console.WriteLine($"Days: {days}");
            Console.WriteLine($"Hours: {hours}");
            Console.WriteLine($"Minutes: {minutes}");
            Console.WriteLine($"Seconds: {seconds}");
            Console.WriteLine($"Milliseconds: {milliseconds}");
            Console.WriteLine($"Microseconds: {microseconds}");
            Console.WriteLine($"Nanoseconds: {nanoseconds}");

        }
        catch(Exception e)
        {
            Console.WriteLine("This is error!Restart", e);
        }


    }
}