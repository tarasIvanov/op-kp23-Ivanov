using System;

namespace Computer_Shop
{
    class Headphones : Gadget
    {
        public Headphones(GadgetDTO gadgetDTO)
        {
            SetNewCharacteristics(gadgetDTO);
        }

        public Headphones()
        {

        }

    }
}


