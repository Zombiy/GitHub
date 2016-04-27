using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class AutoRepair
    {
        public List<Auto> ListOfAuto { get; set; }
        public void AddAuto(Auto a)
        {
            ListOfAuto.Add(a);
        }
    }
}
