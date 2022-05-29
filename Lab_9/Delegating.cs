using System;

namespace Lab_9
{
    public class Delegating
    {
        public delegate int CountSmall(string text);

        public int DoCountSmall(string text)
        {
            var c = 0;
            foreach (var cha in text)
            {
                if (Char.IsLower(cha))
                {
                    c++; 
                }
            } 
            return c;
        }

        public Delegating()
        {
            CountSmall d = this.DoCountSmall;
        }
    }
}