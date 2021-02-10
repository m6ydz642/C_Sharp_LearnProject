using System;
using System.Collections.Generic;
using System.Text;

namespace RefReturn
{

    class Product
    {
        private int price = 100;
        public ref int GetPrice()
        {
            return ref price;
        }

        public void PrintPrice()
        {
            Console.WriteLine($"Price : {price}");
        }
    }
    class MainApp
    {

   
        static void Main(string[] args)
        {
            Product carrot = new Product();
            ref int ref_local_price = ref carrot.GetPrice();
            int normal_local_price = carrot.GetPrice();

            carrot.PrintPrice();

            Console.WriteLine($"ref local price : {ref_local_price}");
            Console.WriteLine($"normal_local_price : {normal_local_price}");

            ref_local_price = 200;

            carrot.PrintPrice();
            Console.WriteLine($"Ref Local Price : {ref_local_price}");
            Console.WriteLine($"normal_local_price : {normal_local_price}");
                 
        }
    }
}
