using System;
using System.Linq;

namespace C_Sharp_Math_Paractice
{
    class Union_Venn_Diagram
    {
        /// <summary>
        /// 벤다이어그램 합집합
        /// </summary>
        public void Get_Paractice()
        {
            // 합집합
            // 집합 A와 B에 공통으로 들어있는 원소들의 집합
            // A∪B


            // 사실 처음부터 배열을 중복 아닌 문자로 넣어서 합치면 그만이지만 하는김에 중복을 제거하고 넣어 봄

            // 중복제거로 Distint함수가 있지만 C언어 처럼 배열을 직접 검사 해보는 방식으로 감
            
            string[] A = new string[6] { "수원", "화성", "창덕궁","해인사", "장경판전", "종묘" };
            string[] B = new string[4] { "석굴암", "불국사", "창덕궁", "종묘" };
            string[] D = new string[A.Length + B.Length];
            string[] temp = new string[A.Length + B.Length];
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (!A[i].Equals(B[j])) // A원소와 B원소가 같지 않다면
                    {
                        D[i] = A[i];
                    }
                    else
                    {
                        D[i] = A[i];
                    }
                }
            }
            

            for (int i=0; i < B.Length; i++) // 전체 번호 중 6번째 배열 번호 부터 이어서 함 (역으로 검사함)
            {
                for (int j=0; j < A.Length; j++)
                {
                    if (B[i].Equals(D[j])) // B원소와 D원소가 같다면
                    {
                        count++;
                        Console.WriteLine("중복 발견 : " + D[i + B.Length + 2]);
                   //   Console.WriteLine("중복 개수 : " + count);
                        D[i + B.Length + 2] = "중복발견으로 제거";
                        break;
                    }
                    else
                    {
                        D[i + B.Length + 2] = B[i]; // 같지 않다면
                    }
                }
            }

            for (int i = 0; i < D.Length; i++)
            {
                Console.WriteLine("A∪B = " + D[i]);
            }

            // LINQ로도 출력해보기
            var data = from num in D
                       where num != null
                       orderby num
                       select num;

            foreach (var num in data)
            {

                Console.WriteLine("LINQ A∪B = " + num);
            }


        }

    }
}
