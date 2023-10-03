using System;
namespace Computer_Shop
{
	class Phone : Mobile
	{
        public Phone(MobileDTO mobileDTO)
        {
            SetNewCharacteristics(mobileDTO);
        }

        public Phone()
        {

        }
    }
}

