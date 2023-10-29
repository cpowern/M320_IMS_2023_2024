using Geometrische_Figuren;
using System;

namespace Geometrische_Figuren
{
    public class Triangle : Shape
    {
        private float side1;
        private float side2;
        private float side3;

        //alte isch da kompliziert
        public Triangle(float x = 100.0f, float y = 100.0f, float side1 = 3.0f, float side2 = 4.0f, float side3 = 5.0f) : base(x, y)
        {
            if (IsValidTriangle(side1, side2, side3))
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
            }
            else
            {
                this.side1 = 5.0f;
                this.side2 = 12.0f;
                this.side3 = 13.0f;
            }
        }

        private bool IsValidTriangle(float a, float b, float c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        public override void PrintArea()
        {
            if (IsValidTriangle(side1, side2, side3))
            {
                float s = (side1 + side2 + side3) / 2;
                float area = (float)Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
                Console.WriteLine($"Dreieck Fläche: {area}");
            }
            else
            {
                Console.WriteLine("Ungültige Seitenlängen für ein Dreieck. Fläche kann nicht berechnet werden.");
            }
        }

        public override void Rotate()
        {
            Console.WriteLine("Dreieck dreht sich um 90 Grad im Uhrzeigersinn.");
        }
    }
}
