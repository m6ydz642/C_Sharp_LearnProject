using System;
using System.Collections.Generic;
using System.Text;

namespace ReadOnly
{
   class Configration
    {
        private readonly int max;
        private readonly int min;

        public Configration(int max, int min)
        {
            this.min = max;
            this.max = min;
        }

        public void test(int NewMax)
        {
            max = NewMax; // 맴버변수의 max가 readonly라 생성자에서 값변경하는거 
                          // 아니면 사용불가
            // NewMax = max; // 값을 넣을수는 있음
        }
    }



    class MainApp
    {
        static void Main(string[] args)
        {

            Configration a = new Configration(10,100);

        }
    }

    
}
