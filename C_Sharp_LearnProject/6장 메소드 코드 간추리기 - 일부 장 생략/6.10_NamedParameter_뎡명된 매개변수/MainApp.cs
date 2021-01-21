using System;
using System.Collections.Generic;
using System.Text;

namespace LocalFunction
{
    class MainApp
    { // 6.10 선택적 매개 변수
     

       static void PrintProfile(string name, string phone ="")
        {
            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }
        static void Main(string[] args)
        {

            PrintProfile("태연");
            PrintProfile("윤아", "010-123-1234");
           

        }
    }
}
