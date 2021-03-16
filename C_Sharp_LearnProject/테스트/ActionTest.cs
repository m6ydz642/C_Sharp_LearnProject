using System;


namespace ActionTest
{
   class ActionCommand
    {
      /*  public ActionCommand()
        {
            Console.WriteLine("아무것도 들어있지 않은 기본생성자 호출");
        }*/
 

        public ActionCommand(Func<string> test100 = null) // 인수없는 기본 생성자는 이 생성자를 호출함
        {
            Console.WriteLine("ActionCommand 생성자에 Func들어간 생성자 호출");
        }

       public ActionCommand(Action<string> test, Func<string> test2 = null, Func<string> test3 = null)
            // 확인해보니 Action대리자는 new Action<string>(method)했을때 인수개수가 맞춰서 넣어야 하는 반면
            // Func대리자는 인수개수 상관없이 들어가는 듯
            // Action대리자는 리턴값이 없는반면  Func는  리턴값이 있어야 해서(?) 이런거 같음, 생성자에서 인수로 안치는거 같음
        {
            Console.WriteLine("액션커맨드 호출");
            Console.WriteLine("test 호출 : " + test);
            Console.WriteLine("test2 호출 : " + test2);
        }

    }
    class ActionTest
    {
        // Action Test
        object test;
        object test2;
        public ActionTest()
        {
            test = new ActionCommand(new Action<string>(method));
            test2 = new ActionCommand(); // 기본생성자에 Func인수 넣으면 Func인수로 들어간 생성자 호출하고
                                        // 인수없는 기본생성자는 Func를 호출 안해줌
                                        // Action으로 바꾸면 Func랑은 다르게 인수 오류남
        }

        void method(string test)
        {
            Console.WriteLine("생성자 출력 : " + this.test);
            Console.WriteLine("메소드  매개변수 출력 : " + test);
        }

        void method2(string test)
        {
            Console.WriteLine("생성자 출력 : " + this.test);
            Console.WriteLine("메소드  매개변수 출력 : " + test);
        }
        static void Main(string[] args)
        {
            ActionTest test = new ActionTest();

            test.method("wow");
        
        }
    }
}
