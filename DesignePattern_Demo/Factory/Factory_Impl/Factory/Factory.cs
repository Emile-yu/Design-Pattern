using Factory_Impl.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Impl.Factory
{
    public abstract class Factory
    {
        public abstract Car Create();
    }
}
