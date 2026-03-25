using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    //River on antud juhul alamklass ja viitab Waterile e peamisele classile
    internal class River : Water
    {

        //kui kirjutan override, siis kirjutab Water meetodis oleva DoSomething meetodi üle
        //kui panen siia public virtual void, siis ei kirjuta Water meetodi DoSomething-t üle
        public override void DoSomething()
        {

            //WaterProp waterProp = new WaterProp();
            //Water classis on olemas muutujad Flow ja Lenght ja sellepärast ei pea neid siin uuesti defineerima
            Console.WriteLine(" This river method and it has " + Flow + " is and " + Length + " is in meters");
        }
    }
}
