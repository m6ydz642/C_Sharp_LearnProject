using System;
using System.Collections.Generic;
using System.Text;

namespace FloatConversion
{
    class MainApp
    { //3.1.16 // 크기가 서로 다른 정수 형식 사이의 변환 (3.4.15랑 제목 같음)
        static void Main(string[] args)
        {
            float a = 69.6875f;
            Console.WriteLine($"a: {a}", a);
            // WriteLine안에 출력시 {0}써도 되고 $해서 {변수} 써도 됨 

            double b = (double)a;
            Console.WriteLine("b : {0}", b);

            Console.WriteLine("69.6875 == b : {0}", 69.6875 == b);

            float x = 0.1f;
            Console.WriteLine("x : {0}", x);

            double y = (double)x;
            Console.WriteLine("y : {0}", y);

            Console.WriteLine("0.1 == y {0}", 0.1 == y);

        }
    }
}
