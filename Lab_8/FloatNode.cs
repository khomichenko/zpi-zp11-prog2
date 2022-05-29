namespace Lab_8
{
    public class FloatNode
    {
        public float Value { get; }
        public FloatNode NextNode { get; set; }

        public FloatNode(float value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

    }
}