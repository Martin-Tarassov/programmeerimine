namespace WhileNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //tuleb kasutada while ja omakoda while while sisse panna
            //while nesting
            //while kordab ennast 5 korda
            int input = int.Parse(Console.ReadLine());


            Console.WriteLine("While nesting");


            int a = 1;
            while (a <= 5)
            {
                int b = 1;
                while (b <= 5)
                {
                    Console.WriteLine(b + " ");
                    b++;
                }
                Console.WriteLine();
                a++;
            
            }

            

            
            

        }
    }
}
