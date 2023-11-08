using AbstractFactoryDesignPattern.Product.IAbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Factory.IAbstractFactory
{
    internal interface IFactory
    {
        IKeyboard Create1();
        IMonitor Create2();
    }
}
