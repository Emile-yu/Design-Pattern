using Builder_Impl.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Impl.Builders
{
    public class HpBuilder : Builder
    {
        private readonly Compute _compute;

        public HpBuilder()
        {
            _compute = new Compute();
        }
        public override void BuilderCPU()
        {
            _compute.Add("HP i5-1150i");
        }

        public override void BuilderMainBorder()
        {
            _compute.Add("HP MainBorder");
        }

        public override Compute GetCompute()
        {
            return _compute;
        }
    }
}
