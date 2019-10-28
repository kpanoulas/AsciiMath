using System;
using System.Collections.Generic;
using AsciiMath.Model;

namespace AsciiMath.Builders
{
    public interface IExpressionBuilder : IExpressionBuilderCore<IExpressionBuilder>
    {
        Expression Build();
    }

    internal sealed class ExpressionBuilder : ExpressionBuilderCore, IExpressionBuilder
    {
        //private List<ExpressionItem> items;
        //private readonly IGroupBuilderFactory groupBuilderFactory;


        internal ExpressionBuilder(IGroupBuilderFactory groupBuilderFactory)
            : base(groupBuilderFactory)
        {
            //this.groupBuilderFactory = groupBuilderFactory;
            //items = new List<ExpressionItem>();
        }

        public IExpressionBuilder AddGroupingSymbol(GroupingSymbol groupingSymbol)
        {

            items.Add(new GroupingSymbolItem(groupingSymbol));
            return this;
        }

        public new IExpressionBuilder AddGroup(GroupItem groupItem)
        {
            base.AddGroup(groupItem);
            return this;
        }

        public IGroupBuilder AddGroup(GroupingEnclosure groupingEnclosure)
        {
            return groupBuilderFactory.Create(this);
        }

        public IExpressionBuilder AddOperator(Operation operationSymbol)
        {
            throw new NotImplementedException();
        }

        public IExpressionBuilder AddRelation(Relation relationSymbol)
        {
            throw new NotImplementedException();
        }

        public IExpressionBuilder AddText(string text)
        {
            throw new NotImplementedException();
        }

        public Expression Build()
        {
            throw new NotImplementedException();
        }


    }
}
