using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    internal class BuilderHP : ILaptop<BuilderHP>
    {
        private Product hpLaptopProduct;

        public BuilderHP()
        {
            hpLaptopProduct = new Product();
        }
        public BuilderHP? AudioSpeakers()
        {
            hpLaptopProduct.Add("AudioSpeakers:  Dual speakers");
            return this;
        }

        public BuilderHP? Camera()
        {
            hpLaptopProduct.Add("Camera:  HP Wide Vision 720p HD camera with temporal noise reduction and integrated dual array digital microphones");
            return this;
        }

        public BuilderHP? Case()
        {
            hpLaptopProduct.Add("Case:  Silver Light");
            return this;
        }

        public BuilderHP? CentralProcessingUnit()
        {
            hpLaptopProduct.Add("CPU:  Intel® Pentium® Silver N6000 (up to 3.3 GHz burst frequency, 4 MB L3 cache, 4 cores, 4 threads)");
            return this;
        }

        public BuilderHP? Display()
        {
            hpLaptopProduct.Add("Display:  15.6\" diagonal, FHD (1920 x 1080), micro-edge, anti-glare, 250 nits, 45% NTSC");
            return this;
        }

        public BuilderHP? GraphicsCard()
        {
            hpLaptopProduct.Add("GraphicsCard:  Integrated: Intel® UHD Graphics");
            return this;
        }

        public BuilderHP? Keyboard()
        {
            hpLaptopProduct.Add("Keyboard:  Full-size, backlit, jet black keyboard with numeric keypad");
            return this;
        }

        public BuilderHP? Memory()
        {
            hpLaptopProduct.Add("Memory:  8 GB LPDDR4x-2933 MHz RAM (onboard)");
            return this;
        }

        public BuilderHP? OperatingSystem()
        {
            hpLaptopProduct.Add("OS:  ChromeOS");
            return this;
        }

        public BuilderHP? Ports()
        {
            hpLaptopProduct.Add("Ports:  2 USB Type-C® 5Gbps signaling rate (USB Power Delivery, DisplayPort™ 1.4); 1 USB Type-A 5Gbps\r\nsignaling rate; 1 headphone/microphone combo");
            return this;
        }

        public BuilderHP? PrimaryBattery()
        {
            hpLaptopProduct.Add("PrimaryBattery:  2-cell, 47 Wh Li-ion polymer");
            return this;
        }

        public BuilderHP? Storage()
        {
            hpLaptopProduct.Add("Storage:  64 GB eMMC");
            return this;
        }

        public BuilderHP? Build()
        {
            hpLaptopProduct?.GetProduct().ForEach(x => Console.WriteLine(x));
            return this;
        }
    }
}
