using System;
using ClassLibrary1;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static void Main()
        {
            var a = new Class1();
            a.Initialize();
            Console.WriteLine("The property value is: " + a.Property1);
        }
    }
}