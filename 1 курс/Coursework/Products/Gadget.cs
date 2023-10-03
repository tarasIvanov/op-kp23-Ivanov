using System;

namespace Computer_Shop
{
	abstract class Gadget : Product
	{
        private double _lengthOfWireInCM;

        public double LengthOfWireInCM { get => _lengthOfWireInCM; set { if (value > 0 && value <= int.MaxValue) { _lengthOfWireInCM = value; return; } _lengthOfWireInCM = 0; } }

        public void SetNewCharacteristics(GadgetDTO gadgetDTO)
        {
            SetNewDefaultCharacteristics(gadgetDTO);

            LengthOfWireInCM = gadgetDTO.lengthOfWireInCM;
        }

        public override string ShowParentsTypeOfProduct() => TypesOfProduct.Gadget.ToString();

        public override void PrintCharacteristics()
        {
            base.PrintCharacteristics();

            ChangeCollorOfSring($"Wire: {LengthOfWireInCM}CM", ConsoleColor.DarkBlue);
        }
    }
}

