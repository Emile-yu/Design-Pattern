using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Impl
{
    public class DivisionOperator : AOperator
    {
        public DivisionOperator() : base("/")
        {
        }

        protected override int Calculate(int firstParam, int secondParam)
        {
            if (secondParam == 0)
            {
                return 0;
            }
            return firstParam / secondParam;
        }
    }
}
