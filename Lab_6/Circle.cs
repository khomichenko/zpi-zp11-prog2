using System;

namespace Lab_6
{
    public class Circle: BaseShape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double CalcArea()
        {
            return _radius*_radius*Math.PI;
        }

        public override double CalcPerimeter()
        {
            return 2*_radius*Math.PI;
        }
    }
}