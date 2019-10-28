using System;
using AsciiMath.Builders;

namespace AsciiMath
{
    public class ExpressionBuilderFactory : IExpressionBuilderFactory
    {
        private readonly IGroupBuilderFactory groupBuilderFactory;


        public IExpressionBuilder Create()
        {
            return new ExpressionBuilder(groupBuilderFactory)
        }
    }
}
