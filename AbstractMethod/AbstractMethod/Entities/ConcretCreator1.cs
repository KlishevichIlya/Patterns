using AbstractMethod.Interfaces;

namespace AbstractMethod.Entities
{
    public class ConcretCreator1 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcretProduct1();
        }
    }
}
