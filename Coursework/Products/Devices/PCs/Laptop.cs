using System;

namespace Computer_Shop
{
	class Laptop : PCs
	{
        public Laptop(PCsDTO pCsDTO)
        {
            SetNewCharacteristics(pCsDTO);
        }

        public Laptop()
        {

        }
    }
}

