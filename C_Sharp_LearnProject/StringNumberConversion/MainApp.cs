﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StringNumberConversion2
{
    class MainApp
    { //3.1.19 문자열을 숫자로, 숫자를 문자열로
        static void Main(string[] args)
        {
            int a = 123;
            string b = a.ToString();
            Console.WriteLine(b);

            float c = 3.14f;
            string d = c.ToString();
            Console.WriteLine(d);

            string e = "123456";
            int f = Convert.ToInt32(e);
            Console.WriteLine(f);

            string g = "1.2345";
            float h = float.Parse(g);
            Console.WriteLine(h);

        }
    }
}
