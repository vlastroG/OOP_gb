using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BasicClasses
{
    internal abstract class Drawing
    {
        /// <summary>
        /// Рисунок класса фигуры
        /// </summary>
        /// <param name="f">Экземпляр класса фигуры</param>
        internal static void DrawFigure(Figure f, char symbol)
        {
            switch (f.Color)
            {
                case Color.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Color.Orange:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case Color.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case Color.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case Color.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case Color.Indigo:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case Color.Violet:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
            }
            if (f.Visibility == false)
            {
                Console.ForegroundColor = ConsoleColor.Black;
            }
            Console.SetCursorPosition((int)f.X, (int)f.Y);
            Console.Write(symbol);
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
