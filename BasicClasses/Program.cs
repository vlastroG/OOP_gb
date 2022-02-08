using System;

namespace BasicClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
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
            */
            /*
            BankAccount acc = new(700);
            BankAccount acc2 = new(700, BankAccountType.Deposit);
            var s = acc.ToString();
            var hash = acc.GetHashCode();
            var eq = acc2.Equals(acc);
            var comp = (acc2 == acc);
            var comp2 = (acc2 != acc);
            var hash2 = acc2.GetHashCode();
            */
            Figure f1 = new();
            f1.Print();
            Figure f2 = new(20, 20, true, Color.Red);
            Figure f3 = new(Color.Blue);
            Figure f4 = new(15, 5, false, Color.Orange);
            f3.MoveHor(10);
            f2.Print();
            f3.Print();
            f4.Print();


            Point p1 = new();
            p1.MoveVer(9);
            p1.Color = Color.Indigo;
            p1.Print();


            Circle c1 = new(12, 12, true, Color.Yellow, 3);
            var sqCir = c1.Square();
            c1.Print();
            c1.MoveHor(6);
            c1.Print();

            Rectangle rec1 = new();
            rec1.MoveHor(21);
            rec1.MoveVer(12);
            rec1.Length = 5;
            rec1.Width = 7;
            rec1.Color = Color.Violet;
            var recS = rec1.Square();
            rec1.Print();
        }

    }
}
