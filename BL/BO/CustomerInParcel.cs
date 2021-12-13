﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    namespace BO
    {
        public class CustomerInParcel
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                string sp = "   ";
                return ($"{sp}Id: {Id}\n{sp}Name: {Name}");
            }
        }
    }
}
