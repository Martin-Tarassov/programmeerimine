namespace FotLoopTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, rows;
            Console.Write("\n\n");
            Console.Write("Tärnidest tehtud kolmnurk e poolik püramiid:\n");
            Console.Write("------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Sisesta ridade arv : ");
            rows = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
