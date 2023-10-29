using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class BuilderDell : ILaptop<BuilderDell>
    {
        private Product? laptopProduct;
        public BuilderDell()
        {
            laptopProduct = new Product();
        }

        public BuilderDell? AudioSpeakers()
        {
            laptopProduct?.Add("AudioSpeakers:  Stereo speakers, 2 W x 2 = 4W total");
            return this;
        }
        public BuilderDell? Camera()
        {
            laptopProduct?.Add("Camera:  Plastic 720p at 30 fps HD camera Single integrated microphone");
            return this;
        }

        public BuilderDell? Case()
        {
            laptopProduct?.Add("Case:  Carbon Black");
            return this;
        }

        public BuilderDell? CentralProcessingUnit()
        {
            laptopProduct?.Add("CPU:  12th Gen Intel® Core™ i3-1215U (10 MB cache, 6 cores, 8 threads, up to 4.40 GHz Turbo)");
            return this;
        }

        public BuilderDell? Display()
        {
            laptopProduct?.Add("Display:  15.6\", FHD 1920x1080, 120Hz, WVA, Non-Touch, Anti-Glare, 250 nit, Narrow Border, LED-Backlit");
            return this;
        }

        public BuilderDell? GraphicsCard()
        {
            laptopProduct?.Add("GraphicsCard:  Intel® UHD Graphics");
            return this;
        }

        public BuilderDell? Keyboard()
        {
            laptopProduct?.Add("Keyboard:  English US non-backlit keyboard");
            return this;
        }

        public BuilderDell? Memory()
        {
            laptopProduct?.Add("Memory:  8 GB: 1 x 8 GB, DDR4, 2666 MT/s");
            return this;
        }

        public BuilderDell? OperatingSystem()
        {
            laptopProduct?.Add("OS:  Windows 11 Home");
            return this;
        }

        public BuilderDell? Ports()
        {
            laptopProduct?.Add("Ports:  1 USB 3.2 Gen 1 || 1 USB 3.2 Gen 1 port");
            return this;
        }

        public BuilderDell? PrimaryBattery()
        {
            laptopProduct?.Add("PrimaryBattery:  3 Cell, 41 Wh, integrated");
            return this;
        }

        public BuilderDell? Storage()
        {
            laptopProduct?.Add("Storage:  512 GB, M.2, PCIe NVMe, SSD");
            return this;
        }

        public BuilderDell? MicrosoftOffice()
        {
            laptopProduct?.Add("MicrosoftOffice:  No Microsoft Office License included");
            return this;
        }
        public BuilderDell? Power()
        {
            laptopProduct?.Add("Power:  65 Watt AC Adapter");
            return this;
        }

        public BuilderDell? Build()
        {
           laptopProduct?.GetProduct().ForEach(x=>Console.WriteLine(x));
            return this;
        }
    }
}
