using System;

namespace Figure_area
{
    //Равносторонний треугольник
    public class EquilateralTriangle : Triangle
    {
        public double side;
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

        //side - сторона
        public EquilateralTriangle(double side)
        {
            this.side = side;
        }

        public override void CalculateArea()
        {
            if (side <= 0)
            {
                base.CalculateArea();
            }

            square = Math.Sqrt(3) / 4 * (side * side);
        }
    }
}
