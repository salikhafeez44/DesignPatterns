using AbstractFactoryDesignPattern.Factory.IAbstractFactory;
using AbstractFactoryDesignPattern.Product.ConcreteProducts;
using AbstractFactoryDesignPattern.Product.IAbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Factory.ConcreteFactories
{
    internal class FactoryHP : IFactory
    {
        public IKeyboard Create1()
        {
            return new KeyboardHP();
        }

        public IMonitor Create2()
        {
            return new MonitorHP();
        }
    }
}
