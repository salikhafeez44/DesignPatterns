﻿using AbstractFactoryDesignPattern.Product.IAbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Product.ConcreteProducts
{
    internal class MonitorDell : IMonitor
    {
        public string Monitor()
        {
            return "This is Dell Monitor";
        }
    }
}
