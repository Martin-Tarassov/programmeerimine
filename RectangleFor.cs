using System.ComponentModel.Design;

namespace RectangleFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta ristiküliku külje mõõdud");

            Console.WriteLine("Pikkus");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("laius");
            double witdh = double.Parse(Console.ReadLine());

            //kasutada for loopi 
            //peab tuleb ristiküliku kujund

            for (int row = 1; row <= (int)length; row++)
            {
                for (int col = 1; col <= witdh; col++) 
                {
                    string mark;
                    if (row == 0 || row == (int)length &&  col == 0 || col == (int)witdh)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }

                    Console.Write(mark);

                }
                Console.WriteLine();


            }
        }
    }
}
