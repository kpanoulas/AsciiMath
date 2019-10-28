using System;
using System.Collections.Generic;
using System.Text;

namespace AsciiMath.Builders
{
    internal sealed class GroupBuilderFactory : IGroupBuilderFactory
    {
        public IGroupBuilder Create(IExpressionBuilder parent)
        {
            return new GroupBuilder(parent);
        }
    }
}
