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
            DataTable tmpdata = new DataTable(); ; // 바꿔치기용 데이터
            DataTable insertdata = new DataTable(); // 유저가 삽입하는 데이터
            DataTable originaldata = new DataTable(); // 원본 데이터 (코드 전용)

            tmpdata.Columns.Add("WkCd");
            tmpdata.Columns.Add("Value");
            tmpdata.Columns.Add("Gbn");
            tmpdata.Columns.Add("Month");
            tmpdata.Columns.Add("Name");

            tmpdata.Rows.Add("1H70000", "0", "01", "", "");
            tmpdata.Rows.Add("1H70000", "0", "02", "", "");
            tmpdata.Rows.Add("1H60000", "0", "01", "", "");
            tmpdata.Rows.Add("1H60000", "0", "02", "", "");
            tmpdata.Rows.Add("1H50000", "0", "01", "", "");
            tmpdata.Rows.Add("1H50000", "0", "02", "", "");

            insertdata.Columns.Add("WkCd");
            insertdata.Columns.Add("Value");
            insertdata.Columns.Add("Gbn");
            insertdata.Columns.Add("Month");
    

            insertdata.Rows.Add("1H70000", "99", "01", "07"); 
            insertdata.Rows.Add("1H50000", "978", "02", "07"); // 순서 상관없이 랜덤한 숫자 입력

            originaldata.Columns.Add("Code");
            originaldata.Columns.Add("Name");
            originaldata.Rows.Add("1H70000", "테스트코드2");
            originaldata.Rows.Add("1H60000", "테스트코드3");
            originaldata.Rows.Add("1H50000", "테스트코드4");
            /* // 데이터 정렬
            DataView dv = new DataView(tb3);
            dv.Sort = "Gbn ASC, WkCd DESC";
            tb3 = dv.ToTable();
            */

            string insertWkcd = "";
            string insertGbn = "";
            string insertValue = "";

            string tmpdataWkCd = "";
            string tmpdataGbn = "";
            string tmpdataValue = "";

            // tmpdata에 original data의 이름을 삽입 하여 이름 매칭 하는 작업
 

                foreach (DataRow row in originaldata.Rows) //
                {
                string Code = row.Field<string>("Code"); 
                string Name = row.Field<string>("Name");

                foreach (DataRow rows in tmpdata.Rows) //
                {
                    tmpdataWkCd = rows.Field<string>("WkCd");

                    if (Code.Equals(tmpdataWkCd))
                    
                    {
                        rows["Name"] = Name; // 원본 코드에 Name과 tmpdata에 코드에 해당하는 이름을 찾아 변경
                    }
                }
                
            }

            for (int i = 0; i < insertdata.Rows.Count ; i++) // insert데이터 만큼 반복해야 데이터가 1개 더라도 비교 할 수 있음
            {
                DataRow rows = insertdata.Rows[i]; // 데이터가 1개일때 1개만큼을 tmpdata를 반복하면서 코드를 찾아냄
                insertWkcd = rows.Field<string>("WkCd"); // insert데이터에 들어있는 WkCd를 찾아냄
                insertGbn = rows.Field<string>("Gbn"); 
                insertValue = rows.Field<string>("Value"); 

                foreach (DataRow row in tmpdata.Rows) // 가짜 데이터 만큼 반복하면서 코드를 찾아내어 가짜 데이터의 데이터를 진짜로 바꿀 반복문 
                {
                    tmpdataWkCd = row.Field<string>("WkCd"); // tmp 데이터에 들어있는 WkCd를 찾아냄
                    tmpdataGbn = row.Field<string>("Gbn");
                    tmpdataValue = row.Field<string>("Value");

                    if (insertWkcd.Equals(tmpdataWkCd) && insertGbn.Equals(tmpdataGbn)) 
                        // insert(사용자 입력) wkcd, gbn와 tmpdata들어있는 wkcd, gbn 을 찾아내어 기존 tmpdata내용을 사용자 입력 데이터로 바꿀 거임
                    {
                        row["WkCd"]= insertWkcd; // 사용자가 입력했던 값과 tmpdata에 데이터가 같은 코드면 변경처리
                        row["Gbn"] = insertGbn;
                        row["Value"] = insertValue;
                    }

                }
            }



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


            DataTable SelectData = tmpdata; // 데이터 가공 성공 및 다른 테이블에 넣어보기
    

         


        }
    }

}