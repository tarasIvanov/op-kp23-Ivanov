using System;
namespace Computer_Shop
{
	class MobileDTO : DeviceDTO
	{
        public MobileDTO(string Name, Producer Producer, Country Country, int Price, int timeOfGuaranteeInDays, Color color, double WageInKG, double MemoryinGB, double DisplayInInches, double BatteryInMaH) : base(Name, Producer, Country, Price, timeOfGuaranteeInDays, color, WageInKG, MemoryinGB)
        {
            this.DisplayInInches = DisplayInInches;
            this.BatteryInMaH = BatteryInMaH;
        }

        public double DisplayInInches { get; protected set; }
        public double BatteryInMaH { get; protected set; }
    }
}

