using System;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. В класс банковский счет, созданный в упражнениях, добавить метод,
            //который переводит деньги с одного счета на другой.
            //У метода два параметра:
            //ссылка на объект класса банковский счет откуда снимаются деньги,
            //второй параметр – сумма.
            Console.WriteLine("№1");
            BankAccount acc1 = new(1000);
            acc1.PrintInfo();
            BankAccount acc2 = new();
            acc2.PrintInfo();
            acc2.RequestMoney(acc2, 1000);
            acc2.RequestMoney(acc1, 2000);
            acc2.RequestMoney(acc1, -50);
            acc2.RequestMoney(acc1, 500);
            acc1.PrintInfo();
            acc2.PrintInfo();
            Console.WriteLine();
        }
    }
}
