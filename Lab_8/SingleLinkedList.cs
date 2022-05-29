using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lab_8
{
    public class SingleLinkedList: IEnumerable<float>
    {
        public FloatNode FirstElement { get; private set; }
        
        public int Count { get; private set; }

        public IEnumerator<float> GetEnumerator()
        {
            for (var node = FirstElement; node != null; node = node.NextNode)
            {
                yield return node.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public SingleLinkedList AddElement(float value)
        {
            var n = new FloatNode(value);
            if (FirstElement == null)
            {
                FirstElement = n;
                Count = 1;
            } else
            {
                var x = FirstElement;
                while (x.NextNode!=null)
                {
                    x = x.NextNode;
                }
                x.NextNode = n;
            }

            return this;
        }

        private float GetAverageValue()
        {
            var sum = 0.0f;
            foreach (var x in this)
            {
                sum = sum + x;
            }

            return sum / Count;
        }

        public int GetCountMoreAverage()
        {
            var c = 0;
            var avg = GetAverageValue();
            foreach (var x in this)
            {
                if (x > avg) c++;
            }
            return c;
        }
    }
}