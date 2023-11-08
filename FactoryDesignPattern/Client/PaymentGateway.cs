using FactoryDesignPattern.Factory;
using FactoryDesignPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Client
{
    public class PaymentGateway
    {
        public static IPaymentFactory GetPayment(PaymentMethod paymentMethod)
        {
            return paymentMethod switch
            {
                PaymentMethod.PayPal => new PayPalFactory(),
                PaymentMethod.CreditCard => new CreditCardFactory(),
                PaymentMethod.Google => new GoogleFactory(),
                _ => throw new NotImplementedException(),
            } ;
        }
    }
}
