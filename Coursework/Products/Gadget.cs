using System;

namespace Computer_Shop
{
	abstract class Gadget : Product
	{
		public double lengthOfWireInCM { get; set; }

        public void SetNewCharacteristics();

        public override string ShowParentsTypeOfProduct();

        public override void PrintCharacteristics();
    }
}

