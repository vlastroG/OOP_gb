using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClasses
{
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
    internal class BankAccount
    {
        private int _Number;
        private double _Balance;
        private BankAccountType _Type;
        public int GetNumber()
        {
            return _Number;
        }
        public void SetNumber(int newNumber)
        {
            if (newNumber >= 1)
            {
                _Number = newNumber;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(newNumber));
            }
        }
        public double GetBalance()
        {
            return _Balance;
        }
        public void SetBalance(double newBalance)
        {
            _Balance = newBalance;
        }
        public BankAccountType GetType()
        {
            return _Type;
        }
        public void SetType(BankAccountType newType)
        {
            _Type = newType;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Номер счета: {_Number};\tБаланс: {_Balance};\tТип: {_Type}");
        }
        public BankAccount()
        {
        }
        public BankAccount(int number, double balance, BankAccountType type)
        {
            SetNumber(number);
            SetBalance(balance);
            SetType(type);
        }
    }

}
