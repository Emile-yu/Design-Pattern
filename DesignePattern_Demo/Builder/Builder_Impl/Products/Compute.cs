using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Impl.Products
{
    public class Compute
    {
        private IList<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }
        
        public void Show()
        {
            Console.WriteLine("Start");
            foreach (string item in parts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Fin");
        }
    }
}
