using System;


namespace Getter_Setter
{
   
   public class Getter_Setter_Value
    {

        public int NumberGetSet
        {
            get; set;
        }

        public Getter_Setter_Value()
        {

        }

        public int Number()
        {
             NumberGetSet = 1234;
            int number = NumberGetSet + 1234;
            return number;
        }


    }
}
