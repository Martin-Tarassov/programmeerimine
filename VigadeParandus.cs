namespace VigadeParandus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("peab kasutama switchi");
            //teha switch, kus on kolm case valikut

            int choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1:
                UpsidePyramiid();
                break;

                case 2:
                Tagurpidi();
                break;

                case 3:
                Pyramid();
                break;

                default:
                Console.WriteLine("ei ole");
                break;
            }
            static void UpsidePyramiid()
            {  
                int i, j, n;

                n = Convert.ToInt32(Console.ReadLine());

                for (i = n - 0; i >= 1; i--)
                {
                    for (j = 1; j <= n - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            static void Tagurpidi()
            {
                Console.WriteLine("Sisesta pikkus");
                int length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sisesta laius");
                int width = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            static void Pyramid()
            {
                Console.WriteLine("Enter height");
                int n = Convert.ToInt32(Console.ReadLine());
                
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
