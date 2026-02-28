namespace SwichTryCatch
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("try catch koos Switch-ga");

            //alguses teha switch kus saab sisestada numbreid 1 ja 2

            try
            {



                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("see on 1");
                        break;

                    case 2:
                        Console.WriteLine("see on 2");
                        break;

                    default:
                        Console.WriteLine("only 1 and 2");
                        break;
                }
            }



            catch (FormatException)
            {
                Console.WriteLine("Palun sissesta kehtiv number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("liiga suur või väike number");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Tekkis ootamatu viga");
            }
             
        }
    }    
}   

           
            