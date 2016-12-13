using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_04_Lambda_
{
    class Program2
    {
        static void Main(string[] args)
        {
            // A simple lambda generates a tree expression
            // Func<int, bool> aLambda = x => (x % 3) == 0; 
            // the previous line is equivalent to:
            Expression<Func<int, bool>> DivBy3 = x => (x % 3) == 0;

            // Lambda defined as an expression tree.
            Expression<Func<int, bool>> xTree = num => num > 3 ;
            // Decomposition of the expression tree.
            ParameterExpression param = (ParameterExpression)xTree.Parameters[0];
            BinaryExpression operation = (BinaryExpression)xTree.Body;
            ParameterExpression left = (ParameterExpression)operation.Left;
            ConstantExpression right = (ConstantExpression)operation.Right;
            // And print the results, just to check.
            Console.WriteLine("Expression: {0} => {1} {2} {3}",
                              param.Name, left.Name, operation.NodeType, right.Value);
            Console.Read();
        }
    }
}
