using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_LearnProject.Overflow
{
    class MainApp
    { //3.1.13 박싱과 언박싱
        static void Main(string[] args)
        {
            int a = 123;
            object b = (object)a;
            int c = (int)b;
            // 하는중
        }
    }
}
