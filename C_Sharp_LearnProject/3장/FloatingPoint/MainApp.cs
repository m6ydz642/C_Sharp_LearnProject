using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_LearnProject.Overflow
{
    class MainApp
    { // 3.4.8 부동소수점 형식
        static void Main(string[] args)
        {
            float a = 3.1415_9265_3589_7932_3846f;
            // float형식 변수에 값을 직접 할당하려면 
            // 숫자뒤에 f를 붙여줘야 함
            Console.WriteLine(a);

            double b = 3.1415_9265_3589_7932_3846;
            Console.WriteLine(b);

        }
    }
}
