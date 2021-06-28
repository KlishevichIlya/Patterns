using AbstractMethod.Interfaces;

namespace AbstractMethod.Entities
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string SomeWork()
        {
            var product = FactoryMethod();
            var result = "Creator. We work with:" + product.Operation();
            return result;
        }
    }
}
