using System;
using System.Drawing;
using System.Xml.Linq;

namespace Computer_Shop
{
    abstract class Product
    {
        public string Name { get; set; }
        public Producer Producer { get; set; }
        public Country Country { get; set; }
        public int Price { get; set; }
        public int TimeOfGuaranteeInDays { get; set; }
        public Color Color { get; set; }

        //public string Name { get { return Name; } set { if (value.Length > 2) Name = value; } }
        //public Producer Producer { get { return Producer; } set { if (Enum.IsDefined(typeof(Producer), value)) Producer = value; } }
        //public Country Country { get { return Country; } set { if (Enum.IsDefined(typeof(Country), value)) Country = value; } }
        //public int Price { get { return Price; } set { if (value > 0 && value <= int.MaxValue) Price = value; } }
        //public int TimeOfGuaranteeInDays { get { return TimeOfGuaranteeInDays; } set { if (value > 0 && value <= int.MaxValue) TimeOfGuaranteeInDays = value; } }
        //public Color Color { get { return Color; } set { if (Enum.IsDefined(typeof(Color), value)) Color = value; } }

        protected void SetNewDefaultCharacteristics(ProductDTO productDTO)
        {
            Name = productDTO.Name;
            Producer = productDTO.Producer;
            Country = productDTO.Country;
            Price = productDTO.Price;
            TimeOfGuaranteeInDays = productDTO.timeOfGuaranteeInDays;
            Color = productDTO.color;
        }

        public virtual void PrintCharacteristics()
        {
            ChangeCollorOfSring($"Name: {Name}\tProducer: {Producer}\tCountry: {Country} \tPrice: {Price}", ConsoleColor.Yellow);
            ChangeCollorOfSring($"Guarantee: { TimeOfGuaranteeInDays} days\tCollor: { Color}", ConsoleColor.DarkCyan);
        }

        public bool CheckGuarantee(int daysAfterBying)
        {
            if (daysAfterBying <= TimeOfGuaranteeInDays) {
                ChangeCollorOfSring("Guarantee is okey)", ConsoleColor.Green);

                return true;
            }

            ChangeCollorOfSring("Eror:\tTerm of guarantee was ended\nSorry but we can't return this product", ConsoleColor.Red);

            return false;
        }

        public string ShowTypeOfProduct()
        {
            return GetType().Name;
        }

        public abstract string ShowParentsTypeOfProduct();

        protected void ChangeCollorOfSring(string str, ConsoleColor firstCollor, bool newLine = true)
        {
            if (newLine)
            {
                Console.ForegroundColor = firstCollor;
                Console.WriteLine($"{str}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = firstCollor;
                Console.Write($"{str}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

    }
}

