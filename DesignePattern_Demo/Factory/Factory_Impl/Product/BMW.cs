using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Impl.Product
{
    public class BMW : Car
    {
        public override void Show()
        {
            Console.WriteLine("This is BMW");
        }
    }
}
