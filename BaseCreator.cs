namespace FactoryPattern
{
    public abstract class BaseCreator
    {
        internal abstract void ProductCreator();

        protected abstract IProduct CreateProduct();
    }
}