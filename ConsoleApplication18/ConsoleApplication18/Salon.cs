using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Salon
    {
        public List<Auto> ListOfAuto { get; set; }
        public void AddAuto(Auto a)
        {
            ListOfAuto.Add(a);
        }
    }
}
