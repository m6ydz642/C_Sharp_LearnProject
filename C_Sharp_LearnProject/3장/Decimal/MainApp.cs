using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_LearnProject.Overflow
{
    class MainApp
    { // 3.4.9 decimal 형식
        static void Main(string[] args)
        {
            float a = 3.1415_9265_3589_7932_3846_2643_3832_79f;
            double b = 3.145_9265_3589_7932_3846_2643_3832_79;
            // 뒤에 f같은거 안붙이면 double
            decimal c = 3.1415_9265_3589_7932_3846_2643_3832_79m;
            // m을 붙이면 decimal

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);


        }
    }
}
