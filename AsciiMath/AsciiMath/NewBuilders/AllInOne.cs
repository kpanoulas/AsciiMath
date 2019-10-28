using AsciiMath.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsciiMath.NewBuilders
{

    public interface IExpressionBuilderRoot: IExpressionItemHost
    {
        IExpressionBuilderChild<IExpressionBuilderRoot> AddGroup(GroupingEnclosure groupingEnclosure);

        IExpressionBuilderChild<IExpressionBuilderRoot> AddFunction(Function function);


        Expression Build();
    }

    public interface IExpressionBuilderChild<TIParent>  : IExpressionItemHost where TIParent: IExpressionItemHost
    {


        TIParent CompleteBuild();
    }

    public interface IExpressionItemHost
    {
        void AddExpressionItem(ExpressionItem expressionItem);
    }

    public interface IGroupBuilder: IExpressionItemHost
    {



    }


}
