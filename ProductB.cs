using System;

namespace FactoryPattern
{
    public class ProductB : IProduct
    {
        public void WriteMyName()
        {
            Console.WriteLine("ProductB");
        }
    }
}