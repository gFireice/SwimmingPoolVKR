﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Model
{
    public class Service
    {
        public int ServiceID { get; set; }

        public string Title { get; set; }

        public decimal Cost { get; set; }

        public int TypeOfAgeID { get; set; }
    }
}
