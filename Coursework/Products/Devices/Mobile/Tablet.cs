using System;
namespace Computer_Shop
{
	class Tablet : Mobile
	{
        public Tablet(MobileDTO mobileDTO)
        {
            SetNewCharacteristics(mobileDTO);
        }

        public Tablet()
        {
               
        }
    }
}

