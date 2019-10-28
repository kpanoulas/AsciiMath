using System;
using System.Collections.Generic;
using System.Text;
using AsciiMath.Model;

namespace AsciiMath.Builders
{
    internal sealed class GroupBuilder: IGroupBuilder
    {
        private readonly IExpressionBuilderFactory expressionBuilderFactory;
        private readonly GroupingEnclosure groupingEnclosure;
        private readonly IExpressionBuilder parent;
        public Expression Expression { get; private set; }


        public GroupBuilder(IExpressionBuilderFactory expressionBuilderFactory, IExpressionBuilder parent, GroupingEnclosure groupingEnclosure)
        {

            this.expressionBuilderFactory = expressionBuilderFactory;
            this.parent = parent;
            this.groupingEnclosure = groupingEnclosure;
        }

        public IGroupBuilder AddExpression(Expression expression)
        {
            if(Expression is null)
            {
                throw new InvalidOperationException($"Field '{nameof(Expression)} has been already set.");
            }
            Expression = expression;
            return this;
        }

        public   AddExpression()
        {
            return expressionBuilderFactory.Create()
        }


        public IExpressionBuilder Build()
        {
            parent.AddGroup(new GroupItem(Expression, groupingEnclosure));
            return parent;
        }
    }
}
