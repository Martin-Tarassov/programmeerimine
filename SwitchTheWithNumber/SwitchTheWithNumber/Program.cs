namespace SwitchTheWithNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Teie töö on teha switch rakendus
           //kus on kolm case (1,2,3)
           //Iga case puhul teeb erinev arv beep-e
            Console.WriteLine("Sisesta number 1, 2 või 3");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1"
                    Console.Beep(1000,500);
                    Console.Beep(1000, 500);
                    Console.WriteLine("Üks beep tehtud.");
                    break;
                    
                case "2":
                    Console.Beep(1000,500);
                    Console.Beep(1000, 500);
                    Console.Beep(1000, 500);
                    Console.WriteLine("Kaks beep tehtud");
                    break;
                    
                case "3":
                    Console.Beep(1000, 500);
                    Console.Beep(1000, 500);
                    Console.Beep(1000, 500);
                    Console.Beep(1000, 500);
                    Console.WriteLine("Kolm beep tehtud");
                    break;
                    
                default:
                    Console.WriteLine("Valve number");
                    break ;

            }
        }
    }
}
