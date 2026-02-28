namespace SwitchRandomNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //genereerib iga kord suvalised numbrid

            //peate kasutama switchi, et igat numbrit näidata

            Random rmd = new Random();
            int numbrid = rmd.Next(0, 6);
            {
                switch (numbrid)
                {
                    case 0:
                        Console.WriteLine("Numbril on väärtus 0 ja sa oled lox");
                        break;

                    case 1:
                        Console.WriteLine("Numbril on väärtus 1 sa oled tubli");
                        break;

                    case 2:
                        Console.WriteLine("Numbril on väärtus 2 sa oled lox");
                        break;

                    case 3:
                        Console.WriteLine("Numbril on väärtus 3 sa oled lox");
                        break;

                    case 4:
                        Console.WriteLine("Numbril on väärtus 4");
                        break;

                    case 5:
                        Console.WriteLine("Numbril on väärtus 5");
                        break;

                    case 6:
                        Console.WriteLine("Numbril ob väärtus 6");
                        break;


                }   }
        }
    }
}
