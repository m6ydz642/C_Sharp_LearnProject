using System;
using System.Linq;

namespace C_Sharp_Math_Paractice
{
    class Intersection_Venn_Diagram
    {
        /// <summary>
        /// 벤다이어그램 교집합
        /// </summary>
        public void Get_Paractice()
        {
            // 교집합
            // 집합 A와 B에 공통으로 들어있는 원소들의 집합
            // A∩B
            
            // 교집합 부터 문제는 메인 설명 + 문제가 별도로 있을경우 이걸 기반으로 일일히 다 코딩하지 않고 메인 설명에서 나오는 부분만 코딩함
            // 문제가 살짝 달라지는 경우 제외
            string[] A = new string[6] { "수원", "화성", "창덕궁","해인사", "장경판전", "종묘" };
            string[] B = new string[4] { "석굴암", "불국사", "창덕궁", "종묘" };
            string[] C = new string[A.Length];
            int count = 0;

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i].Equals(B[j]))
                    {
                        C[i] = B[j];
                        count++;
                        Console.WriteLine("A∩B = " + C[i]);
                    }
                }

              
            }

            // LINQ로도 출력해보기
            var data = from num in C
                       where num != null
                       orderby num
                       select num;

            foreach (var num in data)
            {

                Console.WriteLine("LINQ A∩B = " + num);
            }






        }

    }
}
