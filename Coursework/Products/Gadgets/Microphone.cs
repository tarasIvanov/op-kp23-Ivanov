using System;

namespace Computer_Shop
{
    class Microphone : Gadget
    {
        public Microphone(GadgetDTO gadgetDTO)
        {
            SetNewCharacteristics(gadgetDTO);
        }

        public Microphone()
        {

        }
    }
}


