using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    /// <summary>
    /// Класс шифрует строку, выполняя замену каждой буквы,
    /// стоящей в алфавите на i-й позиции, на букву того же регистра,
    /// расположенную в алфавите на i-й позиции с конца алфавита.
    /// (Например, буква В заменяется на букву Э.
    /// Написать программу, демонстрирующую функционирование классов).
    /// </summary>
    internal class BCoder : ICoder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string Decode(string s)
        {
            return Encode(s);
        }
        /// <summary>
        /// Зеркалит расположение буквы в строке по номеру в алфавите (первая => последняя, вторая => предпоследняя)
        /// </summary>
        /// <param name="s">Подаваемая строка</param>
        /// <returns>Возвращаемая строка</returns>
        /// <exception cref="ArgumentException">Исключение, если <paramref name="s"/> is Null</exception>
        public string Encode(string s)
        {
            if (s is null)
            {
                throw new ArgumentException($"{nameof(s)} is Null");
            }
            char[] arr = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                int firstRusLow = 1072;//буква 'а' в utf16
                int lastRusLow = 1103;//буква 'я' в utf 16

                int firstEngLow = 97;//буква 'a' в utf 16
                int lastEngLow = 122;//буква 'z' в utf 16

                var isLow = char.IsLower(s[i]);
                var sCharInt = (int)char.ToLower(s[i]);
                if (sCharInt >= firstRusLow && sCharInt <= lastRusLow)//Обработка русского алфавита
                {
                    sCharInt = lastRusLow - (sCharInt - firstRusLow);
                }
                if (sCharInt >= firstEngLow && sCharInt <= lastEngLow)//Обработка английского алфавита
                {
                    sCharInt = lastEngLow - (sCharInt - firstEngLow);
                }

                if (isLow)//Возвращение исходного регистра буквы
                {
                    arr[i] = (char)sCharInt;
                }
                else
                {
                    arr[i] = char.ToUpper((char)sCharInt);
                }
            }
            return new string(arr);
        }
    }
}
