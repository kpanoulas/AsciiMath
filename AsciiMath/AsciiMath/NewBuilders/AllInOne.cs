using AsciiMath.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsciiMath.NewBuilders
{

    public interface IExpressionBuilder: IExpressionItemContainer
    {
        public Expression Build();
        public IChildExpressionBuilder<IExpressionBuilder> AddChild();
    }

    public interface IChildExpressionBuilder<out TIBuilder>: IExpressionItemContainer where TIBuilder: IExpressionItemContainer
    {
        IChildExpressionBuilder<IChildExpressionBuilder<TIBuilder>> AddChild();

        TIBuilder CompleteChild();
    }

    public interface IExpressionItemContainer
    {
        internal void AddExpressionItem(ExpressionItem expressionItem);
    }

    public sealed class ExpressionBuilder: IExpressionBuilder
    {
        public IChildExpressionBuilder<IExpressionBuilder> AddChild()
        {
            throw new NotImplementedException();
        }

        void IExpressionItemContainer.AddExpressionItem(ExpressionItem expressionItem)
        {
            throw new NotImplementedException();
        }

        public Expression Build()
        {
            throw new NotImplementedException();
        }
    }




    public sealed class ChildExpressionBuilder<TIExpressionBuilder> : IChildExpressionBuilder<TIExpressionBuilder> where TIExpressionBuilder : IExpressionItemContainer
    {
        private readonly TIExpressionBuilder parent;

        public ChildExpressionBuilder(TIExpressionBuilder parent)
        {
            this.parent = parent;
        }

        public IChildExpressionBuilder<IChildExpressionBuilder<TIExpressionBuilder>> AddChild()
        {
            throw new NotImplementedException();
        }

        void IExpressionItemContainer.AddExpressionItem(ExpressionItem expressionItem)
        {
            throw new NotImplementedException();
        }

        public TIExpressionBuilder CompleteChild()
        {
            throw new NotImplementedException();
        }
    }



    public static class Tester
    {


        public static void Test()
        {

            var eb = new ExpressionBuilder();

            eb.AddChild() 
                .CompleteChild()
              .Build();

 


        }





    }





}
