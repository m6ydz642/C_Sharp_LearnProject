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

            for (int k=1; k<= 5; k++)
            {
                if (result[k] % k == 0)
                {
                    result[k] = SoinsuNumber / 2;
                    SoinsuNumber = result[k];
                }
            }

            SoinsuNumber = 20;
            string test = "";
            int result2 = 0;
           // 리스트 버전
           List<int> Listresult = new List<int>();
            Listresult.Add(SoinsuNumber); // 0번째로 넣음

            int j = 0; // 리스트 배열 세어주는 변수
            int i = 2;
            while (i < 10) 
            {
      
                if (SoinsuNumber % 2 == 0)
                {
                    j++;
                    result2 = SoinsuNumber / 2; // 2로 우선 나누어 보다가 안되면 밑에 else문으로 빠져서 3,4,5 올리면서 나누기를 시도함
                    Listresult.Add(result2);
                    SoinsuNumber = Listresult[j];
                    
                }
                else
                {
                    i++;
                    result2 = SoinsuNumber / i;
                    Listresult.Add(result2);
                    SoinsuNumber = Listresult[j];
                }

            }

            for (int k=0; k< Listresult.Count; k++)
            {
                Console.WriteLine("소인수 분해 : " + Listresult[k]);
            }

        };
    

    }
}
