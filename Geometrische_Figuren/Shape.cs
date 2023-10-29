using System;

namespace Geometrische_Figuren
{
    public abstract class Shape
    {
        protected float x;
        protected float y;

        public Shape(float x = 100.0f, float y = 100.0f)
        {
            if (x >= 0 && y >= 0)
            {
                this.x = x;
                this.y = y;
            }
            else
            {
                this.x = 100.0f;
                this.y = 100.0f;
            }
        }

        public virtual void PrintPosition()
        {
            Console.WriteLine($"Position 1: ({x}, {y})");
        }

        public abstract void PrintArea();

        public abstract void Rotate();
    }
}
