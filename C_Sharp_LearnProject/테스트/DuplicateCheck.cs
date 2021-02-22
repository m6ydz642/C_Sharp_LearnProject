using System;


namespace DuplicateCheck
{
   
    class MainApp
    {
        static void Rand()

        {
            Random random = new Random();
           
            int[] array = new int[3];
            for (int i=0; i<array.Length; i++)
            {
                int rand = random.Next(1, 10);
                array[i] = rand;
                for (int j = 0; j <i; j++) // 다음 인수로 중복검사하게할 값
                    // i = 0, j = 0일때는 검사 안함
                {
                  
                    Console.WriteLine("array : " + array[i]);
                     if (array[i] == array[j])
                    {
                        Console.WriteLine("중복발견 : " + array[i]);
                        i--;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("rand : " + array[i]);
                    }
                }
                
            }
            
        }

        static void Main(string[] args)
        { // 랜덤함수 중복체크
            Rand();
        }
    }
}
