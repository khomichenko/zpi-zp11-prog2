using System;

namespace Lab_7
{
    public class Expression
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        private double Calc()
        {
            try
            {
                return (Math.Log(A * B + 2) * C) / (41 - B / C + 1);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
            return 0;
        }
        
        public override string ToString()
        {
            return $"(ln(a*b+2)*c)/(41-b/c+1) (a={A},b={B},c={C}) => {Calc()}";
        }
    }
}