﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26131_library
{
    public class Korona: IProduct
    {
        public int Id { get { return 1; } }
        public int Price { get { return 30; } }
        public Chocolate Category { get { return Chocolate.Korona; } }
    }
}
