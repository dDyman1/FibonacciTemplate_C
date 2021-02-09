using System;

namespace Fibonacci
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(9));
        }

        public static int Fib(int val)
        {
            if (val > 1)
            {
                return Fib(val - 1) + Fib(val - 2);
            }
            return val;
        }
    }
}
