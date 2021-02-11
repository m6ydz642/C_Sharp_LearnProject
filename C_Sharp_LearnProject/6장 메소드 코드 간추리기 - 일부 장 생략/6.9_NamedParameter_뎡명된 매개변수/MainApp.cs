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

            PrintProfile(phone: "010122341234", name: "박찬호");
                           // swift 프로그래밍 처럼 이름값 으로 가능
                           // 변수의 이름으로 값을 지정하는거라 순서 상관 X 

           

        }
    }
}
