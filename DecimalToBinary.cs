
namespace DecimalToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decimal to binary");

            Console.WriteLine("Sissesta number");
            int num = Convert.ToInt32(Console.ReadLine());
            string binaryNumber = "";

            //te peate kasutama while
            //kümnendarvud tuleb binaararvudeks teisendada
           
            while (num > 0) 
            {
                int remainder = num % 2;
                binaryNumber = remainder + binaryNumber;
                num /= 2;
            }
            Console.WriteLine(binaryNumber);
        }
    }
}
