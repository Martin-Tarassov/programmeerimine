using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LinqAllAny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, LINQ");
            Console.WriteLine("AllLinq");
            Console.WriteLine("AnyLinq");
            Console.WriteLine("JoinLinq");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                AllLinq();
                break;

                case 2:
                AnyLinq();
                break;
                
                    case 3:
                    JoinLinq();
                    break;
                default:
                Console.WriteLine("ERROR");
                break;               
            }     
        }
        public static void AllLinq()
        {
            //kasutate All
            //kontrollite, kas on vanemaid, kui 12 ja nooremaid, kui 20
            Console.WriteLine("------------All------------");          
            bool result = StudentData.students
                .All(x => x.Age > 12 && x.Age < 20);

            Console.WriteLine(result);
        }
        //teeme uue meetodi nimega AnyLinq
        //kasutada Any
        //vastus on true
        //kasutada muutujat Age
        public static void AnyLinq()
        {
            Console.WriteLine("------------Any------------");
          
            bool result = StudentData.students
                .Any(x => x.Age > 12 && x.Age < 20);

            Console.WriteLine(result);
        }
    
        //teha meetod nimega JoinLinq
        //kasutada Join-i
        //
        public static void JoinLinq()
        {
            Console.WriteLine("------------Join------------");
            var result = StudentData.students
                .Join(StandartData.standarts, 
                student => student.StandartId, 
                standart => standart.StandartId, 
                (student, standart) => new 
                {
                  student.Name, Standart = standart.Name 
                }
                ); 
            
            foreach (var item in result)
            {
                Console.WriteLine(item.Name + " - " + item.Standart);
            }

        }
    
    }
}
