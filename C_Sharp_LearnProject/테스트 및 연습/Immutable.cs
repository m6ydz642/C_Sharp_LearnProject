using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_LearnProject.테스트_및_연습
{
    class Immutable
    {
        static void Main(string[] args)
        {
            // string 불변 테스트 
            string a = "test";
            Console.WriteLine("해쉬코드 1 string : " + a.GetHashCode());

            string d = a;
            d += "와우";
            Console.WriteLine("해쉬코드 2 string : " + d.GetHashCode());

            int b = 12;
            Console.WriteLine("해쉬코드 3 int : " + b.GetHashCode());
            int c = b;
            c += 123;
 
            Console.WriteLine("해쉬코드 4 int : " + c.GetHashCode());
        }
    }
}
