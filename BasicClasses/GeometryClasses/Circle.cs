using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClasses
{
    internal class Circle : Point
    {
        /// <summary>
        /// Радиус окружности
        /// </summary>
        public uint Radius { get; set; }
        /// <summary>
        /// Стандартный конструктор единичной окружности в начале координат
        /// </summary>
        public Circle() : base() { Radius = 1; }
        /// <summary>
        /// Полный конструктор окружности
        /// </summary>
        /// <param name="x">Центр, координата X</param>
        /// <param name="y">Центр, еоордината Y</param>
        /// <param name="vis">Видимость</param>
        /// <param name="col">Цвет</param>
        /// <param name="r">Радиус</param>
        public Circle(uint x, uint y, bool vis, Color col, uint r) : base(x, y, vis, col) { Radius = r; }
        /// <summary>
        /// Площадь круга
        /// </summary>
        /// <returns>Площадь</returns>
        public double Square()
        {
            return 3.14159265 * Radius * Radius;
        }
        /// <summary>
        /// Вывод окружности на экран
        /// </summary>
        public override void Print()
        {
            Drawing.DrawFigure(this, '0');
        }
    }
}
