using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier
{
    class Base
    {
        protected string Name;
        public Base(string Name)
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name}.Base() ");
        }

        ~Base()
        {
            Console.WriteLine($"{this.Name}.~Base소멸");
        }

        public void BaseMethod()
        {
            Console.WriteLine($"{Name}.BaseMethod()호출 ");
        }

        
    }


    class Derived : Base
    {
        public Derived(string Name) : base(Name) // Base 클래스의 Name호출
                                                 // : base는 부모클래스 가르키는 키워드 임
        {
            Console.WriteLine($"{this.Name}.Derived() 상속 호출");

        }
        ~Derived()
        {
            Console.WriteLine($"{this.Name} Derived소멸 호출 ");
        }

        public void DerivedMethod()
        {
            Console.WriteLine($"{Name} Dervied()메소드 호출");
        }

    }
    class MainApp
    {
        static void Main(string[] args)
        {

            Base a = new Base("a");
            a.BaseMethod();

            Derived b = new Derived("b");
            b.BaseMethod();
            b.DerivedMethod();

        }
    }

    
}
