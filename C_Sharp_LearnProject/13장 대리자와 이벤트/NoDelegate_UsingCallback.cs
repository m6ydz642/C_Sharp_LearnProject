using System;
namespace UsingCallback
{
    class MainApp
    {
      

        static int AscendCompare(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        static int DecendComoare(int a, int b) // BubbleSort함수에서 호출해주는게 없어 함수 미사용
        {
            if (a < b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        static void BubbleSort(int[] DataSet)
        {
            int i = 0;
            int j = 0;
            int temp = 0;

            for (i = 0; i<DataSet.Length-1; i++)
            {
                for (j=0; j<DataSet.Length - (i+1); j++)
                {
                    if (AscendCompare(DataSet[j], DataSet[j+1]) > 0)
                    // 오름차순 정렬 호출 (대리자 없이)
                    // 내림차순을 할 경우 BubbleSort2를 만들어서 if문을 
                    // DecendComoare로 다시 호출해야 함
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 2, 10 };
            Console.WriteLine("오름차순 전");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("오름차순후");
            BubbleSort(array);
            for (int i=0; i<array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            
        }
    }
}
