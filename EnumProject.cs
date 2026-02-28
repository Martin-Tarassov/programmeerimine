namespace EnumProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enum");
            //kasutate enumit Weekdays jatahaks näha Reedet          
            Console.WriteLine((int)Weekdays.Friday);
            Console.WriteLine("-------------------------");

            //tehke uus enum Colors
            //(int) - castimne eteisendab teiseks anmdetüübiks
            //juhul kui info võib kduma minnaja ei näita soovitud tulemust
            Console.WriteLine((int)colors.Red);
            Console.WriteLine(colors.Red);
            
            //väärtused on
            //Red = 3
            //Green = 10
            //Blue = 13
            //Yellow = 5
            //Black = 1
            //White = 8
            //ühe värvi peab konsoolis ära näitama
        }
        enum Weekdays
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 0,
        }
        enum colors
        {
            Red = 3,
            Green = 10,
            Blue = 13,
            Yellow = 5,
            Black = 1,
            White = 8
        }
    }
}
