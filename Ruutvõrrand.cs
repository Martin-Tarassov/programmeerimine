namespace Ruutvõrrand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ruutvõrrand");


            //ax2 + bx + c

            //kasutaja peab sissestada väärtuseid a, b ja c

            Console.Write("Sisesta a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Sisesta b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Sisesta c: ");
            double c = double.Parse(Console.ReadLine());

            double d = b * b - 4 * a * c;

            Console.WriteLine($"x1 = {(-b + Math.Sqrt(d)) / (2 * a)}," +
               $"x2 = {(-b + Math.Sqrt(d)) / (2 * a)}");

        }
    }
}
