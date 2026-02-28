namespace ArayString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Massiiv");
            string sentence = "Euroopa üks pealinnadest on:";

            //näidate 1 tuple 
            Console.WriteLine("Tuple");
            var cities = Tuple.Create("Tallinn", "Pariis", "Rooma", "London", "Helsingi");
            Console.WriteLine(sentence + cities.Item4);
            Console.WriteLine("----------------------------");

            //näide 2 massiiv
            string[] city = { "Tallinn", "Pariis", "Rooma", "London", "Helsingi" };
            for (int i = 0; i < city.Length; i++)
            {
                Console.WriteLine(sentence + city[i]);
            }
            Console.WriteLine("----------------------------");

            //näide 3 
            Console.WriteLine(sentence + city[2]);
            Console.WriteLine("----------------------------");

            //näide 4
            Random number = new Random();
            int randomNumber = number.Next(0, 4);
            Console.WriteLine(sentence + city[randomNumber]);

        }
    }
}
