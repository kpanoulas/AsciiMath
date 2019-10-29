namespace AsciiMath.Builders
{
    public interface IMatrixBuilder<TIBuilder>: IExpressionItemContainer where TIBuilder : IExpressionItemContainer
    {
        IChildExpressionBuilder<IMatrixBuilder<TIBuilder>> AddCell(int row, int column);

    }
}
