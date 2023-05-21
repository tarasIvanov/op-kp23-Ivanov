using System;

namespace Computer_Shop
{
	abstract class Device : Product
	{
        public double WageInKG { get; set; }
        public double MemoryinGB { get; set; }

        //public double WageInKG { get { return WageInKG; } set { if (value > 0 && value <= double.MaxValue) WageInKG = value; } }
        //public double MemoryinGB { get { return MemoryinGB; } set { if (value > 0 && value <= double.MaxValue) MemoryinGB = value; } }

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

