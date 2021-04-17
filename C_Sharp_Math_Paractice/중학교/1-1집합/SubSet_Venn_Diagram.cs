using System;

namespace C_Sharp_Math_Paractice
{
    class SubSet_Venn_Diagram
    {
        /// <summary>
        /// 벤다이어그램 부분집합 연습문제
        /// </summary>
        public void Get_Paractice()
        {
            // 부분 집합 
            // 문제1) 부분집합에 맞는 기호 작성
            {
                string[] A = new string[2] { "a", "b" };
                string[] B = new string[5] { "a", "b", "c", "d", "e" };
                string[] C = new string[4];
                string result;
                int resultInt;
                int count = 0;

                Console.WriteLine();

                Console.Write("{");

                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write(A[i]);
                    if (A[i] == B[i])
                    {
                      
                        count++;

                        if (count < 2)
                        {
                            Console.Write(", ");
                        }
                    }
                }

                Console.Write("} ");

                if (count >= 2)
                {
                    Console.WriteLine("A는 B에 해당함");
                }
            }

            { // 블럭문 지정
                int[] A = new int[3] { 1, 3, 5 };
                int[] B = new int[4] { 1, 3, 6,7 };
                string result;
                int resultInt;
                int count = 0;

                Console.Write("{");
                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write(A[i]);
                    if (A[i] == B[i])
                    {
                        
                        count++;

                        if (count < 3)
                        {
                            Console.Write(", ");
                        }
                    }
                }

                Console.Write("} ");

                if (count >= 3)
                {
                    Console.WriteLine("A는 B에 해당함");
                }
                else
                {
                    Console.WriteLine("A는 B에 해당안함");
                }

            }

        }
    }
}
