using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    internal class Lake : Water
    {
        //tehke sama asi, mis River-ga ja kutsuge see Program classi Main meetodis esile
        public override void DoSomething()
        {

            //WaterProp waterProp = new WaterProp();
            //Water classis on olemas muutujad Flow ja Lenght ja sellepärast ei pea neid siin uuesti defineerima
            Console.WriteLine(" This lake method and it has " + Flow + " is and " + Length + " is in meters");
        }
    }
}
