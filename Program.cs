using System;

namespace FibonacciExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(number));
            Console.ReadKey();
        }

        static int Fib(int number)
        {
            if (number == 0 || number == 1)
            {
                return number;
            }
            else 
            {
                return (Fib(number - 1) + Fib(number - 2));
            }

        }
    }
}
