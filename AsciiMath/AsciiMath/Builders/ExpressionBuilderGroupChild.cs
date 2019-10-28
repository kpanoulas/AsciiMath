using System;
using System.Collections.Generic;
using System.Text;
using AsciiMath.Model;

namespace AsciiMath.Builders
{


    public interface IExpressionBuilderGroupChild : IExpressionBuilderCore<IExpressionBuilderGroupChild>
    {
        IExpressionBuilder Build();
    }

    internal sealed class ExpressionBuilderGroupChild : ExpressionBuilderCore, IExpressionBuilderGroupChild
    {
        public ExpressionBuilderGroupChild(IGroupBuilderFactory groupBuilderFactory)
            : base(groupBuilderFactory)
        {
        }

        public IGroupBuilder AddGroup()
        {
            groupBuilderFactory.Create()
        }

        public IExpressionBuilderGroupChild AddGroupingSymbol(GroupingSymbol groupingSymbol)
        {
            throw new NotImplementedException();
        }

        public IExpressionBuilderGroupChild AddOperator(Operation operationSymbol)
        {
            throw new NotImplementedException();
        }

        public IExpressionBuilderGroupChild AddRelation(Relation relationSymbol)
        {
            throw new NotImplementedException();
        }

        public IExpressionBuilderGroupChild AddText(string text)
        {
            throw new NotImplementedException();
        }

        public IExpressionBuilder Build()
        {
            throw new NotImplementedException();
        }

        IExpressionBuilderGroupChild IExpressionBuilderCore<IExpressionBuilderGroupChild>.AddGroup(GroupItem groupItem)
        {
            throw new NotImplementedException();
        }
    }
}
