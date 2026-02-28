
namespace FSÖFA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 Tagurpidi");
            Console.WriteLine("2 ristküliku");
            Console.WriteLine("3 ruutvõrrandi");

            int choice = int.Parse(Console.ReadLine());
            
            switch (choice) 
            {
              case 1:
              Tagurpidi();
              break;
             
              case 2:
              ristküliku();
              break;
                                        
              case 3:
              ruutvõrrandi();
              break;
            }

        }





        static void Tagurpidi()
        {
            Console.WriteLine("cm");
            if (!int.TryParse(Console.ReadLine(), out int h) || h <= 0)
            {
                Console.WriteLine();
                return;
            }
            for (int i = h; i >= 1; i--) 
            {
                for (int j = 0; j < i; j++)
                Console.Write("* ");
                Console.WriteLine();
            }

        }
        static void ristküliku()
        {
            Console.WriteLine("võtate kõrgus");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("võtate laius");
            int b = int.Parse(Console.ReadLine());

            for (int i = 0; i < b; i++) 
            {
                for (int j = 0; j < a; j++)
                Console.Write("* ");
                Console.WriteLine();
            
            }

        }
        static void ruutvõrrandi()
        {
            Console.WriteLine("võttate a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("võttate b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("võttate c: ");
            double c = double.Parse(Console.ReadLine());

            double D = b * b - 4 * a * c;

            Console.WriteLine("Diskriminant D" + D);
        }



    }
}
