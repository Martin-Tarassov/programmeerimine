namespace MethodCall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. For loop");
            Console.WriteLine("2. While loop");
            Console.WriteLine("3. Liitmine");
            Console.WriteLine("4. Vanus");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                ForLoop();
            }
            else if (choice == "2")
            {
                WhileLoop();
            }
            else if (choice == "3")
            {
                AddingNumbers();
            }
            else if (choice == "4")
            {
                AskAge();
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }

        static void ForLoop()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("For Hello");
            }
        }

        static void WhileLoop()
        {
            int number = 1;

            do
            {
                Console.WriteLine("While Hello");
                number++;
            }
            while (number == 2);
        }

        static void AddingNumbers()
        {
            Console.WriteLine("Sisesta esimene number");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta teine number");
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine("Vastus: " + (first + second));
        }

        static void AskAge()
        {
            Console.WriteLine("Sisesta enda vanus");
            string age = Console.ReadLine();
            Console.WriteLine("Sinu vanus on " + age);
        }
    }
}
