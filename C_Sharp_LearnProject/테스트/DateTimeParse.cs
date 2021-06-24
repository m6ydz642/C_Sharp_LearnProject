using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_LearnProject.테스트
{
   
    class DateTimeParse
    {
        public static DateTime? TestTryParse(string text)
        {
            DateTime date;
            if (DateTime.TryParse(text, out date))
            {
                return date;
            }
            else
            {
                return null;
            }
        }

        public static int Prase_date(string Date, ref string strErr)
        // 호출될때 strErr 값은 ""로 들어가지만 ref 로 참조중이라 예외 뜨면 strErr값에 값 들어감  (디버깅 조회용)
        {
            int Compare = 0;
            try
            {
                string now = DateTime.Now.ToString("yyyy-MM-dd");
                Compare = DateTime.Compare(DateTime.Parse(now), DateTime.Parse(Date)); // 비교

                if (Compare == 1) // 과거 
                    return Compare;
     
                if (Compare == 0) // 당일 
                    return Compare;

                if (Compare == -1) // 미래
                    return Compare;


            }
            catch (FormatException ex)
            {
                strErr = ex.Message.ToString(); // 예외 걸려서 메시지 들어오는 부분을 호출되는 매개변수 ref가 참조함 (디버깅 조회용)
                return -999;
            }
            return Compare;
          
        }


        static void Main(string[] args)
        {

            string Pass = "2021-06-23"; // 과거
            string Feture = "2023-06-23"; // 미래
            string SystemNow = DateTime.Now.ToString("yyyy-MM-dd");   // 시스템 당일

            string NowDate =  "2021-06-24";

            string test = "";

            string strErr = "";
            int CompareTest = Prase_date(test, ref strErr); // ""값 테스트
            int ComparePass = Prase_date(Pass, ref strErr);
            int CompareFeture = Prase_date(Feture, ref strErr);
            int CompareNow = Prase_date(NowDate, ref strErr);

            Console.WriteLine("parse 공백  비교 결과 : " + CompareTest);
            Console.WriteLine("parse 과거 비교 결과 : " + ComparePass);
            Console.WriteLine("parse 미래 비교 결과 : " + CompareFeture);
            Console.WriteLine("parse 당일 비교 결과 : " + CompareNow);

            int test2 = DateTime.Compare(DateTime.Parse(SystemNow), DateTime.Parse(NowDate)); // 비교
            Console.WriteLine("test " + test2);
        }
    }
}
