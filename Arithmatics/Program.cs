using System;

namespace Arithmatics
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the first number :");
           int  num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the decond number");
           int  num2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("1. Addition");
            Console.WriteLine("2. substraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1: Console.WriteLine("Addition of  two number is :" +(num1 + num2)); break;
                case 2: Console.WriteLine("Substraction of two numbers is :" +(num1 - num2)); break;
                case 3: Console.WriteLine("Multiplication of two numbers is :" +(num1 * num2)); break;
                case 4: Console.WriteLine("Division of two numbers is :" +(num1 / num2)); break;
                default: Console.WriteLine("Invalid Enter number"); break;

            }
        }
    }
}
