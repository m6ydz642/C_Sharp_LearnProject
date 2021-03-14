using System;


namespace Getter_Setter
{
   
   public class Getter_Setter_Main
    {


        // main 값 다른객체 생성자로 보내기
        public void getset_test()
        {
            Getter_Setter_Value a = new Getter_Setter_Value();
            Console.WriteLine(a.Number()); // 함수형 호출
            Console.WriteLine(a.NumberGetSet); // getset 호출
        }


        static void Main(string[] args)
        {

            Getter_Setter_Main a = new Getter_Setter_Main();
            a.getset_test();


        }
    }
}
