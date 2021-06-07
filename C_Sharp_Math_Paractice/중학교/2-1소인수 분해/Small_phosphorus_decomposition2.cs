using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Sharp_Math_Paractice
{
    class Small_phosphorus_decomposition2
    {
        /// <summary>
        /// 소인수분해2 약수구하기 람다식 part
        /// </summary>


  
       public Action Soinsu2 = () =>
       {
           int SoinSu_Number = 28;
           List<int> numberList = new List<int>();
           int[] numberArray = new int[SoinSu_Number];

           // 배열버전 약수 구하기 추가
           for (int i = 1; i < SoinSu_Number; i++)
            {
                if (SoinSu_Number % i == 0)
                {
                   numberArray[i] = i;
                }

                if (numberArray[i] != 0)
                    Console.WriteLine("배열 버전 " + SoinSu_Number + "의 약수 " + numberArray[i]);

            }
           Console.WriteLine();


           // 리스트 버전 약수 구하기 추가

           for (int i = 1; i<SoinSu_Number; i++)
            {
                if (SoinSu_Number % i == 0)
                {
                    numberList.Add(i);
                }

           }

            foreach(int a in numberList)
           {
               Console.WriteLine("리스트 버전 " + SoinSu_Number + "의 약수 " + a);

           }

       };
    

    }
}
