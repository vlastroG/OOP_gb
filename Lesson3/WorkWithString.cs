using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public static class WorkWithString
    {
        /// <summary>
        /// Возвращает строку с символами в обратном порядке
        /// </summary>
        /// <param name="line">Подаваемая строка</param>
        /// <returns>Возвращаемая строка</returns>
        public static string ReverseString(string line)
        {
            StringBuilder sb = new();
            for (int i = line.Length; i > 0; i--)
            {
                sb.Append(line[i - 1]);
            }
            line = sb.ToString();
            return line;
        }
        /// <summary>
        /// Запрашивает строку от пользователя.
        /// </summary>
        /// <param name="messageToUser">Сообщение для пользователя</param>
        /// <returns>Введенная строка</returns>
        public static string GetStringFromUser(string messageToUser)
        {
            Console.WriteLine(messageToUser);
            return Console.ReadLine();
        }
    }
}
