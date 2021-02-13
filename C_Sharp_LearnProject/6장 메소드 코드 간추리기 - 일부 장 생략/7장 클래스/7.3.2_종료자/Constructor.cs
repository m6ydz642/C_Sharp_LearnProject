using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    class Cat
    { // 7.3.2 종료자 
        public string Name;
        public string Color;

        public Cat(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;
        }
        public Cat()
        {
            Name = "";
            Color = "";
        }


        ~Cat() // 종료자
        {
            Console.WriteLine($"{Name} : 잘가");
        }

        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat("키티", "하얀색"); // 객체생성하면서 매개변수로 
      //      kitty.Color = "하얀색";
      //      kitty.Name = "키티";
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat nero = new Cat("네로", "검은색");
      //      nero.Color = "검은색";
      //      nero.Name = "네로";
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");


        }
    }

    
}
