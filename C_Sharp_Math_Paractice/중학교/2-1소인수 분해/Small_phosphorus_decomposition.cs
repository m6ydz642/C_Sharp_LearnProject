using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Sharp_Math_Paractice
{
    class Small_phosphorus_decomposition
    {
        /// <summary>
        /// 소인수분해 람다식 part
        /// </summary>



       public Action Soinsu = () =>
        {
            int SoinsuNumber = 20;
            // 배열버전
            int[] result = new int[10];

            for (int i=1; i<= 5; i++)
            {
                if (result[i] % i == 0)
                {
                    result[i] = SoinsuNumber / 2;
                    SoinsuNumber = result[i];
                }
            }

            SoinsuNumber = 20;
            string test = "";
            int result2 = 0;
           // 리스트 버전
           List<int> Listresult = new List<int>();
            Listresult.Add(SoinsuNumber); // 0번째로 넣음

            int j = 0; // 리스트 배열 세어주는 변수
            for (int i = 2; i <= 10; i++)
            {
                if (SoinsuNumber % i == 0)
                {
                    result2 = SoinsuNumber / i;
                    Listresult.Add(result2);
                    SoinsuNumber = Listresult[j];
                    j++;
                }
            }

        };
    

    }
}
