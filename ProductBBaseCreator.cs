namespace FactoryPattern
{
    public class ProductBBaseCreator : BaseCreator
    {
        internal override void ProductCreator()
        {
            IProduct t = CreateProduct();
            t.WriteMyName();
        }

        protected override IProduct CreateProduct()
        {
            return new ProductB();
        }
    }
}