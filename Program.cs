using LeetCode;
using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of MyClass
            LeetCodeClass leetCodeClass = new LeetCodeClass();

            // Call the methods
            //string rev = leetCodeClass.revertNumber(-1234);

            int result = leetCodeClass.RomanToInt("MCMXCIV");
            Console.WriteLine(result);
        }
    }
}