using System;
using System.Collections.Generic;
using System.Text;

namespace This
{
 class Employee
    {
        private string Name;
        private string Position;

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetPostion(string Postion)
        {
            this.Position = Postion;
        }
        public string GetPosition()
        {
            return this.Position;
        }
    }



    class MainApp
    {
        static void Main(string[] args)
        {
            Employee pooh = new Employee();
            pooh.SetName("Pooh");
            pooh.SetPostion("Waiter");
            Console.WriteLine($"{pooh.GetName()} {pooh.GetPosition() }");

            Employee tigger = new Employee();
            tigger.SetName("Tigger");
            tigger.SetPostion("Cleaner");
            Console.WriteLine($"{tigger.GetName()} {tigger.GetPosition() }");
        }
    }

    
}
