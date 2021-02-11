using System;

namespace Practice
{
    class MainApp
    { // 6장 연습문제 2번
      // 오류고치기
      // 0이 나오는 이유
      // 리턴이 없는 void 상태로 out이나 ref로 참조하지않고 지역변수내의 mean변수값이 0으로 되어있는데 
      // 그대로 0을 가져가기 때문임

        static void Mean(double a, double b, double c, double d, double e, out double mean)
        {
            mean = (a + b + c + d + e) / 5;
        }

        static void Main(string[] args)
        {
            double mean = 0; // 이거 필요없음
            Mean(1, 2, 3, 4, 5, out mean);
            Console.WriteLine("평균 {0} ", mean);
        }

        // 변수값으로 안받고 리턴타입으로 함수로 호출도 가능
        /*   static double Mean(double a, double b, double c, double d, double e)
           {

               return (a + b + c + d + e) / 5;
           }

           static void Main(string[] args)
           {
               Console.WriteLine("평균 {0} ", Mean(1, 2, 3, 4, 5));
           }*/

    }
}
