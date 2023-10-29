using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public interface ILaptop<T>
    {
        T? OperatingSystem();
        T? CentralProcessingUnit();
        T? GraphicsCard();
        T? Memory();
        T? Storage();
        T? Display() ;
        T? Keyboard();
        T? Ports();
        T? AudioSpeakers();
        T? Camera();
        T? PrimaryBattery();
        T? Case();
    }
}
