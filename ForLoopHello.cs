namespace ForLoopHello
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            //teha konsoolirakendus,kus kasutad for loopi
            //kolm korda näidatakse Tere tulemast

            ushort Tere = 0;

            for (Tere = 0; Tere < 3; Tere++)
            {
                Console.WriteLine("Tere");
                if (Tere == 3)
                {
                    break;
                }
            }
        }
    }
}
