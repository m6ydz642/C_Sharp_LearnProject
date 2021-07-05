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
            DataTable tb1 = new DataTable();
            DataTable tb2 = new DataTable();
            DataTable tb3 = new DataTable();

            tb2.Columns.Add("WkCd");
            tb2.Columns.Add("Value");
            tb2.Columns.Add("Gbn");
            tb2.Columns.Add("Month");
         //   tb2.Rows.Add("1H80000", "", "01", "");
            tb2.Rows.Add("1H70000", "", "01", "");
            tb2.Rows.Add("1H60000", "", "01", "");
            tb2.Rows.Add("1H50000", "", "01", "");

         //   tb2.Rows.Add("1H80000", "", "02", "");
            tb2.Rows.Add("1H70000", "", "02", "");
            tb2.Rows.Add("1H60000", "", "02", "");
            tb2.Rows.Add("1H50000", "", "02", "");

            // 테스트 데이터
            tb3.Columns.Add("WkCd");
            tb3.Columns.Add("Value");
            tb3.Columns.Add("Gbn");
            tb3.Columns.Add("Month");
         //   tb3.Rows.Add("1H80000", "10", "01", "07");
            tb3.Rows.Add("1H70000", "11", "01", "07");
            tb3.Rows.Add("1H70000", "19", "02", "07");//  임의 순서 변경
            tb3.Rows.Add("1H60000", "12", "01", "07");
            tb3.Rows.Add("1H50000", "13", "01", "07");
            tb3.Rows.Add("1H50000", "99", "02", "07"); //  임의 순서 변경
    

            tb1.Columns.Add("Code");
            tb1.Columns.Add("Name");
            tb1.Rows.Add("1H80000", "테스트코드1");
            tb1.Rows.Add("1H70000", "테스트코드2");
            tb1.Rows.Add("1H60000", "테스트코드3");
            tb1.Rows.Add("1H50000", "테스트코드4");


            var leftJoin = from tb1s in tb2.AsEnumerable()
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
                            select a;


            DataView dv = new DataView(tb3);
            dv.Sort = "Gbn ASC, WkCd DESC";
               tb3 = dv.ToTable();
            int j = 0;
            foreach (DataRow row in tb3.Rows) // 원래 데이터
            {
                DataRow row_tb2 = tb2.Rows[j];
                string WkCd = row_tb2.Field<string>("WkCd");
                string Value= row_tb2.Field<string>("Value");
                string Month = row_tb2.Field<string>("Month");

                if(WkCd == row.Field<string>("WkCd"))
                {
                    // row_tb2.Table.Rows[j][j] = row.Field<string>("Value");
                    row_tb2["Value"] = row.Field<string>("Value");
                    row_tb2["Month"] = row.Field<string>("Month");
                }
                j++;
            }
    

         


        }
    }

}