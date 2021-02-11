using System;
using System.Collections.Generic;
using System.Text;

namespace OptionalParameter
{
    class MainApp
    { // 6.10 선택적 인수
     

        static void PrinterProfile(string name, string phone = "")
        {
            Console.WriteLine($"Name:{name}, Phone : {phone}");
        }

          
        static void Main(string[] args)
        {
            PrinterProfile("미스터");
            PrinterProfile("미스터 킴", "010-123-1234");
            PrinterProfile(name: "킴", phone : "010-1234-1234");

        }
    }
}
