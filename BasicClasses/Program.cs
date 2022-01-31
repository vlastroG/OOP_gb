using System;

namespace BasicClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("№1");
            //1. Создать класс счет в банке с закрытыми полями:
            //номер счета, баланс, тип банковского счета(использовать перечислимый тип).
            //Предусмотреть методы для доступа к данным – заполнения и чтения.Создать объект класса,
            //заполнить его поля и вывести информацию об объекте класса на печать.
            BankAccount acc1 = new BankAccount(1000, BankAccountType.Deposit);
            acc1.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("№2");
            //2. Изменить класс счет в банке из упражнения таким образом,
            //чтобы номер счета генерировался сам и был уникальным.
            //Для этого надо создать в классе статическую переменную и метод,
            //который увеличивает значение этого переменной
            BankAccount acc2 = new BankAccount(2000, BankAccountType.Current);
            acc2.PrintInfo();
            BankAccount acc3 = new();
            //acc3.SetBalance(3000.50);
            acc3.PrintInfo();
            BankAccount acc4 = new();
            acc4.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("№3");
            //3.В классе банковский счет удалить методы заполнения полей.
            //Вместо этих методов создать конструкторы.
            //Переопределить конструктор по умолчанию, создать конструктор для заполнения поля баланс,
            //конструктор для заполнения поля тип банковского счета,
            //конструктор для заполнения баланса и типа банковского счета.
            //Каждый конструктор должен вызывать метод, генерирующий номер счета.
            BankAccount acc5 = new();
            acc5.PrintInfo();
            BankAccount acc6 = new(999.99);
            acc6.PrintInfo();
            BankAccount acc7 = new(BankAccountType.Settlement);
            acc7.PrintInfo();
            BankAccount acc8 = new(199.60, BankAccountType.Credit);
            acc8.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("№4");
            //4.В классе все методы для заполнения и получения значений полей заменить на свойства.
            //Написать тестовый пример.
            BankAccount acc9 = new();
            acc9.Balance = 70;
            acc9.Type = BankAccountType.Deposit;
            acc9.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("№5");
            //5. * Добавить в класс счет в банке два метода:
            //снять со счета и положить на счет. Метод снять со счета проверяет,
            //возможно ли снять запрашиваемую сумму, и в случае положительного результата изменяет баланс.
            BankAccount acc10 = new(1000);
            acc10.PrintInfo();
            acc10.PutMoney(10000);
            acc10.PrintInfo();
            acc10.GetMoney(1000000);
            acc10.GetMoney(-1000);
            acc10.GetMoney(500);
            acc10.PrintInfo();
        }

    }
}
