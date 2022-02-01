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

    }

}
