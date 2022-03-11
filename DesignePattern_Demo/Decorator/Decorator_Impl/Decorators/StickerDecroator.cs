using Decorator_Impl.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Impl.Decorators
{
    public class StickerDecroator : DecoratorPhone
    {
        public StickerDecroator(Phone phone) : base(phone)
        {
        }

        public override void Show()
        {
            base.Show();

            Console.WriteLine("Sticker my Oppo");
        }
    }
}
