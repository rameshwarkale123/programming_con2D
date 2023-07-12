using System;
using System.Net;

namespace month
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int monthnum;
            
            Console.WriteLine("Enter month number 1-12: ");
            monthnum = Convert.ToInt32(Console.ReadLine());


            switch (monthnum)
            {
                case 1: Console.WriteLine("jan 31 days");
                    break;

                    case 2: Console.WriteLine("feb 28, 29 days");
                    break;
                    case 3: Console.WriteLine("march 31 days");
                    break;
                    case 4: Console.WriteLine("april 30days");
                    break;
                    case 5: Console.WriteLine("may 31 days");
                    break;
                    case 6: Console.WriteLine("jun 30 day ");
                    break;
                    case 7: Console.WriteLine("jul 31 days");
                    break;
                    case 8: Console.WriteLine("aug 31 day");
                    break;
                    case 9: Console.WriteLine("sep 30 day");
                    break;
                    case 10: Console.WriteLine("oct 31 day");
                    break;
                    case 11: Console.WriteLine("nov 30 day");
                    break;
                    case 12: Console.WriteLine("dece 31 day");
                    break;
                    default: Console.WriteLine("invalid input");
                    break;

                        
                      

            }
        }
    }
}
