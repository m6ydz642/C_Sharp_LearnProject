using System;
using System.Collections.Generic;
using System.Text;

namespace LocalFunction
{
    class MainApp
    { // 6.11 로컬 함수

         static string ToLowerString(string input)
        {
            {
                var arr = input.ToCharArray();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = ToLowerChar(i);
                }

                char ToLowerChar(int i) // 로컬 함수 선언 

                {
                    if (arr[i] < 65 || arr[i] > 90)
                        return arr[i];
                    else
                        return (char)(arr[i] + 32);
                }

                return new string(arr);
            }
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ToLowerString("hello"));

        }

    }
}
