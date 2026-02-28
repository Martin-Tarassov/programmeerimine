namespace FoorLoopEndLess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Loop endless");

            //kasutame for loopi
            ushort i = 0;
            
            //kui on 10 rida konsoolis, siis lõpetab ära
            // VIHJE: kasutage break-i
            
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("rida" + (i + 1));
                if (i == 9)
                {
                 break;
                }

            }

        }
    }
}
