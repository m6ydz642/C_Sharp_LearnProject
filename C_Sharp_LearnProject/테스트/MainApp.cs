using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class MyClass
    {
        public int MyField1 = 10;
        public int MyField2 = 20;
    }
    class MainApp
    { // 얕은 복사 깊은 복사 테스트
        // MyField2이외에 

        // MyField1도 같이 바뀌나 테스트 
        static void Main(string[] args)
        {
            MyClass source = new MyClass();
            source.MyField1 = 10;
            source.MyField2 = 20;

            MyClass target = source; // target도 source를 가르킴
            target.MyField1 = 30;
            target.MyField2 = 40;

            Console.WriteLine("{0} {1} ", source.MyField1, source.MyField2);
            Console.WriteLine("{0} {1} ", target.MyField1, target.MyField2);

        }
    }
}
