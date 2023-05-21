using System;
namespace Computer_Shop
{
	class PCsDTO : DeviceDTO
	{
        public PCsDTO(string Name, Producer Producer, Country Country, int Price, int timeOfGuaranteeInDays, Color color, double WageInKG, double MemoryinGB, OperationSystem oS, double ProcessorSpeedInGHz) : base(Name, Producer, Country, Price, timeOfGuaranteeInDays, color, WageInKG, MemoryinGB)
        {
            this.oS = oS;
            this.ProcessorSpeedInGHz = ProcessorSpeedInGHz;
        }

        public OperationSystem oS { get; protected set; }
        public double ProcessorSpeedInGHz { get; protected set; }
    }
}

