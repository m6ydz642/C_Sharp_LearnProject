using System;
using System.Collections.Generic;
using System.Text;

namespace SignedUnsignedConversion
{
    class MainApp
    { //3.1.17 부호 있는 정수 형식과 부호없는 정수 형식 사이의 변환
        static void Main(string[] args)
        {
            int a = 500;
            Console.WriteLine(a);

            uint b = (uint)a;
            Console.WriteLine(b);

            int x = -30;
            Console.WriteLine(x);

            uint y = (uint)x; // 언더 플로우
            Console.WriteLine(y);

        }
    }
}
