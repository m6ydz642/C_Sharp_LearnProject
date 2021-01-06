using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_LearnProject.Overflow
{
    class MainApp
    { //3.1.15 // 크기가 서로 다른 정수 형식 사이의 변환
        static void Main(string[] args)
        {
            sbyte a = 127;
            Console.WriteLine(a);

            int b = (int)a;
            Console.WriteLine(b);

            int x = 128; // sbyte의 최대값 127보다 1큰 수
            Console.WriteLine(x);

            sbyte y = (sbyte)x;
            Console.WriteLine(y);

        }
    }
}
