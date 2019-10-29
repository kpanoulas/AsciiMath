using AsciiMath.Model;

namespace AsciiMath.Builders
{

    public interface IExpressionBuilder : IExpressionItemContainer
    {
        public Expression Build();
        public IChildExpressionBuilder<IExpressionBuilder> AddChild(Function function);
        public IChildExpressionBuilder<IExpressionBuilder> AddChild(Grouping grouping);
        public IChildExpressionBuilder<IExpressionBuilder> AddChild(Accent accent);
        public IChildExpressionBuilder<IExpressionBuilder> AddChild(Color color);
        public IExpressionBuilder AddOperator(Operator @operator);
        public IExpressionBuilder AddArrow(Arrow arrow);
        public IExpressionBuilder AddString(string text);
        public IExpressionBuilder AddString(string text, FontType fontType);
        public IExpressionBuilder AddGreekLetter(GreekLetter greekLetter);
        public IMatrixBuilder<IExpressionBuilder> AddMatrix(int rows, int columns);
    }

    //public interface IExpressionBuilder<TReturn>
    //{
    //    TReturn AddOperator(Operation operationSymbol);

    //    TReturn AddRelation(Relation relationSymbol);

    //    TReturn AddText(string text);

    //    TReturn AddGroupingSymbol(GroupingSymbol groupingSymbol);

    //    IGroupBuilder AddGroup();

    //    TReturn AddGroup(GroupItem groupItem);
    //}
}
