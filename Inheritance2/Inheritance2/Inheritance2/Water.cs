using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Water
    {
        public bool Flow;
        public string Length;

        //siin on DoSomething meetod, mida siis viidatakse River classi all.
        //see võib olla virtual ja ei pea panema override kuna teda kirjutatakse üle

        public virtual void DoSomething()
        {
            Console.WriteLine("Do Something method");
        }
    }
  

}
