using System;

namespace Date
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = GetTheDay(1893, 11, 7);
            Console.WriteLine($"The day of that week was {dayOfWeek}");

            CarColor car1 = CarColor.Blue;
            PaintCar(car1);

        }

        static String GetTheDay(int year, int month, int day)
        {
            DateTime awesomeDate = new DateTime(year, month, day);
            return awesomeDate.DayOfWeek.ToString();
        }

        enum CarColor : byte
        {
            Orange = 1,
            Blue,
            Green,
            Red,
            Yellow
        }

        static void PaintCar(CarColor colorcode)
        {
            Console.WriteLine("The car was painted {0} with the code {1}", colorcode, (int)colorcode);

        }
    }

}


