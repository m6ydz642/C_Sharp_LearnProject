using System;

namespace C_Sharp_Math_Paractice
{
    class Venn_Diagram
    {
        /// <summary>
        /// 벤다이어그램 연습문제
        /// </summary>
        public void Get_Paractice()
        {
            // 문제2 
            // 12보다 작은 자연수의 집합을 A라고 할 때 기호 쓰기 (기호는 지원안되서 다른 문자로 대체함 --> 해당안함)
            int A; // 집합
            string result;
            int resultInt;
            A = 12;
            result = 2 < A ? "2" : "해당안함";
            Console.WriteLine("12보다 작은 자연수의 집합을 A라고 할때 해당하는 집합");
            Console.WriteLine("2는 A에 속한다 : " + result);

            result = 5 < A ? "5" : "해당안함";
            Console.WriteLine("5는 A에 속한다 : " + result);

            result = 12 > A ? "12" : "해당안함";
            Console.WriteLine("12는 A에 속한다 : " + result);

            result = 12 > A ? "15" : "해당안함";
            Console.WriteLine("15는 A에 속한다 : " + result);
            Console.WriteLine();
            // 위의 코드를 다르게 해보기
            int[] result_array;
            result_array = new int[4];
            result_array[0] = 2;
            result_array[1] = 5;
            result_array[2] = 12;
            result_array[3] = 15;

            for (int i=0; i<4; i++)
            {
                if (result_array[i] < 12) Console.WriteLine(result_array[i] + "는 " + A + "에 속한다");
                else Console.WriteLine(result_array[i] + "는 " + A + "에 속하지 않는다");
            }

            Console.WriteLine();

            // 문제 8
            // 집합 A에 대하여 n(A)구하기

            // 1) A={ X | X는 24의 약수 }
            A = 24;
            int[] result_array2 = new int[A+1];
            int length=0;
            Console.Write(A + "의 약수 ");
            for (int i=1; i<=A; i++) // 24의 약수 먼저 구하기
            {
             if(A % i == 0)
                {
                    result_array2[i] = A / i;
                }
             if(result_array2[i] != 0)
                {
                    length++;
                    Console.Write(result_array2[i] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("1) n(A)=" + length);

            // 2) A={X | X는 2미만의 짝수}
            A = 2;
            length = 0;
            if (2 < A)
            {
                if(2 % 2 == 0)
                {
                    length++;
                }
            }
            Console.WriteLine("2) n(A)=" + length);

            // 3) A={2,4,6 ... 200}
            A = 200;

            resultInt = A / 2;
            Console.WriteLine("3) n(A)=" + resultInt);

            A = 100;
            length = 0;
            // 4) A={X | X는 5보다 크고 100보다 작은 자연수
            for (int i = 1; i < A; i++)
            {
                if (5 < i && 100 > i)
                {
                    length++;
                   
                }
            }
            Console.WriteLine("4) n(A)=" + length);

        }
     


    }
}
