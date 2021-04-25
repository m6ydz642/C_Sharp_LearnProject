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
            
            // 교집합 부터는 문제를 일일히 다 코딩하지 않고 메인 설명에서 나오는 부분만 코딩함
            // (문제를 일일히 다 푸는것 보단 문제에 해당하는 용어 한개만 푸는게 나을거 같음 집합 같은 경우는 문제마다 내용이 달라서배열 내용이 계속 달라지는게 끝이라
            // 중복으로 또 배열을 만들어야 해서)
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

                // LINQ로도 출력해보기
                var data = from num in C
                           where num != null
                           orderby num
                           select num;

                foreach (var num in data)
                {

                    Console.WriteLine("data LINQ : " + num);
                }

            }




        }

    }
}
