using System;

namespace Computer_Shop
{
    class Keyboard : Gadget
    {
        public Keyboard(GadgetDTO gadgetDTO)
        {
            SetNewCharacteristics(gadgetDTO);
        }

        public Keyboard()
        {

        }
    }
}

