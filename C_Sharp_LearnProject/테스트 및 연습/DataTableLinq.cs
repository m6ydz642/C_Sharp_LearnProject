using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace C_Sharp_LearnProject.테스트
{

    class DataTableLinq
    {

      
        static void Main(string[] args)
        {
            // linq  
            /*var leftJoin = from tb1s in tb2.AsEnumerable()
                           join tb2s in tb3.AsEnumerable()
                           on tb1s.Field<string>("WkCd") equals tb2s.Field<string>("WkCd") into dataKey
                           from tbResult in dataKey.DefaultIfEmpty()
                           select new
                           {
                               WkCd = tb1s.Field<string>("WkCd"),
                             //  Name = tb1s.Field<string>("Name"),
                               ID2 = (tbResult == null ? null : tbResult.Field<string>("Gbn"))
                           };

            var joinTable = from a in leftJoin.AsEnumerable()
                            where a.ID2 == null || a.ID2 != null
                            select a;*/



        }
    }

}