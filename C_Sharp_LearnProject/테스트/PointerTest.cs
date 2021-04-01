using System;


namespace PointerTest
{
  
    class PointerTest
    {
        
        static void Main(string[] args)
        {
            unsafe
            {
                int number = 27;
                int* pointer = &number;

                Console.WriteLine("printer number : " + number);
                Console.WriteLine("printer number : " + *pointer);

                *pointer = 22;
                Console.WriteLine("printer number : " + *pointer);

            }
            

        
        }
    }
}
