using Builder_Impl.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Impl.Builders
{
    public class DellBuilder : Builder
    {
        private readonly Compute _compute;

        public DellBuilder()
        {
            _compute = new Compute();
        }
        public override void BuilderCPU()
        {
            _compute.Add("Dell i7-1150");
        }

        public override void BuilderMainBorder()
        {
            _compute.Add("Dell Border");
        }

        public override Compute GetCompute()
        {
            return _compute;
        }
    }
}
