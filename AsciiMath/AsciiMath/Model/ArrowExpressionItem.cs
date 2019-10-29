using System;
using System.Collections.Generic;
using System.Text;

namespace AsciiMath.Model
{
    public sealed class ArrowExpressionItem : ExpressionItem
    {

        public Arrow Arrow { get; private set; }

        public ArrowExpressionItem(Arrow arrow)
        {
            Arrow = Arrow;
        }

    }
}
