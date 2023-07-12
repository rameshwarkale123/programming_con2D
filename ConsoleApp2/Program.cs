using System;

namespace Addmission_eligibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Hello World!");
            int phy, che, math;
            Console.WriteLine("Find the eligibility for Admimission : ");
            Console.WriteLine("Eligibility for criteria : ");
            Console.WriteLine("Mark in phy >=55");
            Console.WriteLine("Mark for chem >= 50");
            Console.WriteLine("MArk in math >= 65");
            Console.WriteLine("Total three sub mark >=180 ");
            Console.WriteLine("Math and phy mark >= 180");


            Console.WriteLine("Enter the mark in phy");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the mark in che");
            che = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the mark in math");
            math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Total mark of phy,che,math : {0}",+phy+" "+che+" "+math);
            Console.WriteLine("Total mark of phy,math :{0}", + phy + math);


            if (phy >= 55)
                if (che >= 50)
                    if (math >= 65)
                        if ((phy + math + che) >= 180 || (math + phy) >= 140)
                            Console.WriteLine("The Candiadate eligible for admission");
                        else Console.WriteLine("The candiadate is not eligible for addmission");
                    else Console.WriteLine("The candidate not not eligible for admission ");

                else Console.WriteLine("The candidate is not eligible for admission");
            else Console.WriteLine("The candidate is noteligible for admission");

                


        }

    }
}
 