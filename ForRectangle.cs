namespace ForRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Ristkülik");

          //teha for loopiga ristkülik                              
          int a = 8, b = 16;
          for (int i = 0; i < a; i++)
          {
            for (int size = 0; size < b; size++) 
            Console.Write("* ");
            Console.WriteLine();
          }
            //thea kalkulatsioon, kus arvutatakse pindala ja ümbermööt
            
            
           int laius = 67, korgus = 90;
           int S = laius * korgus;
           int P = 2 * (laius + korgus);
           Console.WriteLine("S: " + S);
           Console.WriteLine("P: " + P);
            
        


        }
    }
}

