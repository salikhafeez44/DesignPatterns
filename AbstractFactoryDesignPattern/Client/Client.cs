using AbstractFactoryDesignPattern.Factory.ConcreteFactories;
using AbstractFactoryDesignPattern.Factory.IAbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Client
{
    internal class Client
    {
        public static void NewFactory(IFactory factory)
        {
            var keyboard = factory.Create1().Keyboard();
            var monitor = factory.Create2().Monitor();

            Console.WriteLine($"{keyboard}");
            Console.WriteLine($"{monitor}");
        }
        
    }
}
