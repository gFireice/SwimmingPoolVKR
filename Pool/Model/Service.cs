﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Model
{
    public partial class Service
    {
        public int ServiceID { get; set; }

        public string Titel { get; set; }

        public decimal Cost { get; set; }

        public int TypeOfAgeID { get; set; }

        public string image { get; set; }
    }
}
