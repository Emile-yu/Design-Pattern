using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Impl
{
    public class SubstractionOprator : AOperator
    {
        public SubstractionOprator() : base("-")
        {

        }
        protected override int Calculate(int firstParam, int secondParam)
        {
            return firstParam - secondParam;
        }
    }
}
