using System;
using System.Collections.Generic;
using System.Text;

namespace UsingParams
{
    class MainApp
    { // 6.8 가변길이 매개 변수
     

        static int Sum(params int[] args)
        {
            int sum = 0;
            for (int i=0; i<args.Length; i++)
            {
                if (i>0)
                {
                    Console.Write(", ");
                }
                Console.Write(args[i]);

                sum += args[i];
            }

            Console.WriteLine();
            return sum;
        }
        static void Main(string[] args)
        {
            int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine($"sum : {sum}");
           

        }
    }
}
