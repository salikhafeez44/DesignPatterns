using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class ServiceProvider
    {
        private List<string> ServiceProviders = new();
        private int index = 0;

        public ServiceProvider()
        {
            ServiceProviders.Add("Tom");
            ServiceProviders.Add("Dan");
            ServiceProviders.Add("Tim");
            ServiceProviders.Add("Jim");
        }

        public string GetNextServiceProvider()
        {
            var result = ServiceProviders[index];
            index++;
            if (index >= ServiceProviders.Count)
            {
                index = 0;
            }
            return result;
        }
    }
}
