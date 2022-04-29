using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        private static void rezabrabaa(int a, int b, int c)
        {
            List<int> list = new List<int> { a, b, c };
            print(list);
        }
        private static void print(List<int> array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
