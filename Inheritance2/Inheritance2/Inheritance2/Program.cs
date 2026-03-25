namespace Inheritance2
{
    internal class Program
    {
        static void Main()
        {

            //kui siin on Water class, siis kuvatakse seal olevat DoSomething meetodi sisu
            //kui panna Water water = new River();
            //meetodi sisuНА
            Water water = new Water();

            Water water2 = new River();

            Water water3 = new Lake();

            water.Flow = true;
            water.Length = "123";
            water2.Flow = false;
            water2.Length = "456";

            water3.Flow = false;
            water3.Length = "789";

            //kutsume soovitud meetodi esile
            water.DoSomething();
            water2.DoSomething();
            water3.DoSomething();
        }
    }
}
