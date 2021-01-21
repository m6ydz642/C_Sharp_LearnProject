using System;
using System.Collections.Generic;
using System.Text;

namespace NullOperator
{
    class MainApp
    { // null 연산자
        static void Main(string[] args)
        {
            int? a = null;
            Console.WriteLine($"{a ?? 0}"); // 왼쪽이 null이 아ㅏ니면 왼쪽그대로 반환
                                            // 왼쪽 연산자가 null이면 오른쪽 반환

            // Console.WriteLine("Total : {0, -7, D}", 123);
        }
    }
}
