using System;


namespace DuplicateCheck
{
   
    class DuplicateCheck
    {
        static void Rand()
        {
            Random random = new Random();
           
            int[] array = new int[3];
            bool status = true;

            for (int i=0; i<array.Length; i++)
            {
                int rand  = random.Next(1, 10);
                status = true; // 중복이 발견되어 false상태이면 중복을 제외하고 출력해버리기 때문에 한번더 돌때 true로 바꿈
                for (int j = 0; j < i; j++) // 다음 인수로 중복검사하게할 값
                    // i = 0, j = 0일때는 검사 안함
                {
                    
                    // Console.WriteLine("array : " + array[i]);
                    if (array[j] == rand)
                    {
                       Console.WriteLine("중복발견 : " + array[j]);
                        status = false; // false처리해서 배열에 값을 못넣도록 함 (밑에 array[i] = rand) 부분에 
                        i--; // 다시 반복하기 위해 -- 처리함
                        break;
                    }
                    
                }
                if (status) // true일 경우만 출력하고 배열에 넣음
                {
                    array[i] = rand;
                    Console.WriteLine("rand : " + array[i]);
                }
            }

            for (int i =0; i < array.Length; i++) {

                Console.WriteLine("배열에 들어있는 수 : " + array[i]);
            }

            
        }

        static void Main(string[] args)
        { // 랜덤함수 중복체크
            Rand();
        }
    }
}
