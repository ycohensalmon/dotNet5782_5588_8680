﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlApi
{
    public static class BlFactory
    {
        /// <summary>
        /// Returns instance of bl
        /// </summary>
        public static IBL GetBl() => BL.BL.Instance;
    }
}


