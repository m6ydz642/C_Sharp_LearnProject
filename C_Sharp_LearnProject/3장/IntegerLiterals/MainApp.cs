using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_LearnProject.IntegerLiterals
{
    class MainApp
    {
        // 3,4,4 2진수 10진수, 16진수 리터럴
        static void Main(string[] args)
        {
            byte a = 240;
            Console.WriteLine($"a={a}");

            byte b = 0b1111_0000; // 2진수 리터럴
            Console.WriteLine($"b={b}");

            byte c = 0XF0; // 16진수 리터럴
            Console.WriteLine($"c={c}");

            uint d = 0x1234_abcd; // 16진수 리터럴
            Console.WriteLine($"d={d}");

        }
    }
}
