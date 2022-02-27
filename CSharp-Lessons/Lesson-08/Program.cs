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
            
            //Task-04
            Console.Write("Please input a string: ");
            string spaceText = Console.ReadLine();
            WriteSpacesInText(spaceText);

            //Task-05
            WriteSumArray();

            //Task-06
            Console.Write("Enter a number: ");
            string sNum1 = Console.ReadLine();
            Console.Write("Enter another number: ");
            string sNum2 = Console.ReadLine();
            WriteSwapNumbers(sNum1, sNum2);

            //Task-07
            Console.Write("Input Base number: ");
            string exNum1 = Console.ReadLine();
            Console.Write("Input the Exponent: ");
            string exNum2 = Console.ReadLine();
            WriteExponentNumbers(exNum1, exNum2);

            //Task-08
            Console.Write("Input number of Fibonacci Series: ");
            string fbNum1 = Console.ReadLine();
            WriteFibonacciNumbers(fbNum1);

            //Task-09
            Console.Write("Input a number: ");
            string prNum1 = Console.ReadLine();
            WritePrimeNumbers(prNum1);

            //Task-10
            Console.Write("Enter a number: ");
            string siNum1 = Console.ReadLine();
            WriteSumIndividual(siNum1);

            //Array With Method Values
            string outPar1 = "";
            string text1 = "Method1";
            string outPar2 = "";
            string text2 = "Method2";
            string[] arr = new string[2] { Method1(text1, ref outPar1), Method2(text2, ref outPar2) };
            Console.WriteLine($"{outPar1}{arr[0]}");
            Console.WriteLine($"{outPar1}{arr[1]}");
        }

        #region Task-01
        public static void WelcomeUser()
        {
            Console.WriteLine("Welcome Friends!");
            Console.WriteLine("Have a nice day!");
        }
        #endregion
        #region Task-02
        public static void WriteUserName(string name)
        {
            Console.WriteLine($"Welcome friend {name}!");
            Console.WriteLine("Have a nice day!");
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
        #region Task-04
        public static void WriteSpacesInText(string text)
        {
            int spaceCount = text.Split(" ").Length - 1;
            Console.WriteLine($"{text}: {spaceCount}");
        }
        #endregion
        #region Task-05
        public static void WriteSumArray()
        {
            int[] array = new int[5] { 5, 7, 3, 2, 9 };
            int sumResult = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sumResult += array[i];
            }
            Console.WriteLine($"The sum of the elements of the array is {sumResult}");
        }
        #endregion
        #region Task-06
        public static void WriteSwapNumbers(string num1, string num2)
        {
            int.TryParse(num1, out int _num1);
            int.TryParse(num2, out int _num2);

            int otherNum = _num1;
            _num1 = _num2;
            _num2 = otherNum;

            Console.WriteLine($"Now the 1st number is: {_num1}, and the 2nd number is: {_num2}");
        }
        #endregion
        #region Task-07
        public static void WriteExponentNumbers(string num1, string num2)
        {
            double.TryParse(num1, out double _num1);
            double.TryParse(num2, out double _num2);
            double result = Math.Pow(_num1, _num2);
            Console.WriteLine($"So, the number {_num1}^(to the power){_num2} = {result}");
        }
        #endregion
        #region Task-08
        public static void WriteFibonacciNumbers(string series)
        {
            int.TryParse(series, out int _series);
            Console.Write($"The Fibonacci series of {_series} numbers is: ");

            int i = 0;
            int numF = 0;
            int numL = 1;
            while (i < _series)
            {
                Console.Write($"{numF} ");
                int num = numF + numL;
                numF = numL;
                numL = num;
                i++;
            }
        }
        #endregion
        #region Task-09
        public static void WritePrimeNumbers(string num1)
        {
            decimal.TryParse(num1, out decimal _num1);
            Console.WriteLine("The number {0} {1} prime", _num1, (_num1 % 2 == 0 ? "is" : "is not"));
        }
        #endregion
        #region Task-10
        public static void WriteSumIndividual(string num1)
        {
            int num = 0;
            for (int i = 0; i < num1.Length; i++)
            {
                int.TryParse(num1[i].ToString(), out int res);
                if (res > 0)
                    num += res;
            }
            Console.WriteLine($"The sum of the digits of the number {num1} is: {num}");
        }
        #endregion


        #region Array With Method Values
        public static string Method1(string text, ref string outPar)
        {
            outPar = "Method name is: ";
            return text;
        }
        public static string Method2(string text, ref string outPar)
        {
            outPar = "Method name is: ";
            return text;
        }
        #endregion
    }
}