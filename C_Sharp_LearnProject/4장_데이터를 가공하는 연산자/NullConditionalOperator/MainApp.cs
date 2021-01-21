using System;
using System.Collections.Generic;
using System.Text;

namespace NullConditionalOperator
{
    class MainApp
    { // 널 조건부 연산자
        static void Main(string[] args)
        {
            ArrayList a = null;
            a?.Add("야구"); // a?.이 null을 반환하므로 Add() 메소드는 호출되지 않음
            a?.Add("축구");

            Console.WriteLine($"Count : {a?.Count}");
            Console.WriteLine($"{a?[0]}");
            Console.WriteLine($"{a?[1]}");

            a = new ArrayList(); // a는 이제 null이 아님
            a?.Add("야구");
            a?.Add("축구");

            Console.WriteLine($"Count : {a?.Count}");
            Console.WriteLine($"{a?[0]}");
            Console.WriteLine($"{a?[1]}");
        }
    }
}
