using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_LearnProject.SignedUnsigned
{
    class MainApp
    { // 3.4.5 부호 있는 정수와 부호 없는 정수
        static void Main(string[] args)
        {
            byte a = 255;
            sbyte b = (sbyte)a;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
