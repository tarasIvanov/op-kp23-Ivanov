using System;
namespace Computer_Shop
{
	class MobileDTO : DeviceDTO
	{
        public double DisplayInInches { get; set; }
        public double BatteryInMaH { get; set; }

        public MobileDTO(string Name, Country Country, int Price, int timeOfGuaranteeInDays, Color color, double WageInKG, double MemoryinGB, double DisplayInInches, double BatteryInMaH) : base(Name, Country, Price, timeOfGuaranteeInDays, color, WageInKG, MemoryinGB)
        {
            this.DisplayInInches = DisplayInInches;
            this.BatteryInMaH = BatteryInMaH;
        }
    }
}

