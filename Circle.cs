using System;

namespace Figure_area
{
    //Круг
    public class Circle : Shapes
    {
        public double radius;
        private double square;

        public double Square
        {
            get
            {
                return square;
            }
            private set
            {
                square = value;
            }
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override void CalculateArea()
        {
            if (radius <= 0)
            {
                base.CalculateArea();
            }

            square = Math.PI * (radius * radius);
        }
    }
}
