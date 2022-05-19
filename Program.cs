using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            int number = 123;
            double dnumber = 12.5D;
            char cname = 'a';
            bool boolean = true;
            Console.WriteLine($"This line is pretty much print/println in other languages");
            Console.WriteLine($"{number + number}, {dnumber + number}, {dnumber}, {name}, {cname}, {name + cname}, {boolean}");
        }
    }
}
