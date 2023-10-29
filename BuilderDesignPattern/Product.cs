using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class Product
    {
        List<object> productPeripherals = new();

        public void Add(object device)
        {
            productPeripherals.Add(device);
        }

        public void Remove(object device)
        {
            productPeripherals.Remove(device);
        }

        public void Clear()
        {
            productPeripherals.Clear();
        }

        public List<object> GetProduct()
        {
            return productPeripherals;
        }
    }
}
