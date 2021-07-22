using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_LearnProject.테스트_및_연습
{
    class GetSet
    {
        // get set 프로퍼티 
        public string _something;
        public string Something
        {
            get
            {
                return _something;
            }
            set
            {
                _something = value;
            }
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            GetSet gs = new GetSet();
            gs._something = "와우";
            Console.WriteLine("내용 : " + gs._something);
            Console.WriteLine("내용 : " + gs.Something);

        }
    }
}