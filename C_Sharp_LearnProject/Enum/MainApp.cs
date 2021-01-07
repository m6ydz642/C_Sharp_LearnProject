using System;
using System.Collections.Generic;
using System.Text;

namespace StringNumberConversion
{
    class MainApp
    {
        enum DialogResult { YES, NO, CALCEL, CONFIRM, OK } // 메인 밖에서 정의
        static void Main(string[] args)
        {

            // 3.5.2 열거 형식 (여러 개의 상수를 정리)

            Console.WriteLine((int)DialogResult.YES); // 순서는 배열 타입으로 0,1,2 ~로 들어감
            // 그래서 int로 형변환해서 출력할시 순서 번호로 나옴
            Console.WriteLine((int)DialogResult.NO);
            Console.WriteLine((int)DialogResult.CALCEL);
            Console.WriteLine((int)DialogResult.CONFIRM);
            Console.WriteLine((int)DialogResult.OK);

            Console.WriteLine(DialogResult.YES); // 번호 안하고 상수만 출력하면 내용만 나옴
            // output : YES


        }
    }
}
