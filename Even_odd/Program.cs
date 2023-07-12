using System;

namespace Even_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
           
            Console.WriteLine("Enter the number");
            a = Convert.ToInt32(Console.ReadLine()); ;

            if (a %2  == 0)
            {
                Console.WriteLine(a + "is even  ");

            }
            else
            {
                Console.WriteLine(a+ "is odd number");
            }
        }
    }
}
