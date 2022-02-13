using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    /// <summary>
    /// Тип банковского аккаунта
    /// </summary>
    public enum BankAccountType
    {
        Current,
        Settlement,
        Credit,
        Deposit
        //текущий       -   current;
        //расчетный     -   settlement;
        //кредитный     -   credit;
        //депозитный    -   deposit.
    }
    /// <summary>
    /// Банковский счет
    /// </summary>
    internal class BankAccount
    {
        /// <summary>
        /// Предыдущий номер счета
        /// </summary>
        private static int _ClosedNumber = 0;

        /// <summary>
        /// Номер счета
        /// </summary>
        public int Number { get; private set; }

        /// <summary>
        /// Баланс счета
        /// </summary>
        public double Balance { get; set; }

        /// <summary>
        /// Тип счета
        /// </summary>
        public BankAccountType Type { get; set; }

        /// <summary>
        /// Вывести информацию о счете в консоль: номер, баланс, тип
        /// </summary>
        public void PrintInfo()
        {
            Console.WriteLine($"Номер счета: {Number};\tБаланс: {Balance};\tТип: {Type}");
        }

        /// <summary>
        /// Положить деньги на счет.
        /// </summary>
        /// <param name="money">Сумма ввода.</param>
        public void PutMoney(double money)
        {
            Balance += money;
        }

        /// <summary>
        /// Снять деньги со счета
        /// </summary>
        /// <param name="money">Запрашиваемая сумма</param>
        /// <returns>Возвращаемая сумма, при условии наличия данной суммы на счете.</returns>
        public double GetMoney(double money)
        {
            if ((money >= 0) && (money <= Balance))
            {
                Balance -= money;
                return money;
            }
            else if (money < 0)
            {
                Console.WriteLine("Вы ввели отрицательную сумму!");
                return 0;
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете!");
                return 0;
            }
        }

        /// <summary>
        /// Запросить деньги со счета.
        /// </summary>
        /// <param name="acc">Счет, с которого запрашивается сумма</param>
        /// <param name="money">Запрашиваемая сумма</param>
        public void RequestMoney(BankAccount acc, double money)
        {
            if (acc != this)
            {
                PutMoney(acc.GetMoney(money));
            }
            else
            {
                Console.WriteLine("Счет получателя и запрашиваемый счет должны быть разными!");
            }
        }

        /// <summary>
        /// Переопределение стандартного конструктора. Назначает только номер счета.
        /// </summary>
        public BankAccount()
        {
            Number = ++_ClosedNumber;
        }

        /// <summary>
        /// Полный конструктор, назначающий номер, баланс и тип счета.
        /// </summary>
        /// <param name="number">Номер счета</param>
        /// <param name="balance">Баланс</param>
        /// <param name="type">Тип счета</param>
        public BankAccount(double balance, BankAccountType type)
        {

            Number = _ClosedNumber + 1;
            _ClosedNumber++;
            Balance = balance;
            Type = type;
        }

        /// <summary>
        /// Конструктор, задающий баланс счета.
        /// </summary>
        /// <param name="balance">Баланс счета</param>
        public BankAccount(double balance)
        {
            Number = _ClosedNumber + 1;
            _ClosedNumber++;
            Balance = balance;
        }

        /// <summary>
        /// Конструктор, задающий тип счета.
        /// </summary>
        /// <param name="type">Тип счета</param>
        public BankAccount(BankAccountType type)
        {
            Number = _ClosedNumber + 1;
            _ClosedNumber++;
            Type = type;
        }
    }
}