﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class CreatorBMW:Creator
    {
        override public Auto CreateAuto()
        {
          
            return new Auto_BMW();
        }
    }
}