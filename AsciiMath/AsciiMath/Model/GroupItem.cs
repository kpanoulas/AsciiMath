using System;
using System.Collections.Generic;
using System.Text;

namespace AsciiMath.Model
{
    public sealed class GroupItem: ExpressionItem
    {
        internal GroupItem(Expression expression, Grouping groupingEnclosure)
        {
            Expression = expression;
            GroupingEnclosure = groupingEnclosure;
        }

        public Expression Expression { get; }
        public Grouping GroupingEnclosure { get; }
    }
}
