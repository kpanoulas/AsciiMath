namespace AsciiMath.Builders
{
    public interface IGroupBuilderFactory
    {
        IGroupBuilder Create(IExpressionBuilder parent);
    }
}
