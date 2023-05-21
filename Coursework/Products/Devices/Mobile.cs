using System;
namespace Computer_Shop
{
	abstract class Mobile : Device
	{
        public double DisplayInInches { get; set; }
        public double BatteryInMaH { get; set; }

        //public double DisplayInInches { get { return DisplayInInches; } set { if (value > 0 && value <= double.MaxValue) DisplayInInches = value; } }
        //public double BatteryInMaH { get { return BatteryInMaH; } set { if (value > 0 && value <= double.MaxValue) BatteryInMaH = value; } }

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

        public override string ShowParentsTypeOfProduct()
        {
            return TypesOfProduct.Mobile.ToString();
        }

        public override void PrintCharacteristics()
        {
            base.PrintCharacteristics();

            ChangeCollorOfSring($"Display: {DisplayInInches}inches\tBattery: {BatteryInMaH}MaH", ConsoleColor.DarkBlue);
        }
    }
}

