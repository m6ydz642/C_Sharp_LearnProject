using System;


namespace StatementLambda
{

    delegate string Concatenate(string[] message);

    class MainApp
    {
        static void Main(string[] args)
        {
            Concatenate concat = (message) =>
            {
                string result = "";
                foreach (string s in message)
                {
                    result += s;
                    Console.WriteLine("익명함수 result내용 : " + result);
                    // 공백제거 예제인데 커맨드창에서 args로 받아서 하는거라 여기서는 안됨 ^^;;;;;;;;;;;;;;
                }
                return result;
            }; // 이놈의 콜론

            string[] messages = new string[3];

            messages[0] = "앙 기모띠 ";
            messages[1] = "앙 기모띠2 ";
            messages[2] = "앙 기모띠3 ";

            foreach (string a in messages)
            {
                Console.WriteLine("a내용 : " + a);
              
            }

            Console.WriteLine("concat 내용 : " + concat(messages));

        }

    }
 }

