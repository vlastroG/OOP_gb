using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClasses
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
        /// Переопределение стандартного конструктора. Назначает только номер счета.
        /// </summary>
        public BankAccount()
        {
            Number = _ClosedNumber + 1;
            _ClosedNumber++;
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
