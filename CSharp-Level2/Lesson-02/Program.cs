using System;

namespace Lesson_02
{
    class Program
    {
        static void Main(string[] args)
        {
            IBaseClass baseClass = new BaseClass();
            var array = baseClass.GetArray();
            baseClass.AddArray("CurrYear", DateTime.Now);
            baseClass.EditArray("Salary", 3500000);
            baseClass.DeleteArray("Age");
        }
    }
}