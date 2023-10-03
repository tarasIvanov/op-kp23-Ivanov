using System;
namespace Computer_Shop
{
	abstract class Mobile : Device
	{
        private double _displayInInches;
        private double _batteryInMaH;

        public double DisplayInInches { get => _displayInInches; set { if (value > 0 && value <= double.MaxValue) { _displayInInches = value; return; } _displayInInches = 0; } }
        public double BatteryInMaH { get => _batteryInMaH; set { if (value > 0 && value <= double.MaxValue) { _batteryInMaH = value; return; } _batteryInMaH = 0; } }

        public bool IsGoodForPubg()
        {
            if (DisplayInInches >= 5 && BatteryInMaH >= 2500 && MemoryinGB >= 32)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SetNewCharacteristics(MobileDTO mobileDTO)
        {
            base.SetNewCharacteristics(mobileDTO);

            DisplayInInches = mobileDTO.DisplayInInches;
            BatteryInMaH = mobileDTO.BatteryInMaH;
        }

        public override string ShowParentsTypeOfProduct() => TypesOfProduct.Mobile.ToString();

        public override void PrintCharacteristics()
        {
            base.PrintCharacteristics();

            ChangeCollorOfSring($"Display: {DisplayInInches}inches\tBattery: {BatteryInMaH}MaH", ConsoleColor.DarkBlue);
        }
    }
}

