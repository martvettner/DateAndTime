using System;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime(year, month, day, hour, minute)
            

            DateTime today = DateTime.Today;
            Console.WriteLine($"Today: {today}");
            int YearToday = today.Year;
            Console.WriteLine($"Current year from today {YearToday}");
            var weekDayToday = today.DayOfWeek;
            Console.WriteLine($"it's {weekDayToday}!");

            Console.WriteLine("");
            DateTime todayDetails = DateTime.Now;
            Console.WriteLine($"Today: {todayDetails}");

            DateTime utc = DateTime.UtcNow;
            Console.WriteLine($"time rn {utc}");

            DateTime christmasEve = new DateTime(2020, 12, 24);
            var chrsitmasDayOfweek = christmasEve.DayOfWeek;
            Console.WriteLine(chrsitmasDayOfweek);



            Console.ReadLine();

        }
    }
}
