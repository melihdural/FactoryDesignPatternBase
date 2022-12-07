using System;
using System.Diagnostics;

namespace FactoryPattern
{
    public class ProductA : IProduct
    {
        public void WriteMyName()
        {
            Console.WriteLine("ProductA");
        }
    }
}