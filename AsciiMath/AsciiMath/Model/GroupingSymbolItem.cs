using System;
using System.Collections.Generic;
using System.Text;

namespace AsciiMath.Model
{
    public sealed class GroupingSymbolItem: ExpressionItem
    {
        public GroupingSymbol GroupingSymbol { get; }

        internal GroupingSymbolItem(GroupingSymbol groupingSymbol)
        {
            GroupingSymbol = groupingSymbol;
        }
    }
}
