using System;

namespace WeekDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weekday;

            Console.WriteLine("Enter WeekDay number (1-7) : ");
            weekday = Convert.ToInt32(Console.ReadLine());


            switch (weekday)
            {
                case 1: Console.WriteLine("it is Sunday");
                    break;
                case 2: Console.WriteLine("it is Monday");
                    break;
                case 3: Console.WriteLine("it is Tuesday");
                    break;
                case 4: Console.WriteLine("it is wendesday");
                    break;
                case 5: Console.WriteLine("it is Thusday");
                    break;
                case 6: Console.WriteLine("it is friday");
                    break;
                case 7: Console.WriteLine("it is saturday");
                    break;
                default: Console.WriteLine("Invalid Number");
                    break;
            }
        }
    }
}
