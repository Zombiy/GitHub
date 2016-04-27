using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            Salon salon = new Salon();
            Garage garage = new Garage(); 
            SimpleFactoryCreator creator = new SimpleFactoryCreator();
            Creator creatorAudi = creator.CreateCreator("Audi");
            salon.AddAuto(creatorAudi.CreateAuto());
            garage.AddAuto(creatorAudi.CreateAuto());

        }
    }
}
