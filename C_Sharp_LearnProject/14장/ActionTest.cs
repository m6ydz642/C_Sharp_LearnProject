using System;


namespace ActionTest
{

  

    class MainApp
    {
        static int resulttest;

        MainApp()
        {
             resulttest = 0; // 생성자에서 초기화
        }
        
        static void getNorMal(int x) // 액션 대리자 이해하려고 전역변수로 해서 Action <int> act2를 따라한거임
            // 초기화할때 0이었다가 내부적으로만 바뀌는거 같은데 갑자기 변수값이 바뀌길래 헷깔려서 따라해봄
        {
            resulttest = x * x;
            Console.WriteLine("resulttest = " + resulttest);

        }
        static void Main(string[] args)
        {

            Action act1 = () => Console.WriteLine("action()");
            act1();

            int result = 0;
            Action<int> act2 = (x) => result = x * x;

            act2(3);
            Console.WriteLine("result : " + result);

            // action대리자 따라하기
            /*************************************************/
            getNorMal(2);
            Console.WriteLine("resulttest : " + resulttest);
            /*************************************************/

            Action<double, double> act3 = (x, y) =>
            {
                double pi = x / y;
                Console.WriteLine("action<t1>, <t2> x,  y : " + pi);
            };

            act3(22, 7);
        }

    }
 }

