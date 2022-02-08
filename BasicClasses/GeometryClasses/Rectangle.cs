using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClasses
{
    internal class Rectangle : Figure
    {
        /// <summary>
        /// Ширина прямоугольника
        /// </summary>
        public uint Width { get; set; }
        /// <summary>
        /// Длина прямоугольника
        /// </summary>
        public uint Length { get; set; }
        /// <summary>
        /// Стандартный конструктор прямоугольника с единичными сторонами
        /// </summary>
        public Rectangle() : base() { Width = 1; Length = 1; }
        /// <summary>
        /// Полный конструктор прямоугольника
        /// </summary>
        /// <param name="x">Вершина. Координата X</param>
        /// <param name="y">Вершина. Координата Y</param>
        /// <param name="vis">Видимость</param>
        /// <param name="col">Цвет</param>
        /// <param name="w">Ширина</param>
        /// <param name="l">Длина</param>
        public Rectangle(uint x, uint y, bool vis, Color col, uint w, uint l)
            : base(x, y, vis, col) { Width = w; Length = l; }
        /// <summary>
        /// Площадь прямоугольника
        /// </summary>
        /// <returns>Площадь</returns>
        public double Square()
        {
            return Width * Length;
        }
        public override void Print()
        {
            Drawing.DrawFigure(this, '[');
        }
    }
}
