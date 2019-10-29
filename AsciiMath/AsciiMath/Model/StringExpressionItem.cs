using System;
using System.Collections.Generic;
using System.Text;

namespace AsciiMath.Model
{
    public sealed class StringExpressionItem: ExpressionItem
    {
        public string Text { get; private set; }
        public Color? Color { get; private set; }
        public FontType? FontType { get; private set; }

        public StringExpressionItem(string text, Color color)
            : this(text)
        {
            Color = color;
        }

        public StringExpressionItem(string text, Color color, FontType fontType)
            :this(text, color)
        {
            FontType = fontType;
        }

        public StringExpressionItem(string text)
        {
            Text = text;
        }

    }
}
