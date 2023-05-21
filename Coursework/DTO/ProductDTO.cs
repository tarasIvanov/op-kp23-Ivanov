using System;
using System.Xml.Linq;

namespace Computer_Shop
{
	class ProductDTO
	{
        public ProductDTO(string Name, Producer Producer, Country Country, int Price, int timeOfGuaranteeInDays, Color color)
        {
            this.Name = Name;
            this.Producer = Producer;
            this.Country = Country;
            this.Price = Price;
            this.timeOfGuaranteeInDays = timeOfGuaranteeInDays;
            this.color = color;
        }

        public string Name { get; protected set; }
        public Producer Producer { get; protected set; }
        public Country Country { get; protected set; }
        public int Price { get; protected set; }
        public int timeOfGuaranteeInDays { get; protected set; }
        public Color color { get; protected set; }

    }
}

