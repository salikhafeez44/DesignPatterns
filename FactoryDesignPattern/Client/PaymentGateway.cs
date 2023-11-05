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
        public static IPayment GetPayment(PaymentMethod paymentMethod)
        {
            return paymentMethod switch
            {
                PaymentMethod.PayPal => new PayPalPayment(),
                PaymentMethod.CreditCard => new CreditCardPayment(),
                PaymentMethod.Google => new GooglePayment(),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
