namespace Lab_6
{
    public class Square: BaseShape
    {
        private double _a;
        private double _b;

        public Square(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public override double CalcArea()
        {
            return _a*_b;
        }

        public override double CalcPerimeter()
        {
            return 2*_a+2*_b;
        }
    }
}