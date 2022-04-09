using System;

namespace MoveFile
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.Directory.Move(@"This PC\Apple iPhone\Internal Storage\", @"C:\IPhoneImages");
        }
    }
}
