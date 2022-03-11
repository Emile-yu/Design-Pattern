using Decorator_Impl.Component;
using Decorator_Impl.ConcreteComponent;
using Decorator_Impl.Decorators;
using System;

namespace Decorator_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone oppo = new OppoPhone();

            StickerDecroator stickerDecroator = new StickerDecroator(oppo);

            AccessoriesDecorator accessoriesDecorator = new AccessoriesDecorator(stickerDecroator);

            accessoriesDecorator.Show();

            Console.ReadLine();
        }
    }
}
