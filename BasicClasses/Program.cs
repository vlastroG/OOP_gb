﻿using System;

namespace BasicClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создать класс счет в банке с закрытыми полями:
            //номер счета, баланс, тип банковского счета(использовать перечислимый тип).
            //Предусмотреть методы для доступа к данным – заполнения и чтения.Создать объект класса,
            //заполнить его поля и вывести информацию об объекте класса на печать.
            BankAccount acc1 = new BankAccount(1,1000,BankAccountType.Deposit);
            acc1.PrintInfo();
            
        }

    }
}
