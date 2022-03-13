using Factory_Impl.Factory;
using Factory_Impl.Product;
using System;

namespace Factory_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory bmwFactory = new BMWFactory();
            Factory qqFactory = new QQFactory();

            Car bmw = bmwFactory.Create();
            bmw.Show();
            Car qq = qqFactory.Create();
            qq.Show();

            Console.ReadLine();
        }
    }
}
