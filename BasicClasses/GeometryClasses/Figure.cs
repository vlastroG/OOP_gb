using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClasses
{
    public enum Color
    {
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Indigo,
        Violet
    }
    internal class Figure
    {
        /// <summary>
        /// Видимость фигуры
        /// </summary>
        public bool Visibility { get; set; }
        /// <summary>
        /// Цвет фигуры
        /// </summary>
        public Color Color { get; set; }
        /// <summary>
        /// Координата X
        /// </summary>
        public uint X { get; private set; }
        /// <summary>
        /// Координата Y
        /// </summary>
        public uint Y { get; private set; }
        /// <summary>
        /// Стандартный констрктор фигуры: видимая, зеленая, в начале координат
        /// </summary>
        public Figure() : this(0, 0, true, Color.Green) { }
        /// <summary>
        /// Конструктор видимых цветных фигур в начале координат
        /// </summary>
        /// <param name="col">Цвет</param>
        public Figure(Color col) : this(0, 0, true, col) { }
        /// <summary>
        /// Полный конструктор
        /// </summary>
        /// <param name="x">Начальная координата X</param>
        /// <param name="y">Начальная координата Y</param>
        /// <param name="vis">Видимость</param>
        /// <param name="col">Цвет</param>
        public Figure(uint x, uint y, bool vis, Color col)
        {
            X = x;
            Y = y;
            Visibility = vis;
            Color = col;
        }
        /// <summary>
        /// Перемещение по горизонтали
        /// </summary>
        /// <param name="dX">Приращение координаты X</param>
        public virtual void MoveHor(uint dX) => X += dX;
        /// <summary>
        /// Перемещение по вертикали
        /// </summary>
        /// <param name="dY">Приращение координаты Y</param>
        public virtual void MoveVer(uint dY) => Y += dY;
        /// <summary>
        /// Вывод фигуры на экран
        /// </summary>
        public virtual void Print()
        {
            Drawing.DrawFigure(this, 'F');
        }
    }
}
