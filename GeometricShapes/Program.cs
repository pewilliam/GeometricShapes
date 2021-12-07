using System;
using GeometricShapes.Entities;
using GeometricShapes.Entities.Enums;
using System.Collections.Generic;
using System.Globalization;

namespace GeometricShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of figures: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.Clear();
                Console.WriteLine("Shape #" + i + " data: ");
                Console.Write("Rectangle or circle (R/C): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black, Blue, Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'R' || ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(color, width, height));
                }

                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circle(radius, color));
                }

                Console.Clear();
                Console.WriteLine("Shape areas:");
                foreach(Shape sh in list)
                {
                    Console.WriteLine(sh.Area().ToString("F2", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
