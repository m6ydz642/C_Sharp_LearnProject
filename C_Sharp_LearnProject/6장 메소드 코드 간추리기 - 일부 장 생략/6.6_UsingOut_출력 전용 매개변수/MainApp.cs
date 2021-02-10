using System;
using System.Collections.Generic;
using System.Text;

namespace UsingOut
{
    class MainApp
    { // 출력전용 매개변수
      static void Divide(int a, int b, out int quotient, out int reainder)
        {
            quotient = a / b;
            reainder = a % b;
        }

   
        static void Main(string[] args)
        {
            int a = 20;
            int b = 3;
            // int c;
            // int d;

            Divide(a, b, out int c, out int d);

            Console.WriteLine($"a = {a}, b = {b}, a/b = {c}, a % b = {d}");       

        }
    }
}
