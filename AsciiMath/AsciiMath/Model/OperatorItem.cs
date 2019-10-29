namespace AsciiMath.Model
{
    public sealed class OperatorItem : ExpressionItem
    {
        internal OperatorItem(Operator @operator)
        {
            Operator = @operator;
        }

        public Operator Operator { get; }
    }
}
