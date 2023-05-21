using System;

namespace Computer_Shop
{
	class Mouse : Gadget
	{
        public Mouse(GadgetDTO gadgetDTO)
        {
            SetNewCharacteristics(gadgetDTO);
        }

        public Mouse()
        {

        }
    }
}

