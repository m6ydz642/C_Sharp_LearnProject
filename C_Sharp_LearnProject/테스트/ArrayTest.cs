using System;


namespace ArrayTest
{
   
    class ArrayTest
    {
        
        // 중복검사 순차 검사해보기
        // 1234
        // 234
        // 34 순으로 확인
        static void Main(string[] args)
        {
            string test = "1234";
            Console.WriteLine("test " + test[2]);
            char test2 = test[2];
            Console.WriteLine("test[2] array : " + test[2]); // 자바에서는 안되는데 C#에서는 되네
        }
    }
}
