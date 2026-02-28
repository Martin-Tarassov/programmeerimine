namespace IfAndElseNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //muutuja nimega y on defineeritud
            double y;

            //anname y-le väärtuse
            y = 50;

            //sulgude sees olevat väärtust kontrollitakse,
            //et kas vastab tõele või mitte
            if (y < 20)
            {
                //kui panen if-i sisse if-i
                if (y == 11)
                {
                    Console.WriteLine("Vastus on 11");
                }
                else
                {
                    Console.WriteLine("Vastus oli 0 kuni 10 ja 12 kuni 19");
                }
            }
            else if (y == 20.5)
            {
                Console.WriteLine("Vastus on 20.5. Teine tingimus vastab tõele.");
            }
            else if (y == 30)
            {
                Console.WriteLine("Vastus on 30.");
            }
            else
            {
                Console.WriteLine("Mingi muu väärtus peale eelpool olevat");
            }

        }
    }
}
