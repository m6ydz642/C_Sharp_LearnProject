using System;
using System.Collections.Generic;
using System.Text;

namespace NullCoalescing
{
    class MainApp
    { // null 병합 연산자
        static void Main(string[] args)
        {
            int? num = null;
            Console.WriteLine($"{num ?? 0}"); // 왼쪽이 널이므로 오른쪽 연산자 반환

            num = 99;
            Console.WriteLine($"{num ?? 0}"); // 왼쪽이 널이 아니므로 오른쪽 연산자 반환
        }
    }
}
