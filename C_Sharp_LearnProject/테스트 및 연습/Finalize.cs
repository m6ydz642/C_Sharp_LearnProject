using System;
using System.IO;

namespace Finalize
{
    class TestFinalize : IDisposable
    {
        public TestFinalize()
        {

            Console.WriteLine("생성자");

        }

        public void Fun()
        {
            Console.WriteLine("Fun 함수호출");
        }

        public void Dispose()
        {
            Console.WriteLine("TestFinalize 메모리 해제");

        }

        ~TestFinalize() // using문으로 자원을 관리해 소멸자 필요없음
        {
            Console.WriteLine("TestFinalize 소멸자");
        }
    }
    class Finalize
    {
        static void Main(string[] args)
        {
            using (TestFinalize fin = new TestFinalize())
            {
                fin.Fun();
            }

        }
    }
}
