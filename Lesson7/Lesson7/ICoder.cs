using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    /// <summary>
    /// Интерфейс шифровальщика
    /// </summary>
    internal interface ICoder
    {
        /// <summary>
        /// Зашифровывает подаваемую строку
        /// </summary>
        /// <param name="s">Подаваемая строка</param>
        /// <returns>Зашифрованная строка</returns>
        public string Encode(string s);
        /// <summary>
        /// Расшифровывает подаваемую строку
        /// </summary>
        /// <param name="s">Подаваемая строка</param>
        /// <returns>Расшифрованная строка</returns>
        public string Decode(string s);


    }
}
