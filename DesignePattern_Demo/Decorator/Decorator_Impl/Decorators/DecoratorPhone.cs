using Decorator_Impl.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Impl.Decorators
{
    public abstract class DecoratorPhone : Phone
    {
        private readonly Phone _phone;

        public DecoratorPhone(Phone phone)
        {
            _phone = phone;
        }

        public override void Show()
        {
            _phone?.Show();
        }
    }
}
