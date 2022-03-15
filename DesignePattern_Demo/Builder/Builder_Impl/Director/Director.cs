using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder_Impl.Builders;

namespace Builder_Impl.Director
{
    public class Director
    {
        public void Build(Builder builder)
        {
            builder.BuilderCPU();
            builder.BuilderMainBorder();
        }
    }
}
