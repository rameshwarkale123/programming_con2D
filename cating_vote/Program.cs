using System;

namespace cating_vote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter the age of the candidate: ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18) 
            {
                Console.WriteLine("you are eligible for vote");
            }
            else
            {
                Console.WriteLine("you are not eligible for vote");

            }
            
        }
    }
}
