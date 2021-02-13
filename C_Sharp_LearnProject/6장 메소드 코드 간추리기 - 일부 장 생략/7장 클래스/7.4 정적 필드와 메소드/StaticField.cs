using System;
using System.Collections.Generic;
using System.Text;

namespace StaticField
{
  class Global
    {
        public static int Count = 0;
    }

    class ClassA
    {
        public ClassA()
        {
            Global.Count++;
        }
    }

    class ClassB
    {
        public ClassB()
        {
            Global.Count++;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Global.Count : {Global.Count}");
            // 기본 값은 0인데 기본생성자나 다른 함수에 의해 영향을 받지 않았으므로 
            // 설정해놓은 초기값이 나옴

            new ClassA();// 기본생성자에 값이 할당되어 있어서 만들때 Global.Count++를 호출함
            new ClassA();
            new ClassB(); 
            new ClassB();

            // 4번 호출했으니 4가 나올듯
            Console.WriteLine($"Global.Count : {Global.Count}");


        }
    }

    
}
