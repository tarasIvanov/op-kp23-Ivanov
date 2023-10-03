using System;
using System.Xml.Linq;

namespace Computer_Shop
{
	class ProductDTO
	{
        public ProductDTO(string Name, Country Country, int Price, int timeOfGuaranteeInDays, Color color)
        {
            this.Name = Name;
            this.Country = Country;
            this.Price = Price;
            this.TimeOfGuaranteeInDays = timeOfGuaranteeInDays;
            this.Color = color;
        }

        public string Name { get; protected set; }
        public Country Country { get; protected set; }
        public int Price { get; protected set; }
        public int TimeOfGuaranteeInDays { get; protected set; }
        public Color Color { get; protected set; }
    }
}

