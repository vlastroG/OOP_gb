using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Lesson3
{
    /// <summary>
    /// Обработка строк
    /// </summary>
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

        /// <summary>
        /// Возвращает массив строк e-mail из файла
        /// </summary>
        /// <param name="SourceFilePath">Путь к файлу</param>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException">Исключение, если файл не найден</exception>
        /// <exception cref="FormatException">Исключение, если формат файла не верный</exception>
        public static string[] GetEmails(string SourceFilePath)
        {
            if (!File.Exists(SourceFilePath))
                throw new FileNotFoundException("Файл с данными ФИО не найден", SourceFilePath);

            var lines = new List<string>();


            using (var file = File.OpenText(SourceFilePath))
                while (!file.EndOfStream)
                {
                    var line = file.ReadLine();
                    if (line!.Length == 0) continue;

                    string email = GetEmail(line);
                    lines.Add(email);
                }

            return lines.ToArray();
        }

        /// <summary>
        /// Возвращает e-mail из строки
        /// </summary>
        /// <param name="s">Подаваемая строка</param>
        /// <returns>Возвращаемый e-mail</returns>
        /// <exception cref="FormatException">Исключение, если формат строки неверный</exception>
        public static string GetEmail(string s)
        {
            var elements = s.Split('&');
            if ((elements.Length != 2) || !elements[1].Contains('@')) throw new FormatException("Неверный формат строки!");
            s = elements[1].Trim(' ');
            return s;
        }


        /// <summary>
        /// Записать массив строк в текстовый файл
        /// </summary>
        /// <param name="fileName">Название файла без расширения</param>
        /// <param name="emailsArr">Массив строк</param>
        public static async Task WriteLinesToFile(string fileName, string[] emailsArr)
        {
            await File.WriteAllLinesAsync($"{fileName}.txt", emailsArr);
        }
    }
}
