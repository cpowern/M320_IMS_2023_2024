using System;

namespace Geometrische_Figuren
{
    public class Circle : Shape
    {
        private float radius;

        public Circle(float x = 100.0f, float y = 100.0f, float radius = 1.0f) : base(x, y)
        {
            this.radius = (radius >= 0) ? radius : 1.0f;
        }

        public override void PrintPosition()
        {
            Console.WriteLine($"Zentrale Position: ({x}, {y})");
        }

        public override void PrintArea()
        {
            float area = (float)Math.PI * radius * radius;
            Console.WriteLine($"Kreis Flaeche: {area}");
        }

        public override void Rotate()
        {
            Console.WriteLine("Kreise können nicht gedreht werden.");
        }
    }
}
