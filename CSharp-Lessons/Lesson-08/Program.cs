using System;

namespace Lesson_08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task-01
            WelcomeUser();

            //Task-02
            Console.Write("Please input a name: ");
            string name = Console.ReadLine();
            WriteUserName(name);

            //Task-03
            Console.Write("Enter a number: ");
            string num1 = Console.ReadLine();
            Console.Write("Enter another number: ");
            string num2 = Console.ReadLine();
            WriteSumTwoNumbers(num1, num2);
        }

        #region Task-01
        public static void WelcomeUser()
        {
            Console.WriteLine("Welcome Friends!");
            Console.WriteLine("Have a nice day!\n");
        }
        #endregion
        #region Task-02
        public static void WriteUserName(string name)
        {
            Console.WriteLine($"Welcome friend {name}!");
            Console.WriteLine("Have a nice day!\n");
        }
        #endregion
        #region Task-03
        public static void WriteSumTwoNumbers(string num1, string num2)
        {
            int.TryParse(num1, out int _num1);
            int.TryParse(num2, out int _num2);
            Console.WriteLine($"The sum of two numbers is: {_num1 + _num2}");
        }
        #endregion

    }
}