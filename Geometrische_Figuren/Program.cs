using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrische_Figuren
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = {
                new Circle(50, 50, 30),
                new Rectangle(200, 200, 100, 50),
                new Triangle(50, 50, 30)
            };

            foreach (Shape shape in shapes)
            {
                shape.PrintPosition();
                shape.PrintArea();

                shape.Rotate();
                Console.WriteLine();
            }
        }
    }
}
