using Decorator_Impl.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Impl.ConcreteComponent
{
    public class OppoPhone : Phone
    {
        public override void Show()
        {
            Console.WriteLine("Here is my Oppo !");
        }
    }
}
