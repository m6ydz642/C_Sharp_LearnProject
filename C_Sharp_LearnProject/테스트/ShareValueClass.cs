using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_LearnProject.테스트
{
    public class ShareValueClass
    {
        public string Value { get; set; }
    }

    class GetValueClass
    {
       // ShareValueClass member;

        public GetValueClass()
        {
            ShareValueClass.Value = "Wow";
        }
        static void Main(string[] args)
        {
         

        }
    }
}
