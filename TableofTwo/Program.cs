using System;

namespace TableofTwo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter the value of n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Powers of 2:");
            for (int i = 0; i <= n; i++)
            {
                double powerOfTwo = Math.Pow(2, i);
                Console.WriteLine($"2^{i} = {powerOfTwo}");
              
            }
            
           
        }
    }
}
