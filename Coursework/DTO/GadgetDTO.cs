using System;
namespace Computer_Shop
{
    class GadgetDTO : ProductDTO
    {
        public GadgetDTO(string Name, Producer Producer, Country Country, int Price, int timeOfGuaranteeInDays, Color color, double lengthOfWireInCM) : base(Name, Producer, Country, Price, timeOfGuaranteeInDays, color)
        {
            this.lengthOfWireInCM = lengthOfWireInCM;
        }

        public double lengthOfWireInCM { get; protected set; }
    }
}

