using System;
namespace Computer_Shop
{
	class PCsDTO : DeviceDTO
	{
        public OperationSystem OS { get; set; }
        public double ProcessorSpeedInGHz { get; set; }

        public PCsDTO(string Name, Country Country, int Price, int timeOfGuaranteeInDays, Color color, double WageInKG, double MemoryinGB, OperationSystem oS, double ProcessorSpeedInGHz) : base(Name, Country, Price, timeOfGuaranteeInDays, color, WageInKG, MemoryinGB)
        {
            this.OS = oS;
            this.ProcessorSpeedInGHz = ProcessorSpeedInGHz;
        }
    }
}

