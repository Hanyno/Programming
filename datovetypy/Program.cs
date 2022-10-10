using System;

namespace Program
{
    internal class app
    {
        static void Main(string[] args)
        {
            //Fibonnaciho posloupnost

            //ulong[] fib = new ulong[100];         //vytvoření polí s indexem 0 až 99
            //fib[0]=0;                             //definice pole s indexem 0
            //fib[1]=1;                             //definice pole s indexem 1
            //for (int i=2; i<100; i++)
            //{
            //    fib[i] = fib[i-2] + fib[i-1];
            //    Console.WriteLine(fib[i]);
            //}
            
            //operátory % (dělení se zbytkem), / dělní bezezbytku, +- sčítání odčítání

            //int a = 5;
            //int b = 2;
            //a %=b;
            
            //Console.WriteLine("a=" + a);
            //Console.WriteLine("b=" + b);

            //int c = 5;
            //int d = 2;
            //c /=d;
            //Console.WriteLine("c=" + c);
            //Console.WriteLine("d=" + d);
            
            //operátor negace ! (jenom pro boolean)

            //bool x = true;
            //Console.WriteLine(!x);

            //Console.WriteLine("5" + "5");
            int a = 2147483647, b = 5;
            int vysledek = a + b;
            Console.WriteLine(vysledek);
            Console.ReadKey();
        }
    }
}
