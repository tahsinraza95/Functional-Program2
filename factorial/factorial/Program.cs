using System;

namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number for factorial");
            int n = int.Parse(Console.ReadLine());
            int value = 1;
            while (n>0)
            {
                value = value * n;
                n--;
            }
            Console.WriteLine(value);
        }
    }
}
