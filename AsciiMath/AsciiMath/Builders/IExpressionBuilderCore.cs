using AsciiMath.Model;

namespace AsciiMath.Builders
{



    public interface IExpressionBuilderCore<TReturn>
    {
        TReturn AddOperator(Operation operationSymbol);

        TReturn AddRelation(Relation relationSymbol);

        TReturn AddText(string text);

        TReturn AddGroupingSymbol(GroupingSymbol groupingSymbol);

        IGroupBuilder AddGroup();

        TReturn AddGroup(GroupItem groupItem);
    }
}
