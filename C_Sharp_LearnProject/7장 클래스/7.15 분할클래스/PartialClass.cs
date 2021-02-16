using System;

namespace ParticalClass
{
   partial class MyClass // 분할클래스는
        // Partical키우ᅥ드가 붇는다.
    {
        public void Method1()
        {
            Console.WriteLine("메소드1");
        }

        public void Method2()
        {
            Console.WriteLine("메소드2");
        }

    }


    partial class MyClass // 분할클래스는
                          // Partical키우ᅥ드가 붇는다.
    {
        public void Method3()
        {
            Console.WriteLine("메소드3");
        }

        public void Method4()
        {
            Console.WriteLine("메소드4");
        }

    }


    class MainApp
    {
        static void Main(string[] args)
        {

            MyClass obj = new MyClass();
            obj.Method1();
            obj.Method2();
            obj.Method3();
            obj.Method4();


        }
    }


}
