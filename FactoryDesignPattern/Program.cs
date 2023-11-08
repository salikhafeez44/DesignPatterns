using FactoryDesignPattern;
using FactoryDesignPattern.Client;
using FactoryDesignPattern.Factory;
using FactoryDesignPattern.Product;

var payment1 = PaymentGateway.GetPayment(PaymentMethod.CreditCard);
payment1.Process().Pay(1000.00);

var payment2 = PaymentGateway.GetPayment(PaymentMethod.PayPal);
payment2.Process().Pay(1500.00);

var payment3 = PaymentGateway.GetPayment(PaymentMethod.Google);
payment3.Process().Pay(3000.00);
