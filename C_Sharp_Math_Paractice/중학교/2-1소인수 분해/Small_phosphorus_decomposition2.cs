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

           // 소인수 분해 + 약수 구하기
           // 문제 7) (1) 2^3 X 5 약수 구하기 

           numberList = new List<int>();
          List<int> SoinsuNumberList = new List<int>();


           numberList.Add(2);
           numberList.Add(2);
           numberList.Add(2);
           numberList.Add(5);

           int j = 0;
           for (int i= 0; i<numberList.Count; i++) {
               j++;
               if (j < numberList.Count && numberList[i].Equals(numberList[j]) )
               {
                   SoinsuNumberList.Add(numberList[i]);
                  
               }
               if (j < numberList.Count && !numberList[i].Equals(numberList[j])) 
               // 리스트 내의 내용이 맞지 않는 시점이 오면 그 전단계 값을 비교함
              
               {
                   if(numberList[i-1].Equals(numberList[i-2]))
                        SoinsuNumberList.Add(numberList[i-1]);
                   // 0,1 1,2 2,3 을 비교했는데 0,1 1,2 까지 맞고 2,3부터 안맞으면 역순으로 돌아가 2,1를 비교해 1,2번째중 2번째의 값을 마지막으로 판단해 넣음
                   // 0,1 비교시 같으면 리스트에 0번째 수를 넣고 1,2를 비교하면 1번째 수를 리스트에 넣는데 마지막 2번째는 조건이 안맞아 넣을수가 없기 때문임   
                   // 대신 이방법은 i가 1이나 2이상이 되기 전에 조건이 안맞으면 i값이 마이너스로 가서 예외로 빠짐 ㅋㅋ;
               }

           }
           // 그냥 수를 한개 정해서 그걸로 비교 후 카운트로 소인수 몇 승인지 정하는 걸로

           // 소인수 분해 구하기
           SoinSu_Number = 20;
           int result2 = 0;
           SoinsuNumberList = new List<int>();

           j = 2; // 나눌대상
           for (int i =0; i <= SoinSu_Number; i++) // 소인수가 나눠질때 계속 반영되서 i보다 작을때까지
           {
               if (SoinSu_Number % j == 0)
               {
                   SoinSu_Number = SoinSu_Number / j; // 2로 우선 나누어 보다가 안되면 밑에 else문으로 빠져서 3,4,5 올리면서 나누기를 시도함
                   SoinsuNumberList.Add(j);

               }
               else
               {
                  j++;
               }
           }



           };
    

    }
}
