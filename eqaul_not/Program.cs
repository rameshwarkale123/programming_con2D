using System;

namespace eqaul_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1,num2;
            Console.WriteLine("Check whether two integers are equal or not: ");

            Console.WriteLine("Enter first num : "); 
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second num :  ");
            num2= Convert.ToInt32(Console.ReadLine());

            if (num1 == num2) 
            {
                Console.WriteLine("{0} and {1} are eqaul", num1,num2);

            }
            else
            {
                Console.WriteLine("{0} and {1} are not eqaul", num1, num2);

            }
        }
    }
}
