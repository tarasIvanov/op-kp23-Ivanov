using System;
namespace Computer_Shop
{
	abstract class Mobile : Device
	{
        public double DisplayInInches { get; set; }
        public double BatteryInMaH { get; set; }

        public bool IsGoodForPubg();

        public void SetNewCharacteristics(MobileDTO mobileDTO);

        public override string ShowParentsTypeOfProduct();

        public override void PrintCharacteristics();
}

