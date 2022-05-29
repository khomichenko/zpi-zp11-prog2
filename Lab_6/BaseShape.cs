namespace Lab_6
{
    public class BaseShape:IShape
    {
        public virtual double CalcArea()
        {
            throw new System.NotImplementedException();
        }

        public virtual double CalcPerimeter()
        {
            throw new System.NotImplementedException();
        }
    }
}