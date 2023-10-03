using System;

namespace Computer_Shop
{
	abstract class PCs : Device
	{
        private OperationSystem _oS;
        private double _processorSpeedInGHz;

        public OperationSystem OS { get =>_oS; set { if (Enum.IsDefined(typeof(OperationSystem), value)) { _oS = value; return; } _oS = OperationSystem.Windows; } }
        public double ProcessorSpeedInGHz { get => _processorSpeedInGHz; set { if (value > 0 && value <= double.MaxValue) { _processorSpeedInGHz = value; return; } _processorSpeedInGHz = 0; } }

        public bool IsGoodForGTA5()
        {
            if (ProcessorSpeedInGHz >= 2 && MemoryinGB >= 200 && OS != OperationSystem.MacOC)
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

            OS = pCsDTO.OS;
            ProcessorSpeedInGHz = pCsDTO.ProcessorSpeedInGHz;
        }

        public override string ShowParentsTypeOfProduct() => TypesOfProduct.PCs.ToString();

        public override void PrintCharacteristics()
        {
            base.PrintCharacteristics();

            ChangeCollorOfSring($"OS: {OS}\tProcessor speed: {ProcessorSpeedInGHz}GHz", ConsoleColor.DarkBlue);
        }
    }
}

