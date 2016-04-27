using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class SimpleFactoryCreator
    {
        public Creator CreateCreator(string TypeCreator)
        {
            switch (TypeCreator)
            {
                case "Audi": return new CreatorAudi();
                case "BMW": return new CreatorBMW();
                case "Ferrari": return new CreatorFerrari();
                default:
                    return null;
            }

        }
    }
}
