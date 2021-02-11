using System;
using System.Collections.Generic;
using System.Text;

namespace UsingOut
{
    class MainApp
    { // 출력전용 매개변수
      static int Plus(int a, int b)
        {
            Console.WriteLine("Calling int Plus(int, int)");
            return a + b;
        }

        static int Plus(int a, int b, int c)
        {
            Console.WriteLine("Calling int Plus(int, int, int)");
            return a + b + c;
        }

        static double Plus(double a, double b)
        {
            Console.WriteLine("Calling int Plus(따블)");
            return a + b;
        }



        static void Main(string[] args)
        {
            int a = 20;
            int b = 3;
            // int c;
            // int d;

            Console.WriteLine(Plus(1, 2));
            Console.WriteLine(Plus(1, 2, 3));
            Console.WriteLine(Plus(1.0, 2.4));

        }
    }
}
