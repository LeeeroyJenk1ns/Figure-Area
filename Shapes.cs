using System;

namespace Figure_area
{
    public class Shapes
    {
        public virtual void CalculateArea()
        {
            throw new Exception("Не удалось вычислить площадь фигуры");
        }
    }
}
