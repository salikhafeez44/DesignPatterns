using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class Director
    {
        public static void Inspiron15LaptopByDell()
        {
            Console.WriteLine("Technical Specification for Inspiron15");
            BuilderDell? dellLaptop = new BuilderDell()?
                .OperatingSystem()?
                .CentralProcessingUnit()?
                .Memory()?
                .Storage()?
                .Display()?
                .GraphicsCard()?
                .PrimaryBattery()?
                .Keyboard()?
                .Power()?
                .Ports()?
                .Camera()?
                .Case()?
                .AudioSpeakers()?
                .MicrosoftOffice()?
                .Build();
        }
        
        public static void HPChromebook15ana0047nr()
        {
            Console.WriteLine("Technical Specification for HPChromebook15ana0047nr");
            BuilderHP? hpLaptop = new BuilderHP()?
                .OperatingSystem()?
                .CentralProcessingUnit()?
                .Memory()?
                .Storage()?
                .Display()?
                .GraphicsCard()?
                .PrimaryBattery()?
                .Keyboard()?
                .Ports()?
                .Camera()?
                .Case()?
                .AudioSpeakers()?
                .Build();
        }
    }
}
