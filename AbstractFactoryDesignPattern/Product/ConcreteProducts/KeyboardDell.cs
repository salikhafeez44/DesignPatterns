using AbstractFactoryDesignPattern.Product.IAbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Product.ConcreteProducts
{
    internal class KeyboardDell : IKeyboard
    {
        public string Keyboard()
        {
            return "This is Dell Keyboard";
        }
    }
}
