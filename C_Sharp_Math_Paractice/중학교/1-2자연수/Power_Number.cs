using System;
using System.Linq;

namespace C_Sharp_Math_Paractice
{
    class Power_Number
    {
        /// <summary>
        /// 자연수 거듭제곱 part
        /// </summary>
        public void Get_Paractice()
        {
            // 거듭제곱 2의 3승 -> 밑 2 지수 3은 2^3으로 나타낸다 (표기 한계때문에)

            // 거듭제곱 나타내기 문제 1 (기타 동일한 숫자로 진행하는 문제는 카운트가 주를 이뤄서 생략하고 중간에 다른 숫자가 한개
            // 나와 문제가 살짝 달라지는 경우 부분문제만 코딩)
            // 3*3*3*3 이 거듭제곱으로 몇 지수 인지 나타내기 = 3^4 
            int number = 3;
            int result = 1;
            int index = 0; 

            for (int i = 0; i < 4; i++)
            {
                result *= number;
                index++;
            }

            Console.WriteLine("3 X 3 X 3 X 3 = " + result + " 이고 지수는 " + index + "이다");

            // 2 X 2 X 3 X 7 X 7 지수 구하기 (지수를 카운트 한다고 보면 됨)
            int[] number2 = new int[6];
            index = 1;// 위에서는 반복문으로 ++을 지수 횟수 만큼 해놔서 0으로 시작했지만 여기서는 지수가 2개면 1부터 시작해야 해서 1로 초기화
            // 자기자신 1개를 깔고 감

            result = 1; 

            number2[0] = 2;
            number2[1] = 2;
            number2[2] = 3;
            number2[3] = 7;
            number2[4] = 7;
            number2[5] = 7; 

            for (int i=0; i<number2.Length-1; i++)
            {
                if (number2[i] == number2[i+1]) // 다음 숫자랑 비교
                {
                    result = number2[i];
                    index++;
                    Console.WriteLine(result + "의 지수 = " + index );
                }
                else
                {
                    index = 1; 
                    // 중간에 배열 숫자 달라지면 지수를 1로 초기화 -> 2 X 2 X 2로 가다가 2^3승을 만들었는데 다음숫자 3 X 3 = 이 나와 지수를 다시 세야 하는 경우를 가정
                }
            }
            
        }

    }
}
