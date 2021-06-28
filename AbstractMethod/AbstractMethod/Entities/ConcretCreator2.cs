using AbstractMethod.Interfaces;

namespace AbstractMethod.Entities
{
    public class ConcretCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcretProduct2();
        }     
    }
}
