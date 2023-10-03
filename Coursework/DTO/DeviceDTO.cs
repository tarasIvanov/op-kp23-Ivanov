using System;
using System.Xml.Linq;

namespace Computer_Shop
{
    class DeviceDTO : ProductDTO
    {
        public double WageInKG { get; set; }
        public double MemoryinGB { get; set; }

        public DeviceDTO(string Name, Country Country, int Price, int timeOfGuaranteeInDays, Color color, double WageInKG, double MemoryinGB) : base(Name, Country, Price, timeOfGuaranteeInDays, color)
        {
            this.WageInKG = WageInKG;
            this.MemoryinGB = MemoryinGB;
        }
    }
}

