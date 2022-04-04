using System;

namespace Lesson_04.Helpers
{
    public class OutRep
    {
        public double p = 0;

        public void RefMethod(ref double pi)
        {
            pi = 3.14;
        }
        public void OutMethod(out double pi, double r)
        {
            pi = 0;
            double a = pi;
            pi = r * 25;
            Console.WriteLine(pi);
        }
    }
}