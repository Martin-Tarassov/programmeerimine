namespace SortedListAndTuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali meetod:");
            Console.WriteLine("1 - SortedList");
            Console.WriteLine("2 - Tuple");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    UseSortedList();
                    break;
                case 2:
                    UseTuple();
                    break;
                default:
                    Console.WriteLine("Vigane valik");
                    break;
            }
        }

        static void UseSortedList()
        {
            // sortedlist see on kollektsioon mis hoiab võti ja väärtus paare
            // ta sorteerib ise elemendid võtme järgi automaatselt
            // saab lisada uusi asju ja kustutada neid

            SortedList<int, string> cars = new SortedList<int, string>();
            cars.Add(3, "BMW");
            cars.Add(1, "Audi");
            cars.Add(2, "Mercedes");

            Console.WriteLine("SortedList (sorteeritud):");
            foreach (var car in cars)
            {
                Console.WriteLine(car.Key + " " + car.Value);
            }
        }

        static void UseTuple()
        {
            // tuple see on kui tahad panna mitu erinevat asja kokku ühte kohta
            // erinevus on see et tuple ei saa muuta peale kui tegid teda
            // aga sortedlist saab muuta ja lisada asju sinna

            var car = (Id: 1, Brand: "BMW", Year: 2022);

            Console.WriteLine("Tuple:");
            Console.WriteLine(car.Id + " " + car.Brand + " " + car.Year);
        }
    }
}
