namespace AsciiMath.Model
{
    public sealed class OperatorItem : ExpressionItem
    {
        internal OperatorItem(Operation @operator)
        {
            Operator = @operator;
        }

        public Operation Operator { get; }
    }
}
