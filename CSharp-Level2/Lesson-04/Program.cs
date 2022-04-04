using Lesson_04.Helpers;
using System;

namespace Lesson_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 4;
            //RefOutInRep.ConsRef(ref num);
            //RefOutInRep.ConsIn(in num);
            //RefOutInRep.ConsOut(out num);
            //Console.WriteLine(num);

            //string charik = "Hello Friend";
            //RefOutInRep.ConsHello(ref charik);
            //Console.WriteLine(charik);

            OutRep outRep = new();
            outRep.p = 0;
            outRep.RefMethod(ref outRep.p);
            outRep.OutMethod(out outRep.p, 5);
        }
    }
}