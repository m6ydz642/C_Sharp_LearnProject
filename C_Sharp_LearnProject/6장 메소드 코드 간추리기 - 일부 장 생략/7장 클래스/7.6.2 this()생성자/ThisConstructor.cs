using System;
using System.Collections.Generic;
using System.Text;

namespace ThisConstructor
{
    class MyClass
    {
        int a, b, c;
        public MyClass()
        {
            this.a = 5425;
            Console.WriteLine("MyClass()");
        }

        public MyClass(int b) : this()
        {
            this.b = b;
            Console.WriteLine($"MyClass{b}");
        }

        public MyClass(int b, int c) : this(b)
        {
            this.c = c;
            Console.WriteLine($"MyClass({b}, {c}");
        }

        public void PrintFields()
        {
            Console.WriteLine($"{a}, b:{b}, c:{c}");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass(); // a값만 초기화
            a.PrintFields();// a값만 초기화해서 출력
            Console.WriteLine();

            MyClass b = new MyClass(1); // b값을 1로 초기화 하면서 this로 기본생성자로 호출
            b.PrintFields();
            Console.WriteLine();

            MyClass c = new MyClass(10,20); // 인자 2개짜리 생성자 호출하면서 
            // b포함 호출하고 b는 a가 들어가있는 기본생성자도 호출
            c.PrintFields();
            Console.WriteLine();

        }
    }

    
}
