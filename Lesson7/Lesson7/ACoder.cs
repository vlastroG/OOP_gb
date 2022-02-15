using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    /// <summary>
    /// Класс шифрует строку посредством сдвига
    /// каждого символа на одну «алфавитную» позицию выше.
    /// (В результате такого сдвига буква А становится буквой Б).
    /// </summary>
    internal class ACoder : ICoder
    {
        /// <summary>
        /// Сдвигает символ на 1 позицию вниз по кодировке utf16
        /// </summary>
        /// <param name="s">Подаваемая строка</param>
        /// <returns>Возвращаемая строка</returns>
        /// <exception cref="ArgumentException">Исключение, если  is Null</exception>
        public string Decode(string s)
        {
            if (s is null)
            {
                throw new ArgumentException($"{nameof(s)} is Null");
            }
            char[] arr = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                var isLow = char.IsLower(s[i]);
                var sCharInt = char.ToLower(s[i]) - 1;
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
        /// <summary>
        /// Сдвигает символ на 1 позицию вверх по кодировке utf16
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
                var isLow = char.IsLower(s[i]);
                var sCharInt = char.ToLower(s[i]) + 1;
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
