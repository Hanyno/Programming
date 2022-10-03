using System;

namespace Program
{
    internal class app
    {
        static void Main(string[] args)
        {
            ulong[] fib = new ulong[100];
            fib[0]=0;
            fib[1]=1;
            for (int i=2; i<100; i++)
            {
                fib[i] = fib[i-2] + fib[i-1];
                Console.WriteLine(fib[i]);
            }
            Console.ReadLine();
        }
    }
}
