﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26158.Model
{
    public interface IProduct
    {
        int Id { get; }
        int Price { get; set; }
    }
}
