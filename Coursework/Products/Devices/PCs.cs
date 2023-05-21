using System;

namespace Computer_Shop
{
	abstract class PCs : Device
	{
        public OperationSystem oS { get; set; }
        public double ProcessorSpeedInGHz { get; set; }

        public bool IsGoodForGTA5();

        public void SetNewCharacteristics();

        public override string ShowParentsTypeOfProduct();

        public override void PrintCharacteristics();
    }
}

