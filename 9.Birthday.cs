/*
9. Write a simple program that defines a variable representing a birth date and calculates
how many days old the person with that birth date is currently.
For extra credit, output the date of their next 10,000 day (about 27 years) anniversary.
Note: once you figure out their age in days, you can calculate the days until the next
anniversary using int daysToNextAnniversary = 10000 - (days % 10000);
*/


internal class Brithday
{
    public class BirthDayCalculator
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter a Birthday:");
            DateTime birthday = DateTime.Parse(Console.ReadLine());

            DateTime today_date = DateTime.Today;
            TimeSpan ageInDays = today_date - birthday;
            int totalDays = ageInDays.Days;
            Console.WriteLine($"You are {totalDays} days old today");
            int daysToNextAnniversary = 10000 - (totalDays % 10000);

            DateTime nextAnniversary = birthday.AddDays(totalDays + daysToNextAnniversary);

            Console.WriteLine($"Your next 10,000-day anniversary will be on {nextAnniversary.ToShortDateString()}.");
        }

    }
}


