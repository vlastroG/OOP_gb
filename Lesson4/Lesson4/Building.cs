using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    /// <summary>
    /// Строитель зданий
    /// </summary>
    internal class Creator
    {
        /// <summary>
        /// Здание
        /// </summary>
        internal class Building
        {
            //1. Реализовать класс для описания здания
            //(уникальный номер здания, высота, этажность, количество квартир, подъездов).
            //Поля сделать закрытыми, предусмотреть методы для заполнения полей
            //и получения значений полей для печати.
            //Добавить методы вычисления высоты этажа,
            //количества квартир в подъезде, количества квартир на этаже и т.д.
            //Предусмотреть возможность,
            //чтобы уникальный номер здания генерировался программно.
            //Для этого в классе предусмотреть статическое поле,
            //которое бы хранило последний использованный номер здания,
            //и предусмотреть метод, который увеличивал бы значение этого поля.

            /// <summary>
            /// Предыдущий номер дома
            /// </summary>
            private static int _lastNumber;

            /// <summary>
            /// Номер здания
            /// </summary>
            public int Number { get; private set; }

            /// <summary>
            /// Число этажей здания
            /// </summary>
            private int _levels;

            /// <summary>
            /// Высота здания
            /// </summary>
            private double _height;

            /// <summary>
            /// Число подъездов
            /// </summary>
            private int _entrances;

            /// <summary>
            /// Количество этажей
            /// </summary>
            public int Levels { get { return _levels; } }

            /// <summary>
            /// Установить количество этажей
            /// </summary>
            /// <param name="levels">Количество этажей</param>
            /// <exception cref="ArgumentOutOfRangeException">Исключение, если количество этажей недопустимо</exception>
            private void SetLevels(int levels)
            {
                //Можно построить здание с числом этажей от 1 до 25.
                if ((levels >= 1) && (levels <= 25))
                {
                    _levels = levels;
                }
                else throw new ArgumentOutOfRangeException("Нельзя строить здание с данным количеством этажей.");

            }

            /// <summary>
            /// Высота здания
            /// </summary>
            public double Height
            {
                get { return _height; }
                private set
                {
                    double minHeight = 2.7 * Levels; //Минимальная высота здания исходя из минимальной высоты этажа 2.7 м
                    double maxHeight = 3.5 * Levels; //Максимальная высота здания исходя из максимальной высоты этажа 3.5 м
                    if ((value >= minHeight) && (value <= maxHeight))
                    {
                        _height = value;
                    }
                    else throw new ArgumentOutOfRangeException("Нельзя строить здание с такой высотой при данном количестве этажей");

                }
            }

            /// <summary>
            /// Количество подъездов
            /// </summary>
            public int Entrances
            {
                get { return _entrances; }
                private set
                {
                    //В здании может быть от 1 до 10 подъездов.
                    if ((value >= 1) && (value <= 10))
                    {
                        _entrances = value;
                    }
                    else throw new ArgumentOutOfRangeException("Неверное количество подъездов.");
                }
            }

            /// <summary>
            /// Число квартир в доме.
            /// </summary>
            private int _apartments;

            /// <summary>
            /// Установить чило квартир в доме.
            /// </summary>
            private void SetApartments()
            {
                var apartmentsPerEntrance = 5; //Число квартир на 1 лестничной клетке.
                _apartments = Convert.ToInt32(Levels) * Entrances * apartmentsPerEntrance;
            }

            /// <summary>
            /// Количество квартир в здании
            /// </summary>
            public int Apartments { get { return _apartments; } }

            /// <summary>
            /// Количество квартир на этаже
            /// </summary>
            public int ApartmentsPerLevel { get { return _apartments / Levels; } }

            /// <summary>
            /// Количество квартир в подъезде
            /// </summary>
            public int ApartmentsPerEntrance { get { return _apartments / Entrances; } }

            /// <summary>
            /// Высота этажа
            /// </summary>
            public double FloorHeight { get { return _height / _levels; } }
            /// <summary>
            /// Вывод информации о здании Номер, Высота, Количество этажей, Количество подъездов, Количество квартир в доме
            /// </summary>
            public void PrintInfo()
            {
                Console.WriteLine("№ дома: {0}; Высота: {1}; Количество этажей: {2}; Количество подъездов: {3}; Количество квартир {4}.", Number, Height, Levels, Entrances, Apartments);
            }

            /// <summary>
            /// Переопределение стандартного конструктора.
            /// По умолчанию создается 10-тиэтажное здание высотой 30 м с 5-ю подъездами и 250 квартирами.
            /// </summary>
            public Building()
            {
                Number = _lastNumber + 1;
                _lastNumber++;
                SetLevels(10);
                Height = 30;
                Entrances = 5;
                SetApartments();
                _hashTable.Add(Number, this);
            }

            /// <summary>
            /// Полный конструктор здания.
            /// </summary>
            /// <param name="levels">Число этажей от 1 до 25.</param>
            /// <param name="height">Высота с учетом минимальной и максимальной высоты этажа 2.7 м и 3.5 м соответственно.</param>
            /// <param name="entrances">Число подъездов от 1 до 10.</param>
            public Building(int levels, double height, int entrances)
            {
                Number = _lastNumber + 1;
                _lastNumber++;
                SetLevels(levels);
                Height = height;
                Entrances = entrances;
                SetApartments();
                _hashTable.Add(Number, this);
            }
        }
        /// <summary>
        /// Хэш-таблица зданий внутри creator
        /// </summary>
        private static Hashtable _hashTable = new();
        /// <summary>
        /// Хэш-таблица зданий
        /// </summary>
        public static Hashtable HashTable { get { return _hashTable; } }
        /// <summary>
        /// Переопределение стандартного констрктора
        /// </summary>
        private Creator() { }
    }
}
