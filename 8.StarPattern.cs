/*
Print-a-Pyramid.Like the star pattern examples that we saw earlier, create a program that
will print the following pattern: If you find yourself getting stuck, try recreating the two
examples that we just talked about in this chapter first. They’re simpler, and you can
compare your results with the code included above.
This can actually be a pretty challenging problem, so here is a hint to get you going. I used
three total loops. One big one contains two smaller loops. The bigger loop goes from line
to line. The first of the two inner loops prints the correct number of spaces, while the
second inner loop prints out the correct number of stars.
*
***
*****
*******
*********.

*/


internal class Star
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Enter a number:");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            for (int j = 0; j < num - i; j++)
            {
                Console.Write(" ");  
            }

            for (int k = 0; k < (2 * i - 1); k++)
            {
                Console.Write("*"); 
            }

            Console.WriteLine();
        }
    }
}

