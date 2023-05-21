using System;
using System.Xml.Linq;

namespace Computer_Shop
{
    class DeviceDTO : ProductDTO
    {
        public double WageInKG { get; protected set; }
        public double MemoryinGB { get; protected set; }

        public DeviceDTO(string Name, Producer Producer, Country Country, int Price, int timeOfGuaranteeInDays, Color color, double WageInKG, double MemoryinGB) : base(Name, Producer, Country, Price, timeOfGuaranteeInDays, color)
        {
            this.WageInKG = WageInKG;
            this.MemoryinGB = MemoryinGB;
        }
    }
}

