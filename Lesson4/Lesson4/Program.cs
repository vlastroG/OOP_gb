using System;

namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building b1 = new();
            b1.PrintInfo();

            Building b2 = new(8, 25, 7);
            b2.PrintInfo();

            Console.WriteLine();
            Console.WriteLine($"b1 FloorHeight: {b1.FloorHeight}");
            Console.WriteLine($"b2 FloorHeight: {b2.FloorHeight}");
            Console.WriteLine($"b1 ApartmentsPerEntrance: {b1.ApartmentsPerEntrance}");
            Console.WriteLine($"b2 ApartmentsPerEntrance: {b2.ApartmentsPerEntrance}");
            Console.WriteLine($"b1 ApartmentsPerLevel: {b1.ApartmentsPerLevel}");
            Console.WriteLine($"b2 ApartmentsPerLevel: {b2.ApartmentsPerLevel}");
            Console.WriteLine($"b1 Apartments: {b1.Apartments}");
            Console.WriteLine($"b2 Apartments: {b2.Apartments}");
            Console.WriteLine($"b1 Entrances: {b1.Entrances}");
            Console.WriteLine($"b2 Entrances: {b2.Entrances}");
            Console.WriteLine($"b1 Height: {b1.Height}");
            Console.WriteLine($"b2 Height: {b2.Height}");
            Console.WriteLine($"b1 Levels: {b1.Levels}");
            Console.WriteLine($"b2 Levels: {b2.Levels}");
            Console.WriteLine($"b2 & b1 Numbers are: {b2.Number} & {b1.Number}");
        }
    }
}
