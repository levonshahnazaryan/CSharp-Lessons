using Lesson_05.Helpers;

namespace Lesson_05
{
    public delegate string MainDelegate(string a, int b);
    class Program
    {

        static void Main(string[] args)
        {
            MyDelegate ob = new();
            ob.main = new MainDelegate(ob.Method1);
            ob.main += ob.Method2;
            ob.main += ob.Method3;
            var xxx = ob.main("AAAAAAA", 1);
        }
    }
}




//Func()
//Predicate
//Action


//Event create