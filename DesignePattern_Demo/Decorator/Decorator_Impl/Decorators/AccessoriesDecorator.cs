using Decorator_Impl.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Impl.Decorators
{
    public class AccessoriesDecorator : DecoratorPhone
    {
        public AccessoriesDecorator(Phone phone) : base(phone)
        {

        }

        public override void Show()
        {
            base.Show();

            Console.WriteLine("Add Accessories to my Oppo");
        }
    }
}
