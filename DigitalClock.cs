namespace DigitalClock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Console.Title = "Digital Clock";
            //Console.CursorVisible = false;


            //while (true)
            //{
            //Console.Clear();
            //Console.WriteLine("Digital Clock\n");          
            //Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));            
            //Thread.Sleep(1000);
            //}

            //ts[kkel]
            // while (true)
            {
                //puhastab konsooli
                // Console.Clear();
                //saab praeguse aja formaadis tund:minut:sekund
                // string time = DateTime.Now.ToString("HH:mm:ss");
                //arvutab horisontaalse nihe tsentreerimiseks
                // int x = (Console.WindowWidth  - time.Length) / 2;
                //arvutab vertikaalse nihe tsentreerimiseks
                //int y = Console.WindowHeight / 2;
                //positsioneerib kursor ekraani keskele         
                //Console.SetCursorPosition(x, y);
                //kuvab aja keskele
                //Console.Write(time);
                //peatab täitmise 1 sekundiks
                //Thread.Sleep(1000);
                //ootab 1 sekundit
            }
            //for loopiga teha digitaalne kell

            Console.Title = "Digital Clock";
            Console.CursorVisible = false;

            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("Digital Clock\n");
                string time = DateTime.Now.ToString("HH:mm:ss");
                int x = (Console.WindowWidth - time.Length) / 2;
                int y = Console.WindowHeight / 2;
                Console.SetCursorPosition(x, y);
                Console.Write(time);
                Thread.Sleep(1000);
            }
        }
    }
}
        
    

