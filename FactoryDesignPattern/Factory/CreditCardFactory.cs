using FactoryDesignPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Factory
{
    public class CreditCardFactory : IPaymentFactory
    {
        public IPayment Process()
        {
            return new CreditCardPayment();
        }
    }
}
