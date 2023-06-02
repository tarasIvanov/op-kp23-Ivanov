using System;

namespace Computer_Shop
{
	abstract class Device : Product
	{
        private double _wageInKG;
        private double _memoryinGB;

        public double WageInKG { get => _wageInKG; set { if (value > 0 && value <= double.MaxValue) { _wageInKG = value; return; } _wageInKG = 0; } }
        public double MemoryinGB { get => _memoryinGB; set { if (value > 0 && value <= double.MaxValue) { _memoryinGB = value; return; } _memoryinGB = 0; } }

        public void SetNewCharacteristics(DeviceDTO deviceDTO)
        {
            SetNewDefaultCharacteristics(deviceDTO);

            WageInKG = deviceDTO.WageInKG;
            MemoryinGB = deviceDTO.MemoryinGB;
        }

        public override void PrintCharacteristics()
        {
            base.PrintCharacteristics();

            ChangeCollorOfSring($"Wage: {WageInKG}KG\tSSD: {MemoryinGB}GB\t", ConsoleColor.DarkBlue, false);
        }
    }
}

