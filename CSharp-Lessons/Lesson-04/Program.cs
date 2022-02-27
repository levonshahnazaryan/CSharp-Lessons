using System;

namespace Lesson_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter the http code");
            //string httpCode = Console.ReadLine();
            //switch (httpCode)
            //{
            //    case "400":
            //        Console.WriteLine("400 Bad Request");
            //        break;
            //    case "401":
            //        Console.WriteLine("401 Unauthorized");
            //        break;
            //    case "402":
            //        Console.WriteLine("402 Payment Required");
            //        break;
            //    case "403":
            //        Console.WriteLine("403 Forbidden");
            //        break;
            //    case "404":
            //        Console.WriteLine("404 Not Found");
            //        break;
            //    case "405":
            //        Console.WriteLine("405 Method Not Allowed");
            //        break;
            //    case "406":
            //        Console.WriteLine("406 Not Acceptable");
            //        break;
            //    default:
            //        Console.WriteLine("Not Found Error Code");
            //        break;
            //}


            //Console.WriteLine("Please enter the number");
            //string num = Console.ReadLine();
            //int.TryParse(num, out int intNum);
            //if (intNum > 0)
            //{
            //    int firstintNum = intNum;
            //    int a = 0;
            //    int b = 1992;
            //    while (a < b)
            //    {
            //        if (intNum > 5)
            //            intNum = b;
            //        else if (intNum < a)
            //            intNum = a;

            //        if (firstintNum != intNum)
            //            break;
            //        a++;
            //    }
            //    Console.WriteLine($"Your {firstintNum} number between in {0} and {b}");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong number");
            //}

            //int j = 1;
            //for (int i = 1; i <= 9; i++)
            //{
            //    Console.WriteLine($"{j} x {i} = {j * i}");
            //    if (i == 9)
            //    {
            //        j++;
            //        i = 0;
            //    }
            //    if (j == 10)
            //        break;
            //}

            //double a = 1;
            //for (int i = 100; i < 1000; i++)
            //{
            //    if (i % 3 == 1 && i % 4 == 2)
            //    {
            //        a *= i;
            //    }
            //}

            //Console.WriteLine(a);


            string[] aaa = new string[4] { "1235", "46462", "346464", "422" };
            var xxx = aaa.GetValue(0);

            int ccc = aaa.GetLength(0);


            //jegget array

        }
    }
}