using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    delegate int MyDelegate(int a, int b); // 대리자 선언

    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;

        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {

            Calculator Calc = new Calculator();
            MyDelegate Callback;

            Callback = new MyDelegate(Calc.Plus);
            Console.WriteLine(Callback(3, 4)); // 대리자가 참조하고 있는 메소드 실행

        }
    }


}
