using System.Transactions;

namespace FibonacciFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci");

            int prv = 0, pre = 1, trm, i, n;

            Console.WriteLine("Sissesta number");

            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Siin on Fibonacci seeria kuni {0}: \n", n);
            
            Console.Write($"{0}  {1}", prv, pre);

            //kasutada for loopi, et teha algorütm

            for (i = 2; i < n; i++)
            {
                trm = prv + pre;
                Console.Write($"{trm} ");
                prv = pre;
                pre = trm;

            }
            Console.WriteLine();
        }
    }
}
