using System;

namespace FactoryPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BaseCreator productA = new ProductABaseCreator();
            BaseCreator productB = new ProductBBaseCreator();

            productA.ProductCreator();
            Console.WriteLine("----------------");
            productB.ProductCreator();
        }
    }
}