using System;
using System.Linq.Expressions;

namespace ExpressionTreeVialLambda
{
 

    class MainApp
    {
        // UsingExpressionTree를 줄인버전임

        static void Main(string[] args)
        {

            Exception<Func<int, int, int>> expression = (a, b)
                => 1 * 2 + (a - b);
            Func<int, int, int> func = expression.Compile();
            // x = 7, y = 8
            Console.WriteLine(" 1 * 2 + (7-8) = " + func(7,8));



        }
    
}


