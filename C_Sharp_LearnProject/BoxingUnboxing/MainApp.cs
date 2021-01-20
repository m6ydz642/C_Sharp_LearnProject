using System;
using System.Collections.Generic;
using System.Text;

namespace BoxingUnboxing
{
    class MainApp
    { //3.1.13 박싱과 언박싱
        static void Main(string[] args)
        {
            int a = 123;
            object b = (object)a; // a의 담긴 값을 박싱해서 힙에 저장
            int c = (int)b; // b에 담긴 값을 언박싱해서 스택에 저장
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            double x = 3.1414213;
            object y = x;
            double z = (double)y;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
