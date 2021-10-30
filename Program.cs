using System;

namespace cSharpMasterClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring several variables at once

            int num3, num4, num5;

            //Declaring variable
            int num1;
            //assigning variable
            num1 = 13;
            //Declaring and assigning variable
            int num2 = 31;
            num2 = 127;
            int sum = num1 + num2;

            

            Console.WriteLine($"num1: {num1} + num2: {num2} is {sum}");

            double d1 = 3.23;
            double d2 = 4.24;

            double dDiv = d1 / d2;
            Console.WriteLine($"d1/d2 is {dDiv}");


            float f1 = 3.23f;
            float f2 = 4.24f;

            float fDiv = f1 / f2;
            Console.WriteLine($"f1/f2 is {fDiv}");


           
            Console.ReadLine();
        }
    }
}
