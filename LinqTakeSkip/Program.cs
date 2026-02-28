using System;
using System.Linq;
using System.Linq;
namespace LinqtakeSkip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali meetod: ");
            Console.WriteLine("1 - Skip");
            Console.WriteLine("2 - SkipWhile");
            Console.WriteLine("3 - TakeWhile");
            Console.WriteLine("4 - FirstOrDefault");
            Console.WriteLine("5 - AverageAge");
            Console.WriteLine("6 - CountLINQ");
            Console.WriteLine("7 - Sum");
            Console.WriteLine("8 - Max");
            Console.WriteLine("9 - MinLinq");


            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Skip();
                    break;

                case 2:
                    SkipWhile();
                    break;

                case 3:
                    TakeWhile();
                    break;

                case 4:
                    FirstOrDefault();
                    break;

                case 5:
                    Average();
                    break;

                case 6:
                    CountLINQ();
                    break;

                 case 7:
                    Sum();
                    break;

                    case 8:
                    Max();
                    break;

                    case 9:
                    MinLinq();
                    break;

                default:
                    Console.WriteLine("Vale Valik");
                    break;
            }
            //siin kasutada switchi ja peab saama Skip meetodit esile kutsuda
        }

        public static void Skip()
        {
            Console.WriteLine("------------Skip------------");
            //kasuta skip ja jäta kolm tükki vahele


            var skip = PeopleList.peoples.Skip(3);
            foreach (var item in skip)
            {
                Console.WriteLine(item.Name);
            }
        }
        //teete uue meetodi, aga kasutate SkipWhile ja vanemad, kui 18 peab olema tingimus
        public static void SkipWhile()
        {
            Console.WriteLine("------------SkipWhile------------");
            //mis tähendab: .See tähendab lambda märki ja selle 
            //abil saab kasutada pikem classi asemel lühendit
            //koos saab oleva muutujaga, mis antud juhul on x.
            var skipWhile = PeopleList.peoples
                .SkipWhile(x => x.Age <= 18);

            foreach (var item in skipWhile)
            {
                Console.WriteLine(item.Id + " - " + item.Name + " - " + item.Age);
            }
            // SkipWhile näitab isikuid kuni vastab tingimusele
            //e antud juhul näitab andmeid kuni leiab 18 a isiku ja
            //peale seda hakkab enam ei näitab andmeid     
        }

        //kasutada TakeWhile ja kutsuda see esile switchis
        //tingimus on Age > 18

        //vooskeem teha TakeWhile meetodist
        public static void TakeWhile()
        {
            Console.WriteLine("------------TakeWhile------------");

            var takeWhile = PeopleList.peoples
                .TakeWhile(x => x.Age > 18);

            foreach (var item in takeWhile)
            {
                Console.WriteLine(item.Id + " - " + item.Name + " - " + item.Age);
            }
        }
        public static void FirstOrDefault()
        {
            //peate kasutama Name ja Length-i. Nimi peab olema vahemalt 5
            //tähemärki pikk            
            Console.WriteLine("------------FirstOrDefault------------");
            string firstLongName = PeopleList.peoples
                .FirstOrDefault(x => x.Name.Length >= 5)?.Name;
            Console.WriteLine("The first long name is '{0}'.", firstLongName);

        }
        //kasutame Avarage Linq
        //muutujaks on Age
        public static void Average()
        {
            Console.WriteLine("------------Average------------");

            var average = PeopleList.peoples
                .Average(x => x.Age);

            Console.WriteLine("Avarage age on" + average);
        }
        public static void CountLINQ()
        {
            var totalPersons = PeopleList.peoples.Count();

            Console.WriteLine("Inimesi on kokku: " + totalPersons);
            Console.WriteLine("---------------------------------------");

            var adulPerson = PeopleList.peoples.Count(x => x.Age >= 18);
            Console.WriteLine("inimesi on kokku: " + adulPerson);
        }
        //kasutame summat e Sum
        public static void Sum()
        {
            var sumAge = PeopleList.peoples
                .Sum(x => x.Age);

            Console.WriteLine("--------------------------");
            Console.WriteLine("Täisealiste isikute koondarv");

            var sumAdults = 0;
            var numAdults = PeopleList.peoples.Sum(x =>
            {
                if (x.Age >= 18)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            });
            Console.WriteLine("Täiskasvanud isikute koondarv " + numAdults);
        }

        //kasutada Max
       
        
        public static void Max()
        {
           Console.WriteLine("------------Max------------");

           var oldestPerson = PeopleList.peoples
                .Max(x => x.Age);
           Console.WriteLine("Kõige vanem vanus on: " + oldestPerson);              
        }
        public static void MinLinq()
        {
            Console.WriteLine("------------Min------------");
            var minAge = PeopleList.peoples
                .Min(x => x.Age); Console.WriteLine(minAge);


        }
    }    
}

