using System;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            RationalNumbers num1 = new();
            RationalNumbers num2 = new(100);
            RationalNumbers num3 = new(21, 51);

            Console.WriteLine(num1.ToString());
            Console.WriteLine(num2.ToString());
            Console.WriteLine(num3.ToString());

            var sum = num2 + num3;
            num1++;
            sum--;
            var mult = sum * num1;
            var div = mult / num1;
            var perc = mult % num1;
            var minus = perc - sum;

            RationalNumbers n1 = new(10, 10);
            RationalNumbers n2 = new(11, 10);
            RationalNumbers n3 = new(1, 10);
            RationalNumbers n4 = n1 + n3;
            bool comparison = (n1 > n2);
            comparison = (n1 < n2);
            comparison = (n4 == n2);
            comparison = (n1 != n4);
            comparison = (n1 >= n3);
            comparison = (n4 <= n2);
            n4.Equals(n2);

            int a = (int)n1;
            float b = (float)n2;
            var nn1 = (RationalNumbers)a;
            b += (float)0.023456;
            var nn2 = (RationalNumbers)b;
            */
            ComplexNumbers n1 = new();
            ComplexNumbers n2 = new(100, 20.6);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            n1.RealA = 50 + 50;
            bool res = (n1 != n2);
            n1.RealB = 20 + 0.6;
            res = (n1 == n2);
            var res2 = n2 + n2;
            res2 = n2 - n2;

            var mul = n2 * res2;
            mul = n2 * n2;
        }
    }
}
