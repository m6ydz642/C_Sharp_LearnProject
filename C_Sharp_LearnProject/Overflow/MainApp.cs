using System;
using System.Collections.Generic;
using System.Text;

namespace OverFlow2
{
    class MainApp
    { // 3.4.6 데이터가 넘쳐흘러요
        static void Main(string[] args)
        {
            uint a = uint.MaxValue; // uint의 최대값 저장
            uint b = int.MaxValue; // int의 최대값 저장
            Console.WriteLine(a);
            Console.WriteLine(b);
            a = a + 1;

            Console.WriteLine(a);
            // byte의 최대값은 255이고 2진수로 바꾸면 
            // 1111 1111인데 1을 더하면 1 0000 0000이됨 
            // 그런데 바이트는 8개만 담을 수 있어서 맨 마지막
            // 1을 지워서 0000 0000이 되서 결과는 0임

        }
    }
}
