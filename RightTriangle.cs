using System;

namespace Figure_area
{

    //Равнобедренный треугольник
    public class RightTriangle : Triangle
    {
        public double side, triangleBase;
        private double square;

        //Говорим о том, что треугольник является равнобедренным
        public override bool isRightTriangle { get { return true; } }

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

        //side - длина стороны, triangleBase - длина основания
        public RightTriangle(double side, double triangleBase)
        {
            this.side = side;
            this.triangleBase = triangleBase;
        }

        public override void CalculateArea()
        {
            if (side <= 0 || triangleBase <= 0 || 2 * side <= triangleBase)
            {
                base.CalculateArea();
            }

            square = triangleBase / 4 * Math.Sqrt(4 * (side * side) - (triangleBase * triangleBase));
        }
    }
}
