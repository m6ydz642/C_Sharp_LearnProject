using System;


namespace RambdaTest
{
   
    class RambdaTest
    {
       
        static void Main(string[] args)
        {
            Action Noreturn_lambda = () =>
            {
                Console.WriteLine("리턴할거 없고 매개변수 없는 람다식");
            };

            Action<string> Noreturn_lambda_parameter = (good) =>
            {
                Console.WriteLine("리턴할거 없고 매개변수 있는 람다식 : " + good);
            };

            Func<string,string> Noreturn_lambda_parameter2 = (good) =>
            {
                Console.WriteLine("리턴할거 있고 매개변수 있는 람다식 : " + good);
                return good;
            };

            Func<string> Noreturn_lambda_noparameter2 = () =>
            {
                Console.WriteLine("리턴할거 있고 매개변수 없는 람다식 : ");
                return "리턴했슈";
            };

            Noreturn_lambda();
            Noreturn_lambda_parameter("test");
           string returnLambda =  Noreturn_lambda_parameter2("test2");
           string returnLambda2 = Noreturn_lambda_noparameter2();
        }
    }
}
