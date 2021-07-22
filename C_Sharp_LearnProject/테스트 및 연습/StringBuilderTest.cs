using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_LearnProject.테스트_및_연습
{
    class StringBuilderTest
    {
        static void Main(string[] args)
        {
            // string을 사용하지 않고 Builder를 사용

            StringBuilder sb = new StringBuilder();

            sb.Append("와우 \r\n");
            sb.Append("리스트같네 \r\n");
            sb.Append("테스트 \r\n").ToString().Trim();
            sb.Append("테스트2");
            Console.WriteLine(sb);

 
            string str1 = string.Format("Example2 : {0}, {1}", "BlockDMask", 3434);
            Console.WriteLine("test : " + str1); // string  format 으로 출력





        }
    }
}
