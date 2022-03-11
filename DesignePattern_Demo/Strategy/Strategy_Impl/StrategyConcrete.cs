using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Impl
{
    public class StrategyConcrete
    {
        private AOperator operatorConcrete;

        public StrategyConcrete(string operatorType)
        {
            Factory(operatorType);
        }

        private void Factory(string operatorType)
        {
            switch (operatorType)
            {
                case "+":
                    operatorConcrete = new AdditionOperator();
                    break;
                case "-":
                    operatorConcrete = new SubstractionOprator();
                    break;
                case "*":
                    operatorConcrete = new MultiplicationOperator();
                    break;
                case "/":
                    operatorConcrete = new DivisionOperator();
                    break;
            }
        }

        public string GetResult(string firstParam, string secondParam)
        {
            return operatorConcrete?.GetResult(firstParam, secondParam);
        }
    }
}
