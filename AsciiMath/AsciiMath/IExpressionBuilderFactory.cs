using AsciiMath.Builders;

namespace AsciiMath
{
    public interface IExpressionBuilderFactory
    {
        IExpressionBuilder Create();
    }
}
