using System;
using System.Linq;

namespace C_Sharp_Math_Paractice
{
    class Complement_Venn_Diagram
    {
        /// <summary>
        /// 벤다이어그램 차집합
        /// </summary>
        public void Get_Paractice()
        {
            // 차집합
            // 집합 A의 원소중에서 집합 B에 속하지 않는 모든 원소로 이루어진 집합
            // A-B
            
            string[] A = new string[5] { "중국", "일본", "인도","이란", "네팔" };
            string[] B = new string[5] { "중국", "인도", "필리핀", "베트남" ,"터키"};
            string[] C = new string[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i].Equals(B[j])) // A원소값이 B에 속한다면
                    {
                        Console.WriteLine("차집합 중복 발견 : " + A[i]);
                        C[i] = "중복발견으로 제거";
                        break;
                    }
                    else
                    {
                        C[i] = A[i]; // A원소 기준으로 속하지 않는 원소들만 담음
                    }
                }
            }

            for (int i = 0; i < C.Length; i++)
            {
                Console.WriteLine("A-B = " + C[i]);
            }


            // LINQ로도 출력해보기
            var data = from num in C
                       where num != null
                       orderby num
                       select num;

            foreach (var num in data)
            {

                Console.WriteLine("LINQ A-B = " + num);
            }








        }

    }
}
