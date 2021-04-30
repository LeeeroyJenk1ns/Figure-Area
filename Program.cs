using System;

namespace Figure_area
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle circle = new Circle(3);

            circle.CalculateArea();

            Console.WriteLine(circle.Square);

            RightTriangle triangle = new RightTriangle(8, 15);

            triangle.CalculateArea();

            Console.WriteLine(triangle.Square);

            Console.WriteLine(triangle.isRightTriangle);

            EquilateralTriangle triangle2 = new EquilateralTriangle(6);

            triangle2.CalculateArea();

            Console.WriteLine(triangle2.Square);

            Console.WriteLine(triangle2.isRightTriangle);

            VersatileTriangle triangle3 = new VersatileTriangle(3, 5, 7);

            triangle3.CalculateArea();

            Console.WriteLine(triangle3.Square);

            Console.WriteLine(triangle3.isRightTriangle);
        }
    }
}
