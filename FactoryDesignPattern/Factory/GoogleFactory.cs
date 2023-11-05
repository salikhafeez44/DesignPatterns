using FactoryDesignPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Factory
{
    public class GoogleFactory : IPaymentFactory
    {
        public IPayment Process()
        {
            return new GooglePayment();
        }

    }
}
