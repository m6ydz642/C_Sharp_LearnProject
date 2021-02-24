using System;


namespace SimpleLambda
{

    delegate int Calcuate(int a, int b);

    class MainApp
    {
        static void Main(string[] args)
        {
            Calcuate calc = (a, b) => a + b;
            Console.WriteLine($"3 + 4 = " + calc(3,4) );

        }

    }
 }

