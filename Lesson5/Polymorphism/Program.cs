using System;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RationalNumbers num1 = new();
            RationalNumbers num2 = new(100);
            RationalNumbers num3 = new(21, 51);

            Console.WriteLine(num1.ToString());
            Console.WriteLine(num2.ToString());
            Console.WriteLine(num3.ToString());

        }
    }
}
