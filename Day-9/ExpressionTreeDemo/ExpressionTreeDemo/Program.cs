using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System;

namespace ExpressionTreeDemo
{
    class Program
    {
        static void Main()
        {
            //ExpressionVisitor
            //Func<int, bool> lambdaExpression = num => num % 2 == 0;
            ParameterExpression numExpression = Expression.Parameter(typeof(int), "num");
            ConstantExpression twoExpression = Expression.Constant(2, typeof(int));

            BinaryExpression moduloExpression = Expression.Modulo(numExpression, twoExpression);

            ConstantExpression zeroExpression = Expression.Constant(0, typeof(int));
            BinaryExpression equalExpression = Expression.Equal(moduloExpression, zeroExpression);

            Expression<Func<int, bool>> lambdaExpression =
                Expression.Lambda<Func<int, bool>>(equalExpression, "evenExpression", new[] { numExpression });

            WriteLine(lambdaExpression);
            WriteLine("{0} {1}={2}=>{3}",
                lambdaExpression.Type,
                lambdaExpression.Name,
                lambdaExpression.Parameters[0].Name,
                lambdaExpression.Body);

            Func<int, bool> delVar = lambdaExpression.Compile();

            WriteLine("Is 5 even? {0}", delVar.Invoke(5));
            List<int> intList = new List<int> { 1, 2, 3, 4, 5 };

            intList.ForEach(item => Console.WriteLine($"item:{item}= {delVar(item)}"));
            //foreach (var item in intList)
            //{
            //    Console.WriteLine($"item:{item}= {delVar(item)}");
            //}

            /*
            //Console.WriteLine("{0} {1}={2}=>{3}",lambdaExpression.Type, lambdaExpression.Name, lambdaExpression.Parameters[0].Name, lambdaExpression.Body);
            Console.WriteLine("{0} {1}={2}", lambdaExpression.Type, lambdaExpression.Name, lambdaExpression.ToString());

            Func<int, bool> compiledExpression = lambdaExpression.Compile();
            //Console.WriteLine("Is 5 even? {0}", compiledExpression.Invoke(5));

            List<int> intList = new List<int> { 1, 2, 3, 4, 5 };
            Action<int> evaluate = item => Console.WriteLine("Is {0} True/False? {1}", item, compiledExpression.Invoke(item));
            Action action = () => intList.ForEach(evaluate);


            ParameterExpression aParameter = Expression.Parameter(typeof(int), "a");
            ParameterExpression bParameter = Expression.Parameter(typeof(int), "b");
            //ParameterExpression resultVariable = Expression.Variable(typeof(int), "result");
            BinaryExpression addExpression = Expression.Add(aParameter, bParameter);
            //BinaryExpression assignResultExpression = Expression.Assign(resultVariable, addExpression);
            //LabelTarget labelTarget = Expression.Label(typeof(int), "resultVariable");
            //LabelExpression returnExpression = Expression.Label(labelTarget,Expression.Default(typeof(int)));
            //GotoExpression returnExpression = Expression.Return();


            //BlockExpression methodBlock = Expression.Block(addExpression, assignResultExpression);
            //methodBlock.Expressions.ToList<Expression>().ForEach(e => Console.WriteLine(e));
            Expression expression = Expression.Lambda<Func<int, int, int>>(addExpression, "addExpression", new[] { aParameter, bParameter });
            Console.WriteLine(expression.ToString());
            */
        }
    }
}
