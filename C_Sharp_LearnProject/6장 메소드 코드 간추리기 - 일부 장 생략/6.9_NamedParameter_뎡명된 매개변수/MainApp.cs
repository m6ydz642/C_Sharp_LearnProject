using System;
using System.Collections.Generic;
using System.Text;

namespace UsingParams
{
    class MainApp
    { // 6.9 명명된 매개 변수
     

       static void PrintProfile(string name, string phone)
        {
            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }
        static void Main(string[] args)
        {

            PrintProfile(name: "박찬호", phone: "010122341234");
           

        }
    }
}
