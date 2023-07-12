using System;
using System.ComponentModel.DataAnnotations;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string ");
            string str, reverse;
            str = Console.ReadLine();
            reverse = "";
            int len;
            Console.WriteLine("Given string is : {0}", str);
            len = str.Length -1;

            while (len >= 0)
            {
                reverse = reverse + str[len];  ;
                len--;
            }

            Console.WriteLine("reverse string is : {0}", reverse);
        }
    }
}
