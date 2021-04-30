using System;

namespace Figure_area
{
    //Разносторонний треугольник
    public class VersatileTriangle : Triangle
    {
        public double a, b, c;
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

        //a, b, c - стороны
        public VersatileTriangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override void CalculateArea()
        {
            if (a <= 0 || b <= 0 || c <= 0 || a == b || a == c || c == b || !((a <= b + c) && (b <= a + c) && (c <= a + b)))
            {
                base.CalculateArea();
            }

            //Вычисляем полупериметр
            double p = (a + b + c) / 2;

            square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            
        }
    }
}
