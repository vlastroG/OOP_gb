using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    /// <summary>
    /// Класс рациональных чисел
    /// </summary>
    internal class RationalNumbers
    {
        /// <summary>
        /// Значение числителя
        /// </summary>
        private int _numerator;
        /// <summary>
        /// Значение знаменателя
        /// </summary>
        private int _denumerator;
        /// <summary>
        /// Числитель рационального числа
        /// </summary>
        public int Numerator { get { return _numerator; } set { _numerator = value; } }
        /// <summary>
        /// Знаменатель рационального числа
        /// </summary>
        public int Denumerator
        {
            get { return _denumerator; }
            set
            {
                if (value != 0)
                {
                    _denumerator = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Знаменатель равен нулю.");
                }
            }
        }
        /// <summary>
        /// Переопределение стандартного констрктора. (0/1)
        /// </summary>
        public RationalNumbers() { Numerator = 0; Denumerator = 1; }
        /// <summary>
        /// Полный констрктор (Числитель/Знаменатель)
        /// </summary>
        /// <param name="numerator">Числитель</param>
        /// <param name="denumerator">Знаменатель</param>
        public RationalNumbers(int numerator, int denumerator)
        {
            Numerator = numerator;
            Denumerator = denumerator;
        }
        /// <summary>
        /// Конструктор целых чисел (Числитель/1)
        /// </summary>
        /// <param name="numerator">Числитель</param>
        public RationalNumbers(int numerator) : this(numerator, 1) { }
        /// <summary>
        /// Представление рационального числа в виде обыкновенной неупрощенной дроби.
        /// </summary>
        /// <returns>[Числитель]/[Знаменатель]</returns>
        public override string ToString()
        {
            StringBuilder strB = new();
            strB.Append(Numerator);
            strB.Append('/');
            strB.Append(Denumerator);
            return strB.ToString();
        }
        /// <summary>
        /// Проверка на равенство двух рациональных чисел
        /// </summary>
        /// <param name="number1">Первое число</param>
        /// <param name="number2">Второе число</param>
        /// <returns>true/false</returns>
        public static bool operator ==(RationalNumbers number1, RationalNumbers number2)
        {
            if ((number1.Numerator == 0) && (0 == number2.Numerator))
            {
                return true;
            }
            else if ((number1.Numerator != 0) && (number2.Numerator != 0) &&
                ((number2.Denumerator * number1.Numerator) == (number2.Numerator * number1.Denumerator)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Проверка на неравенство двух рациональных чисел
        /// </summary>
        /// <param name="number1">Первое число</param>
        /// <param name="number2">Второе число</param>
        /// <returns>true/false</returns>
        public static bool operator !=(RationalNumbers number1, RationalNumbers number2)
        {
            return !(number1 == number2);
        }
        /// <summary>
        /// Равно ли подаваемое число текущему?
        /// </summary>
        /// <param name="num2">Подаваемое число</param>
        /// <returns>true/false</returns>
        public bool Equals(RationalNumbers num2)
        {
            return (this == num2);
        }
        /// <summary>
        /// Первое число меньше второго?
        /// </summary>
        /// <param name="number1">Первое число</param>
        /// <param name="number2">Второе число</param>
        /// <returns>true/false</returns>
        public static bool operator <(RationalNumbers number1, RationalNumbers number2)
        {
            if ((number1.Numerator * number2.Denumerator - number2.Numerator * number1.Denumerator) < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Первое число больше второго?
        /// </summary>
        /// <param name="number1">Первое число</param>
        /// <param name="number2">Второе число</param>
        /// <returns>true/false</returns>
        public static bool operator >(RationalNumbers number1, RationalNumbers number2)
        {
            if ((number1.Numerator * number2.Denumerator - number2.Numerator * number1.Denumerator) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(RationalNumbers number1, RationalNumbers number2)
        {
            if ((number1.Numerator * number2.Denumerator - number2.Numerator * number1.Denumerator) <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >=(RationalNumbers number1, RationalNumbers number2)
        {
            if ((number1.Numerator * number2.Denumerator - number2.Numerator * number1.Denumerator) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static RationalNumbers operator +(RationalNumbers number1, RationalNumbers number2)
        {
            var denum = number1.Denumerator * number2.Denumerator;
            var numer = number1.Numerator * number2.Denumerator + number1.Denumerator * number2.Numerator;
            return new RationalNumbers(numer, denum);
        }
        public static RationalNumbers operator -(RationalNumbers number1, RationalNumbers number2)
        {
            var denum = number1.Denumerator * number2.Denumerator;
            var numer = number1.Numerator * number2.Denumerator - number1.Denumerator * number2.Numerator;
            return new RationalNumbers(numer, denum);
        }
        public static RationalNumbers operator ++(RationalNumbers num)
        {
            var numNew = num.Numerator + num.Denumerator;
            num.Numerator = numNew;
            return num;
        }
        public static RationalNumbers operator --(RationalNumbers num)
        {
            var numNew = num.Numerator - num.Denumerator;
            num.Numerator = numNew;
            return num;
        }
        public static RationalNumbers operator *(RationalNumbers num1, RationalNumbers num2)
        {
            var numer = num1.Numerator * num2.Numerator;
            var denum = num1.Denumerator * num2.Denumerator;
            return new RationalNumbers(numer, denum);
        }
        public static RationalNumbers operator /(RationalNumbers num1, RationalNumbers num2)
        {
            var numer = num1.Numerator * num2.Denumerator;
            var denum = num1.Denumerator * num2.Numerator;
            var resNum = numer / denum * denum;
            return new RationalNumbers(resNum, denum);
        }
        public static RationalNumbers operator %(RationalNumbers num1, RationalNumbers num2)
        {
            var numer = num1.Numerator * num2.Denumerator;
            var denum = num1.Denumerator * num2.Numerator;
            var resNum = numer % denum;
            return new RationalNumbers(resNum, denum);
        }
        public static explicit operator int(RationalNumbers num)
        {
            int newNum = num.Numerator / num.Denumerator;
            return newNum;
        }
        public static explicit operator float(RationalNumbers num)
        {
            float newNum = (float)num.Numerator / (float)num.Denumerator;
            return newNum;
        }
        public static explicit operator RationalNumbers(int num)
        {
            return new RationalNumbers(num);
        }
        public static explicit operator RationalNumbers(float num)
        {
            if ((num > int.MaxValue) || (num < int.MinValue))
            {
                throw new ArgumentOutOfRangeException($"Модуль числа {nameof(num)} слишком большой");
            }
            else if ((num >= -10000) && (num <= 10000))
            {
                int pastPoint = 100000;//Количество сохраняемых знаков после запятой
                var newNum = (int)(num * pastPoint);
                return new RationalNumbers(newNum, pastPoint);
            }
            else
            {
                var newNum = (int)num;
                return new RationalNumbers(newNum);
            }
        }
    }

}
