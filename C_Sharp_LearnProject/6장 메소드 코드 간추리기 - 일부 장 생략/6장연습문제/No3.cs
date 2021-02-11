using System;

namespace Practice
{
    class MainApp
    { // 6장 연습문제 3번, 오버로딩 문제
       public static void Plus(int a, int b, out int c)
        {
            c = a + b;
        }

        public static void Plus(double a, double b, out double c)
        {
            c = a + b;
        }

        static void Main(string[] args)
        {
            int a = 3,  b = 4,  resultA = 0;
            Plus(a, b, out resultA);
            Console.WriteLine("{0} + {1} = {2}", a,b ,resultA);

            double x = 2.4,  y = 3.1, resultB = 0;
            Plus(a, b, out resultB);
            Console.WriteLine("{0} + {1} = {2}", x, y ,resultB);


        }

       

    }
}
