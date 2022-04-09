namespace Lesson_05.Helpers
{
    public class MyDelegate
    {
        public MainDelegate main;

        public string Method1(string str1, int num)
        {
            return $"A {str1} {num}";
        }
        public string Method2(string str1, int num)
        {
            return $"B {str1} {num}";
        }
        public string Method3(string str1, int num)
        {
            return $"C {str1} {num}";
        }
    }
}