using System;

namespace Computer_Shop
{
	abstract class Gadget : Product
	{
		public double lengthOfWireInCM { get; set; }

        //public double lengthOfWireInCM { get { return lengthOfWireInCM; } set { if (value > 0 && value <= int.MaxValue) lengthOfWireInCM = value; } }

        public void SetNewCharacteristics(GadgetDTO gadgetDTO)
        {
            SetNewDefaultCharacteristics(gadgetDTO);

            lengthOfWireInCM = gadgetDTO.lengthOfWireInCM;
        }

        public override string ShowParentsTypeOfProduct()
        {
            return TypesOfProduct.Gadget.ToString();
        }

        public override void PrintCharacteristics()
        {
            base.PrintCharacteristics();

            ChangeCollorOfSring($"Wire: {lengthOfWireInCM}CM", ConsoleColor.DarkBlue);
        }
    }
}

