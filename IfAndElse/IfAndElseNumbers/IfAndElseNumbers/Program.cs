namespace IfAndElseNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta enda vanus");
            //konsoolis on ainult string andmetüüp
            //see tuleb muuta int-ks ja kasutada Convert.ToInt16
            //ise tuleb valmis teha
            //peab kasutama if ja else
            //kui vanust ei sisesta, siis tuleb vastus: ei sisestanud enda vanust

            string number = Console.ReadLine();
            //int numberInt = Convert.ToInt32(number);

            if (number != null && number != "")
            {
                Console.WriteLine("Sisestasid enda vanuse: " + number);
            }
            else
            {
                Console.WriteLine("Ei sisestanud enda vanust");
            }
        }
    }
}
