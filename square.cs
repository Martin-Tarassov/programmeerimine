namespace square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sissesta ruudu suurus");
            //tärnidega (*) teha for loopiga ruut
            
            int size = int.Parse(Console.ReadLine());

            
            
            
            for (int T = 2; T < size; T++)
            {
                for (int v = 2; v < size; v++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
 
            }
            //kui suurus on sisestatud, siis kuvab meile ümbermõõdu ja pidala
           Console.WriteLine("\n");
            int area = size * size;
            int circumreference = 4 * size;
            Console.WriteLine("Pindala on" + area);
            Console.WriteLine("Ümbermõõt on" + circumreference);


        }
    }
}
