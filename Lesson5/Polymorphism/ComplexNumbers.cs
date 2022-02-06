using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class ComplexNumbers
    {
        /// <summary>
        /// Параметр вещественной части
        /// </summary>
        private double _realA;
        /// <summary>
        /// Параметр мнимой части
        /// </summary>
        private double _realB;
        /// <summary>
        /// Вещественная часть
        /// </summary>
        public double RealA { get { return _realA; } set { _realA = value; } }
        /// <summary>
        /// Мнимая часть
        /// </summary>
        public double RealB { get { return _realB; } set { _realB = value; } }
        /// <summary>
        /// Переопределение стандартного конструктора
        /// </summary>
        public ComplexNumbers()
        {
            RealA = 0;
            RealB = 0;
        }
        /// <summary>
        /// Полный конструктор
        /// </summary>
        /// <param name="A">Параметр вещественной части</param>
        /// <param name="B">Параметр мнимой части</param>
        public ComplexNumbers(double A, double B)
        {
            RealA = A;
            RealB = B;
        }
        /// <summary>
        /// Стоковое представление комплексного числа
        /// </summary>
        /// <returns>a + bi</returns>
        public override string ToString()
        {
            StringBuilder strB = new();
            strB.Append(RealA);
            strB.Append(" + ");
            strB.Append(RealB);
            strB.Append('i');
            return strB.ToString();
        }
        public static bool operator ==(ComplexNumbers n1, ComplexNumbers n2)
        {
            if ((n1.RealA == n2.RealA) && (n1.RealB == n2.RealB))
            {
                return true;
            }
            else
                return false;
        }
        public static bool operator !=(ComplexNumbers n1, ComplexNumbers n2)
        {
            return !(n1 == n2);
        }
        public static ComplexNumbers operator +(ComplexNumbers n1, ComplexNumbers n2)
        {
            var A = n1.RealA + n2.RealA;
            var B = n1.RealB + n2.RealB;
            return new ComplexNumbers(A, B);
        }
        public static ComplexNumbers operator -(ComplexNumbers n1, ComplexNumbers n2)
        {
            var A = n1.RealA - n2.RealA;
            var B = n1.RealB - n2.RealB;
            return new ComplexNumbers(A, B);
        }
        public static ComplexNumbers operator *(ComplexNumbers n1, ComplexNumbers n2)
        {
            var A = n1.RealA * n2.RealA - n1.RealB * n2.RealB;
            var B = n1.RealA * n2.RealB + n1.RealB * n2.RealA;
            return new ComplexNumbers(A, B);
        }
    }
}
