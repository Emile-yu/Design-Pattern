using Builder_Impl.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Impl.Builders
{
    public abstract class Builder
    {
        public abstract void BuilderCPU();

        public abstract void BuilderMainBorder();

        public abstract Compute GetCompute();
    }
}
