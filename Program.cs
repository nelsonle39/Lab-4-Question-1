using System;

namespace StringExtensions_Tester
{
    public class Program
    {
        static void Main(string[] args)
        {
            string testString = "Hello";
            Console.WriteLine($"{testString} starts with upper? {testString.StartsWithUpper()}");

            testString = "hello";
            Console.WriteLine($"{testString} starts with upper? {testString.StartsWithUpper()}");
        }
    }
}
