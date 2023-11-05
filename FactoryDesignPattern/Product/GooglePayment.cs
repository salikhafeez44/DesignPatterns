using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Product
{
    public class GooglePayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Successfully paid ${amount} to merchant using Google payment! ");
        }
    }
}
