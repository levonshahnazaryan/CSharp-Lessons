using System;

namespace Lesson_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types
            bool isExists = false;
            Console.WriteLine(isExists);

            sbyte byNumber1 = 5;
            byte byNumber2 = 255;
            byte byResult = (byte)(byNumber2 / byNumber1);
            byte byResult2 = (byte)(byNumber1 / byNumber2);
            Console.WriteLine("byResult: {0}", byResult);
            Console.WriteLine("byResult2: {0}", byResult2);

            short shNumber1 = 29922;
            ushort shNumber2 = 25;
            ushort uShResult = (ushort)(shNumber1 * shNumber2);
            Console.WriteLine("uShResult: {0}", uShResult);

            int nextNumber = 25;
            int currentNumber = 99;
            uint uIntResult = (uint)(nextNumber - currentNumber);
            Console.WriteLine("UIntResult: {0}", uIntResult);

            ulong bigNumber2 = 250000;
            long bigResult = -(long)bigNumber2;
            Console.WriteLine("BigResult: {0}", bigResult);
        }
    }
}
