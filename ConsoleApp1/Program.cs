using System;

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
            int[] array = new int[3] { a, b, c };
            print(array);
        }
        private static void print(int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
