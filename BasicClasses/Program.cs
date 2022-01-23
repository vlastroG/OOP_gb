using System;

namespace BasicClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Создать класс счет в банке с закрытыми полями:
            //номер счета, баланс, тип банковского счета(использовать перечислимый тип).
            //Предусмотреть методы для доступа к данным – заполнения и чтения.Создать объект класса,
            //заполнить его поля и вывести информацию об объекте класса на печать.
            BankAccount acc1 = new BankAccount(1000, BankAccountType.Deposit);
            acc1.PrintInfo();
            //2. Изменить класс счет в банке из упражнения таким образом,
            //чтобы номер счета генерировался сам и был уникальным.
            //Для этого надо создать в классе статическую переменную и метод,
            //который увеличивает значение этого переменной
            BankAccount acc2 = new BankAccount(2000, BankAccountType.Current);
            acc2.PrintInfo();
            BankAccount acc3 = new();
            acc3.SetBalance(3000.50);
            acc3.PrintInfo();
            BankAccount acc4 = new();
            acc4.PrintInfo();
        }

    }
}
