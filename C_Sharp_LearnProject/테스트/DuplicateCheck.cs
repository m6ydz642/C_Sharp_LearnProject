using System;


namespace DuplicateCheck
{
   
    class MainApp
    {
        static void Rand()

        {
            Random random = new Random();
            int rand = random.Next(1,10);
            int[] array = new int[3];
            for (int i=0; i<array.Length; i++)
            {
                array[i] = rand;
                Console.WriteLine("rand : " + rand);
            }
            
        }

        static void Main(string[] args)
        { // 랜덤함수 중복체크
            Rand();
        }
    }
}
