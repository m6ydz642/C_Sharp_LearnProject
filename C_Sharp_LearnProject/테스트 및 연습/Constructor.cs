using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_LearnProject.테스트_및_연습
{
    class Constructor
    {
        string test;
        public Constructor()
        {

        }

        public Constructor(string test) : this()
        {
            this.test = test;
        }

        public void Test()
        {
            Console.WriteLine("테스트");
        }


    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Constructor constructor = new Constructor("인자전달 테스트");
            constructor.Test();
        }
    }

}
