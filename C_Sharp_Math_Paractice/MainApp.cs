using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Math_Paractice
{
    class MainApp
    {
        
        static void Main(string[] args)
        {
            // C#을 이용하여 중학교 수학 문제 풀어보기
            Set_Venn_Diagram set_venn = new Set_Venn_Diagram(); // 집합 기초
            set_venn.Get_Paractice();
            Console.WriteLine();

            SubSet_Venn_Diagram subset_venn = new SubSet_Venn_Diagram(); // 부분집합
            subset_venn.Get_Paractice();
            Console.WriteLine();

            Intersection_Venn_Diagram intersection = new Intersection_Venn_Diagram(); // 교집합
            intersection.Get_Paractice();
            Console.WriteLine();

            Power_Number Unionvenn = new Power_Number(); // 합집합
            Unionvenn.Get_Paractice();
            Console.WriteLine();

            Complement_Venn_Diagram Complement = new Complement_Venn_Diagram(); // 차집합
            Complement.Get_Paractice();
            Console.WriteLine();

            Power_Number number = new Power_Number(); // 거듭제곱 자연수
            number.Get_Paractice();
            Console.WriteLine();

            Small_phosphorus_decomposition Soinsu = new Small_phosphorus_decomposition();
            Soinsu.Soinsu(); // 소인수 분해 람다식으로 호출

            Small_phosphorus_decomposition2 Soinsu2 = new Small_phosphorus_decomposition2();
            Soinsu2.Soinsu2(); // 소인수 분해2 + 약수 구하기 람다식으로 호출


        }
    }
}
