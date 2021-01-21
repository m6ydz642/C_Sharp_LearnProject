using System;
using System.Collections.Generic;
using System.Text;

namespace SwapByRef
{
    class MainApp
    { // 참조에 의한 매개변수 전달
      static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

   
        static void Main(string[] args)
        {
            int x = 3;
            int y = 5;
            Console.WriteLine($"x:{x}, y:{y}");
            Swap(ref x, ref y);
            Console.WriteLine($"x:{x}, y:{y}"); // 미리 해놓고 호출하기
           

        }
    }
}
