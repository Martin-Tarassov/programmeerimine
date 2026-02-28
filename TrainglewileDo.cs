namespace TrianglewiLeDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
           
            
            int n = int.Parse(Console.ReadLine());
            int i = 1;           
            
            //otsida internestist while koodiga kolmnurga kujundeid
            //kui kood on valmis ,siis teha vooskeem 
 
         while (i <= n)
         {
          Console.WriteLine();
          int j = 1;
          while (j <= i) 
          { 
             Console.Write("*" + " ");
                    j++;
          }
            i++;
            
         }
          Console.ReadKey();
           
        }
    }
}
