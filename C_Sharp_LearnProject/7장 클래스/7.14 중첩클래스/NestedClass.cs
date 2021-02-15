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
            Configurtation test = new Configurtation() ;
            iv.SetValue(test, item, value);
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
            return "";
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
            a.SetConfig("v","1234");
            Console.WriteLine($"{a.GetConfig("v")}");

        }
    }

    
}
