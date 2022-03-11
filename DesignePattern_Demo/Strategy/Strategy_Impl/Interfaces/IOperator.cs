using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Impl.Interfaces
{
    public interface IOperator
    {
        string GetResult(string firstParam, string secondParam);
    }
}
