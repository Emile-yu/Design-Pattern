using Builder_Impl.Builders;
using Builder_Impl.Director;
using Builder_Impl.Products;
using System;

namespace Builder_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            DellBuilder dellBuilder = new DellBuilder();
            HpBuilder hpBuilder = new HpBuilder();

            director.Build(dellBuilder);

            Compute compute = dellBuilder.GetCompute();

            compute.Show();

            Console.ReadLine();
        }
    }
}
