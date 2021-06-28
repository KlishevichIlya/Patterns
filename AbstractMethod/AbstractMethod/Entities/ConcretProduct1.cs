using AbstractMethod.Interfaces;

namespace AbstractMethod.Entities
{
    public class ConcretProduct1 : IProduct
    {
        public string Operation()
        {
            return "ConcretProduct 1";
        }
    }
}
