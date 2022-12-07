namespace FactoryPattern
{
    public class ProductABaseCreator : BaseCreator
    {
        internal override void ProductCreator()
        {
            IProduct t = CreateProduct();
            t.WriteMyName();
        }

        protected override IProduct CreateProduct()
        {
            return new ProductA();
        }
    }
}