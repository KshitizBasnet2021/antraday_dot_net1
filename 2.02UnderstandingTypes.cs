using System;

/*
1. Create a console application project named /02UnderstandingTypes/ that outputs the
number of bytes in memory that each of the following number types uses, and the
minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long,
ulong, float, double, and decimal."*/
internal class UnderstandingTypes
{
    public static void Main(string[] args)
    {
       
        try
        {
            Console.WriteLine("Welcome to the max and min values of Datatypes");
            Console.WriteLine("sbyte: MinValue: " + sbyte.MinValue + "and Max Value: " + sbyte.MaxValue);
            Console.WriteLine("byte: MinValue: " + byte.MinValue + "and Max Value: " + byte.MaxValue);
            Console.WriteLine("short: MinValue: " + short.MinValue + "and Max Value: " + short.MaxValue);
            Console.WriteLine("ushort: MinValue: " + ushort.MinValue + "and Max Value: " + ushort.MaxValue);
            Console.WriteLine("int: MinValue: " + int.MinValue + "and Max Value: " + int.MaxValue);
            Console.WriteLine("uint: MinValue: " + uint.MinValue + "and Max Value: " + uint.MaxValue);
            Console.WriteLine("long: MinValue: " + long.MinValue + "and Max Value: " + long.MaxValue);
            Console.WriteLine("ulong: MinValue: " + ulong.MinValue + "and Max Value: " + ulong.MaxValue);
            Console.WriteLine("float: MinValue: " + float.MinValue + "and Max Value: " + float.MaxValue);
            Console.WriteLine("double: MinValue: " + double.MinValue + "and Max Value: " + double.MaxValue);
            Console.WriteLine("decimal: MinValue: " + decimal.MinValue + "and Max Value: " + decimal.MaxValue);
        }
        catch(Exception e)
        {
            Console.WriteLine("This is error!Restart", e);
        }


    }
}