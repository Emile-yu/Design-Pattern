﻿using Factory_Impl.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Impl.Factory
{
    public class BMWFactory : Factory
    {
        public override Car Create()
        {
            return new BMW();
        }
    }
}
