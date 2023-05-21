using System;

namespace Computer_Shop
{
	abstract class Device : Product
	{
        public double WageInKG { get; set; }
        public double MemoryinGB { get; set; }

        public void SetNewCharacteristics();

        public override void PrintCharacteristics();
    }
}

