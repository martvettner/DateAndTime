using System;
using System.Dynamic;

namespace BirthdayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("when were you born (dd.mm.yyyy)");
            string userInput = Console.ReadLine();

            BirthWeekCalculator(userInput);

        }
        public static void BirthWeekCalculator(string userInput)
        {
            string day = userInput.Substring(0, 2);
            string month = userInput.Substring(3, 2);
            string year = userInput.Substring(6, 4);

            int dayInt = Int32.Parse(day);
            int monthInt = Int32.Parse(month);
            int yearInt = Int32.Parse(year);

            DateTime BirthWeek = new DateTime(yearInt, monthInt, dayInt);
            var birthWeekFinal = BirthWeek.DayOfWeek;
            Console.WriteLine(birthWeekFinal);

            Console.ReadLine();
        }
    }
}