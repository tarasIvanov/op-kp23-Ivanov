using System;
namespace Computer_Shop
{
    class GadgetDTO : ProductDTO
    {
        public double lengthOfWireInCM { get; protected set; }

        public GadgetDTO(string Name, Country Country, int Price, int timeOfGuaranteeInDays, Color color, double lengthOfWireInCM) : base(Name, Country, Price, timeOfGuaranteeInDays, color)
        {
            this.lengthOfWireInCM = lengthOfWireInCM;
        }
    }
}

