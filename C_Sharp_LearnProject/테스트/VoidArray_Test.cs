using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
  
    class MainApp
    { // 대리자 사용하다가 배열은 주소 방식 헷깔려서 테스트 하러옴

        static void testvalue(int[] a)
        {

            a[0] = 1234;

        }

        static void Main(string[] args)
        {
            int[] a = { 10 };
            Console.WriteLine("a = " + a[0]);
            testvalue(a); 
            Console.WriteLine("변경후  a값 " + a[0]); // 주소 달라서 바뀜
        }
    }
}
