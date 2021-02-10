using System;
using System.Collections.Generic;
using System.Text;

namespace FloatToIntegral
{
    class MainApp
    { //3.1.18 부동 소수점 형식과 정수 형식 사이의 변환
        static void Main(string[] args)
        {
            float a = 0.9f;
            int b = (int)a;
            Console.WriteLine(b);

            float c = 1.1f;
            int d = (int)c;
            Console.WriteLine(d);

        }
    }
}
