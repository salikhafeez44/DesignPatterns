using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Product
{
    //Product
    public interface IPayment 
    {
        void Pay(double amount);
    }
}
