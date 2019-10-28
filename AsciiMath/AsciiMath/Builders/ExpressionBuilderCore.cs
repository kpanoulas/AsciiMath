using AsciiMath.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsciiMath.Builders
{
    internal class ExpressionBuilderCore
    {
        protected readonly List<ExpressionItem> items;
        protected readonly IGroupBuilderFactory groupBuilderFactory;

        public ExpressionBuilderCore(IGroupBuilderFactory groupBuilderFactory)
        {
            items = new List<ExpressionItem>();
            this.groupBuilderFactory = groupBuilderFactory;
        }

        protected void AddGroup(GroupItem groupItem)
        {
            items.Add(groupItem);
        }

    }
}
