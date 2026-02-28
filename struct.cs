
using System.Security.Cryptography.X509Certificates;

namespace StructProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Struct");

            Console.WriteLine("--------------------------------------------");

            Coordinate point = new Coordinate(10, 35);
           
            Console.WriteLine(point.X);
            Console.WriteLine(point.Y);

            Console.WriteLine("--------------------------------------------");

            IntAndString IntAndString = new IntAndString("Mees", 89);
            Console.WriteLine(IntAndString.Name);
            Console.WriteLine(IntAndString.Age);

            Console.WriteLine("--------------------------------------------");
            InsertedIntAndString insertedIntAndString = new InsertedIntAndString("Tallinn", 4747780);
            Console.WriteLine(insertedIntAndString.PostalCode);
            Console.WriteLine(insertedIntAndString.City);           
        }
    }
    //Mis on struct ??
    //"see on väärtustüüp (value type),mis sarnaneb klassile
    struct Coordinate
    {
        public int X;
        public int Y;

        //teha konstrktor 

        public Coordinate(int x, int y) 
        {                  
            X = x;
            Y = y;
        }
    }
    //teha struct nimega IntAndString
    //string Name ja int on Age
    //kutsuda see struct Main-s välja
    struct IntAndString
    {       
        public string Name;
        public int Age;

        public IntAndString(string name, int age)
        {
            Name = name;
            Age = age;
        }
    
    
    
    }
    //teha struct nimega InsertedIntAndString
    //string City ja int on PostalCode
    //kutsuda see struct Main-s välja
    //structi sees tuleb sellele andajjuba väärtus

    struct InsertedIntAndString
    {
        public string City;
        public int PostalCode;

        public InsertedIntAndString(string city, int postalCode)
        {
            City = city;
            PostalCode = postalCode;
        }
    }
}


