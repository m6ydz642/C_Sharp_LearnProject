using System;


namespace ArrayCheck
{
   
    class ArrayCheck
    {
        
        // 중복검사 순차 검사해보기
        // 1234
        // 234
        // 34 순으로 확인
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] array = new int[3];
            bool status = true;

            for (int i = 0; i < 3; i++)
            {
                int rand = random.Next(1, 10);

                Console.Write(i);
                for (int j = i+1; j < 3; j++)
                {
                    Console.Write(j);

                }
                Console.WriteLine();
            }

            Console.WriteLine("흠");
        }
    }
}
