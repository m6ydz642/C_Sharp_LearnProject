using System;
using System.Collections.Generic;
using System.Text;

namespace NestedClass
{
    class Configurtation
    {
        List<ItemValue> listConfig = new List<ItemValue>();

        public void SetConfig(string item, string value)
        {
            ItemValue iv = new ItemValue();
            iv.SetValue(this, item, value);
            // this -> Configurtaion 객체를 가르킴
        }

        public string GetConfig (string item)
        {
            foreach (ItemValue test in listConfig) 
            {
                if (test.GetItem() == item)
                {
                    return test.GetValue();
                }
            }
            return "값이 없엉";
        }
        private class ItemValue
        {
            private string item;
            private string value;

            public void SetValue(Configurtation config, string item, string value)
            {
                this.item = item;
                this.value = value;

                bool found = false ;
                for (int i =0; i<config.listConfig.Count; i++)
                {
                    if (config.listConfig[i].item == item)
                    {
                        config.listConfig[i] = this;
                        found = true;
                        break;
                     }
                }
                if (found == false)
                {
                    config.listConfig.Add(this);
                }

            }


            public string GetItem()
            {
                return item;
            }
            public string GetValue()
            {
                return value;
            }

        }
    }
  
    class MainApp
    {
        static void Main(string[] args)
        {

            Configurtation a = new Configurtation();
            a.SetConfig("version","1234"); // version에 해당하는 값을 가져옴
            Console.WriteLine($"{a.GetConfig("version")}");
            a.SetConfig("값을 다르게 넣어 못찾을 경우 ", "다르게 넣을경우");
            Console.WriteLine($"{a.GetConfig("아무값")}");
            // 값이 없을 경우 return "값이 없엉" 이 출력됨
          
        }
    }

    
}
