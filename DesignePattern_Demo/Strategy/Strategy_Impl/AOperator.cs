using Strategy_Impl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Impl
{
    public abstract class AOperator : IOperator
    {
        public string OperatorName { get; private set; }

        public AOperator(string operatorName)
        {
            OperatorName = operatorName;
        }

        protected abstract int Calculate(int firstParam, int secondParam);

        public string GetResult(string firstParam, string secondParam)
        {
            
            if (String.IsNullOrWhiteSpace(firstParam) || String.IsNullOrWhiteSpace(secondParam))
            {
                throw new ArgumentNullException("parameters is empty");
            }

            string result;
            if (int.TryParse(firstParam, out int param1) && int.TryParse(secondParam, out int param2))
            {
                result = Calculate(param1, param2).ToString();
            }
            else
            {
                throw new Exception("Operator error : parameter expected int");
            }
            return result;
        }
    }
}
