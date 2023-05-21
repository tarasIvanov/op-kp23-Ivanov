using System;

namespace Computer_Shop
{
	class PC : PCs
	{
        public PC(PCsDTO pCsDTO)
        {
            SetNewCharacteristics(pCsDTO);
        }

        public PC()
        {

        }
    }
}

