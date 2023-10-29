using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public sealed class AddSingleton<T> where T : class
    {
        private static readonly Lazy<T> _instance = new Lazy<T>();
        private AddSingleton() { }
        public static T GetInstance => _instance.Value;
    }
}
