namespace AsciiMath.Model
{
    public sealed class Expression
    {
        private readonly ExpressionItem[] items;
 
        internal Expression(ExpressionItem[] items)
        {
            this.items = items;
        }
    }
}
