using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod.Entities
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            ClientCode(new ConcretCreator1());

            Console.WriteLine("");
            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            ClientCode(new ConcretCreator2());
        }

        public void ClientCode(Creator creator)
        {
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + creator.SomeWork());
        }
    }
}
