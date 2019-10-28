using AsciiMath.Model;

namespace AsciiMath.Builders
{
    public interface IGroupBuilder
    {
        IGroupBuilder AddExpression(Expression expression);
        IExpressionBuilder Build();
    }
}
