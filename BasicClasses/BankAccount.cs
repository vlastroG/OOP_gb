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
        private int _Number;
        /// <summary>
        /// Баланс счета
        /// </summary>
        private double _Balance;
        /// <summary>
        /// Тип счета
        /// </summary>
        private BankAccountType _Type;
        /// <summary>
        /// Получить номер счета
        /// </summary>
        /// <returns>Номер счета</returns>
        public int GetNumber()
        {
            return _Number;
        }

        //public void SetNumber(int newNumber)
        //{
        //    if (newNumber >= 1)
        //    {
        //        _Number = newNumber;
        //    }
        //    else
        //    {
        //        throw new ArgumentOutOfRangeException(nameof(newNumber));
        //    }
        //}

        /// <summary>
        /// Установить номер счета
        /// </summary>
        private void SetNumber()
        {
            _Number = _ClosedNumber + 1;
            _ClosedNumber++;
        }
        /// <summary>
        /// Получить баланс
        /// </summary>
        /// <returns>Баланс</returns>
        public double GetBalance()
        {
            return _Balance;
        }
        /// <summary>
        /// Установить новый баланс
        /// </summary>
        /// <param name="newBalance">Новый баланс</param>
        public void SetBalance(double newBalance)
        {
            _Balance = newBalance;
        }
        /// <summary>
        /// Получить тип счета
        /// </summary>
        /// <returns>Тип счета</returns>
        public BankAccountType GetType()
        {
            return _Type;
        }
        /// <summary>
        /// Установить новый тип счета
        /// </summary>
        /// <param name="newType">Новый тип счета</param>
        public void SetType(BankAccountType newType)
        {
            _Type = newType;
        }
        /// <summary>
        /// Вывести информацию о счете в консоль: номер, баланс, тип
        /// </summary>
        public void PrintInfo()
        {
            Console.WriteLine($"Номер счета: {_Number};\tБаланс: {_Balance};\tТип: {_Type}");
        }
        /// <summary>
        /// Переопределение стандартного конструктора
        /// </summary>
        public BankAccount()
        {
            SetNumber();
        }
        /// <summary>
        /// Полный конструктор
        /// </summary>
        /// <param name="number">Номер счета</param>
        /// <param name="balance">Баланс</param>
        /// <param name="type">Тип счета</param>
        public BankAccount(double balance, BankAccountType type)
        {
            SetNumber();
            SetBalance(balance);
            SetType(type);
        }
    }

}
