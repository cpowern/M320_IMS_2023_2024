using Geometrische_Figuren;
using System;

namespace Geometrische_Figuren
{
    public class Rectangle : Shape
    {
        protected float width;
        protected float height;

        public Rectangle(float x = 100.0f, float y = 100.0f, float width = 1.0f, float height = 1.0f) : base(x, y)
        {
            this.width = (width >= 0) ? width : 1.0f;
            this.height = (height >= 0) ? height : 1.0f;
        }

        public override void PrintPosition()
        {
            Console.WriteLine($"Oben Rechts Position: ({x}, {y})");
            Console.WriteLine($"Unten Rechts Position: ({x + width}, {y + height})");
        }

        public override void PrintArea()
        {
            float area = width * height;
            Console.WriteLine($"Rechteck Fleache: {area}");
        }

        public override void Rotate()
        {
            Console.WriteLine("Rechteck dreht sich um 90 Grad im Uhrzeigersinn.");
        }
    }
}
