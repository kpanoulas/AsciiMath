namespace AsciiMath.Builders
{
    public interface IChildExpressionBuilder<out TIBuilder> : IExpressionItemContainer where TIBuilder : IExpressionItemContainer
    {
        IChildExpressionBuilder<IChildExpressionBuilder<TIBuilder>> AddChild();

        IChildExpressionBuilder<IChildExpressionBuilder<TIBuilder>> AddSuperscript();

        IChildExpressionBuilder<IChildExpressionBuilder<TIBuilder>> AddSubscript();

        TIBuilder CompleteChild();
    }
}
