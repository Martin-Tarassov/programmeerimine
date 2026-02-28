namespace ForLoopPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;            
            
            Console.Write("Loo püramiid tärnidest:\n");
            Console.Write("-----------------------");
            
            Console.Write("\n\n");
            Console.Write("Sisesta püramiidi suurus");
            n = Convert.ToInt32(Console.ReadLine());
            
          for (i = 0; i <= n; i++)
          {
            for (j = 1; j <= n - i; j++)
            {
                Console.WriteLine(" ");
            }
            for (j = 1; j <= n * i - 1; ++j)
            {
              Console.WriteLine("*");
            }
            
                Console.WriteLine("\n");





          }

            for (i = 0; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.WriteLine(" ");
                }
                for (j = 1; j <= n * i - 1; ++j)
                {
                    Console.WriteLine(" * ");
                }
                Console.WriteLine("\n");





            }














        }
    }
}
