using System;

namespace RecursionExaption
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RecursionExaptionM(100);
            }
            catch (Exception ex)
            { 
                
            }
        }

        public static int RecursionExaptionM(int num)
        {
            try
            {
                if (num == 0)
                    throw new ApplicationException("Error");

                var ret = RecursionExaptionM(num - 1);
                return ret;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 1;
            }
        }
    }
}