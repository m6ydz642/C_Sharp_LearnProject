using System;
using System.Collections.Generic;
using System.Text;

namespace UsingVar
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 3.7 데이터 형식을 알아서 파악하는 똑똑한 C# 컴파일러
            var a = 20;
            Console.WriteLine("type : {0}, Value : {1}", a.GetType(), a);

            var b = 3.1414213;
            Console.WriteLine("type : {0}, Value : {1}", b.GetType(), b);

            var c = "Hello, World";
            Console.WriteLine("type : {0}, Value : {1}", c.GetType(), c);

            var d = new int[] { 10, 20, 30 };
            Console.Write("type : {0} Value : ", d.GetType()); // 나머지는 for문으로 배열 출력할꺼라 인자 삭제
                foreach (var e in d)
                     Console.Write("{0} ", e);

            Console.WriteLine(); // 줄바꿈
        }
    }
}
