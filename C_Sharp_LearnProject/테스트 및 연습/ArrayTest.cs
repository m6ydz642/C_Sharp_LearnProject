using System;


namespace ArrayTest
{
   
    class ArrayTest
    {
       
        static void Main(string[] args)
        {
            string test = "1234";
            Console.WriteLine("test " + test[2]);
            char test2 = test[2];
            Console.WriteLine("test[2] array : " + test2); // 자바에서는 안되는데 C#에서는 되네

            char test3 = test[2];
          //  Console.WriteLine("test3 : " + test3[0]); // 이건 안됨
        }
    }
}
