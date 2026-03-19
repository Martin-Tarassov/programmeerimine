using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceAndServiceClass.Core.ServiceInterface;

namespace InheritanceAndServiceClass.AppService.Services
{

    public class CarServices : ICarServices
    {
        public void GetData()
        {
            Console.WriteLine("Car Services 123");
        }
        public void PostData()
        {
            Console.WriteLine("Salvestatud.");
        }

        public void PutData()
        {
            Console.WriteLine("Uuendatud.");
        }

        public void DeleteData()
        {
            Console.WriteLine("Kustutatud.");
        }
    }
}
