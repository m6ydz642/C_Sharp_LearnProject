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
            SubSet_Venn_Diagram subset_venn = new SubSet_Venn_Diagram(); // 부분집합
            subset_venn.Get_Paractice();

            Intersection_Venn_Diagram intersection = new Intersection_Venn_Diagram(); // 교집합
            intersection.Get_Paractice();

            Union_Venn_Diagram Unionvenn = new Union_Venn_Diagram(); // 합집합
            Unionvenn.Get_Paractice();



        }
    }
}
