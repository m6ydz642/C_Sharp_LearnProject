using System;
using System.Collections.Generic;
using System.Text;

namespace StringSearch
{
    class MainApp
    { //A.1 문자열 안에서 찾기
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            Console.WriteLine(greeting);
            Console.WriteLine();

            // IndexOf() 함수 사용
            Console.WriteLine("IndexOf 'good' : {0} ", greeting.IndexOf("Good"));
            // 지정된 문자열의 위치를 찾음 (인덱스 번호로)

            Console.WriteLine("IndxOf 'o' : {0}", greeting.IndexOf('o'));

            // LastIndexOf()함수 사용
            Console.WriteLine("LastIndexOf 'Good' : {0}", greeting.LastIndexOf("Good"));
            Console.WriteLine("LastIndexOf 'o' : {0} ", greeting.LastIndexOf("o"));
            // 문자열의 위치를 뒤에서 찾음

            // startsWith()함수 사용
            Console.WriteLine("startsWith 'Good' : {0}", greeting.StartsWith("Good"));
            // 지정된 문자열로 시작하는지를 찾음

            // EndsWith() 함수
            Console.WriteLine("EndsWith 'Good' : {0} ", greeting.EndsWith("Evening"));
            // 지정된 문자열로 끝나는지를 찾음

            // Contains() 함수
            Console.WriteLine("Contains 'Good' : {0} ", greeting.Contains("Evening"));

            // 지정된 문자열을 포함하는지를 찾음

            // Replace() 함수
            Console.WriteLine("Replaces 'Morning' with 'Evening' : {0}", greeting.Replace("Morning", "Evening"));
        }
    }
}
