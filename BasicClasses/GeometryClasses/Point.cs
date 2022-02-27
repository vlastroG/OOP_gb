using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClasses
{
    internal class Point : Figure
    {
        /// <summary>
        /// Стандартный констрктор точки
        /// </summary>
        public Point() : base()
        { }
        /// <summary>
        /// Констрктор видимых цветных точек в начале координат
        /// </summary>
        /// <param name="col"></param>
        public Point(Color col) : base(col)
        { }
        /// <summary>
        /// Констрктор точек
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="vis">Видимость</param>
        /// <param name="col">Цвет</param>
        public Point(uint x, uint y, bool vis, Color col) : base(x, y, vis, col)
        { }
        /// <summary>
        /// Вывод точки на экран
        /// </summary>
        public override void Print()
        {
            Drawing.DrawFigure(this, '.');
        }
    }
}
