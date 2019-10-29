using System;
using System.Collections.Generic;
using AsciiMath.Model;

namespace AsciiMath.Builders
{

    public sealed class ExpressionBuilder : IExpressionBuilder
    {

        private List<ExpressionItem> items;
        internal ExpressionBuilder()
        {
            items = new List<ExpressionItem>();
        }

        public IChildExpressionBuilder<IExpressionBuilder> AddChild(Function function)
        {
            throw new NotImplementedException();
        }

        public IChildExpressionBuilder<IExpressionBuilder> AddChild(Grouping grouping)
        {
            throw new NotImplementedException();
        }


        void IExpressionItemContainer.AddExpressionItem(ExpressionItem expressionItem)
        {
            items.Add(expressionItem);
        }

        public Expression Build()
        {
            return new Expression(items.ToArray());
        }

        public IChildExpressionBuilder<IExpressionBuilder> AddChild(Accent accent)
        {
            throw new NotImplementedException();
        }

        public IChildExpressionBuilder<IExpressionBuilder> AddChild(Color color)
        {
            throw new NotImplementedException();
        }

        public IExpressionBuilder AddOperator(Operator @operator)
        {
            throw new NotImplementedException();
        }

        public IExpressionBuilder AddArrow(Arrow arrow)
        {
            items.Add(new ArrowExpressionItem(arrow));
            return this;
        }

        public IExpressionBuilder AddString(string text)
        {
            items.Add(new StringExpressionItem(text));
            return this;
        }

        public IExpressionBuilder AddString(string text, FontType fontType)
        {
            items.Add(new StringWithColorExpressionItem(text, Color))
        }

        public IExpressionBuilder AddGreekLetter(GreekLetter greekLetter)
        {
            throw new NotImplementedException();
        }
    }



    ////internal sealed class ExpressionBuilder : ExpressionBuilderCore, IExpressionBuilder
    ////{
    ////    //private List<ExpressionItem> items;
    ////    //private readonly IGroupBuilderFactory groupBuilderFactory;


    ////    internal ExpressionBuilder(IGroupBuilderFactory groupBuilderFactory)
    ////        : base(groupBuilderFactory)
    ////    {
    ////        //this.groupBuilderFactory = groupBuilderFactory;
    ////        //items = new List<ExpressionItem>();
    ////    }

    ////    public IExpressionBuilder AddGroupingSymbol(GroupingSymbol groupingSymbol)
    ////    {

    ////        items.Add(new GroupingSymbolItem(groupingSymbol));
    ////        return this;
    ////    }

    ////    public new IExpressionBuilder AddGroup(GroupItem groupItem)
    ////    {
    ////        base.AddGroup(groupItem);
    ////        return this;
    ////    }

    ////    public IGroupBuilder AddGroup(Grouping groupingEnclosure)
    ////    {
    ////        return groupBuilderFactory.Create(this);
    ////    }

    ////    public IExpressionBuilder AddOperator(Operation operationSymbol)
    ////    {
    ////        throw new NotImplementedException();
    ////    }

    ////    public IExpressionBuilder AddRelation(Relation relationSymbol)
    ////    {
    ////        throw new NotImplementedException();
    ////    }

    ////    public IExpressionBuilder AddText(string text)
    ////    {
    ////        throw new NotImplementedException();
    ////    }

    ////    public Expression Build()
    ////    {
    ////        throw new NotImplementedException();
    ////    }

    ////    public sealed class ExpressionBuilder : IExpressionBuilder
    ////    {
    ////        public IChildExpressionBuilder<IExpressionBuilder> AddChild()
    ////        {
    ////            throw new NotImplementedException();
    ////        }

    ////        void IExpressionItemContainer.AddExpressionItem(ExpressionItem expressionItem)
    ////        {
    ////            throw new NotImplementedException();
    ////        }

    ////        public Expression Build()
    ////        {
    ////            throw new NotImplementedException();
    ////        }
    ////    }
    ////}
}
