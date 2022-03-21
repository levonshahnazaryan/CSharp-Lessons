using System;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            Shose shose = new Shose(25000, 42);
            shose.GetPrice();
            shose.GetSize();
        }
    }
}