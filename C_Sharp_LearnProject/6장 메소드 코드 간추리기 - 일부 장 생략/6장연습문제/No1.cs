using System;

namespace Practice
{
    class MainApp
    { // 6장 연습문제 1번

        static double Square(double arg)
        {
            return arg * arg;
        }
        static void Main(string[] args)
        {
            Console.Write("수를 입력하세요 : ");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);

            Console.WriteLine("결과 : {0} ", Square(arg));
        }

    }
}
