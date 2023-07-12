using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 367;
            int year;
            int weeks;
            int day;

            year = num / 365;
            weeks = (num % 365) /7;
            day = ((num % 365) % 365)%7;


            Console.WriteLine("Year : " + year);
            Console.WriteLine("weeks : " + weeks);
            Console.WriteLine("day ; " + day);

        }
    }
}
