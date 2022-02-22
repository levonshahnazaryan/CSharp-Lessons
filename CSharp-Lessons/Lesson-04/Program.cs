using System;

namespace Lesson_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the http code");
            string httpCode = Console.ReadLine();
            switch (httpCode)
            {
                case "400":
                    Console.WriteLine("400 Bad Request");
                    break;
                case "401":
                    Console.WriteLine("401 Unauthorized");
                    break;
                case "402":
                    Console.WriteLine("402 Payment Required");
                    break;
                case "403":
                    Console.WriteLine("403 Forbidden");
                    break;
                case "404":
                    Console.WriteLine("404 Not Found");
                    break;
                case "405":
                    Console.WriteLine("405 Method Not Allowed");
                    break;
                case "406":
                    Console.WriteLine("406 Not Acceptable");
                    break;
                default:
                    Console.WriteLine("Not Found Error Code");
                    break;
            }
        }
    }
}
