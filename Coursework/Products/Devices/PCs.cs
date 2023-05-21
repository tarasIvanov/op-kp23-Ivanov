using System;

namespace Computer_Shop
{
	abstract class PCs : Device
	{
        public OperationSystem oS { get; set; }
        public double ProcessorSpeedInGHz { get; set; }

        //public OperationSystem oS { get { return oS; } set { if (Enum.IsDefined(typeof(OperationSystem), value)) oS = value; } }
        //public double ProcessorSpeedInGHz { get { return ProcessorSpeedInGHz; } set { if (value > 0 && value <= double.MaxValue) ProcessorSpeedInGHz = value; } }

        public bool IsGoodForGTA5()
        {
            if (ProcessorSpeedInGHz >= 2 && MemoryinGB >= 200 && oS != OperationSystem.MacOC)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SetNewCharacteristics(PCsDTO pCsDTO)
        {
            base.SetNewCharacteristics(pCsDTO);

            oS = pCsDTO.oS;
            ProcessorSpeedInGHz = pCsDTO.ProcessorSpeedInGHz;
        }

        public override string ShowParentsTypeOfProduct()
        {
            return TypesOfProduct.PCs.ToString();
        }

        public override void PrintCharacteristics()
        {
            base.PrintCharacteristics();

            ChangeCollorOfSring($"OS: {oS}\tProcessor speed: {ProcessorSpeedInGHz}GHz", ConsoleColor.DarkBlue);
        }
    }
}

