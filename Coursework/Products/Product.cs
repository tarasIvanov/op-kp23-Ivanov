using System;
using System.Drawing;
using System.Xml.Linq;

namespace Computer_Shop
{
    abstract class Product
    {
        private string _name;
        private Producer _producer;
        private Country _country;
        private int _price;
        private int _timeOfGuaranteeInDays;
        private Color _color;

        public string Name { get => _name;  set { if (value.Length >= 2) { _name = value; return; } _name = $"{value}00"; } }
        public Producer Producer { get => _producer; }
        public Country Country { get => _country; set { if (Enum.IsDefined(typeof(Country), value)) { _country = value; return; } } }
        public int Price { get => _price; set { if (value > 0 && value <= int.MaxValue) { _price = value; return; } _price = 0; } }
        public int TimeOfGuaranteeInDays { get => _timeOfGuaranteeInDays; set { if (value > 0 && value <= int.MaxValue) { _timeOfGuaranteeInDays = value; return; } _timeOfGuaranteeInDays = 0; } }
        public Color Color { get => _color; set { if (Enum.IsDefined(typeof(Color), value)) { _color = value; return; } _color = Color.Black; } }

        public Dictionary<Country, Producer> _countries_producers { get; protected set; }

        public Product()
        {
            _countries_producers = new Dictionary<Country, Producer>();

            _countries_producers.Add(Country.England, Producer.Grinch);
            _countries_producers.Add(Country.Ukraine, Producer.Ne_Pan_Polak);
            _countries_producers.Add(Country.Poland, Producer.Pan_Polak);
            _countries_producers.Add(Country.German, Producer.Gagaga);
            _countries_producers.Add(Country.Spain, Producer.BigBob);
            _countries_producers.Add(Country.France, Producer.Orevua);
            _countries_producers.Add(Country.Portugal, Producer.Ronaldo);
            _countries_producers.Add(Country.Sweden, Producer.Nun_Swed);
            _countries_producers.Add(Country.Italy, Producer.Pizzes);
            _countries_producers.Add(Country.Netherlands, Producer.Depay);
        }

        protected void SetNewDefaultCharacteristics(ProductDTO productDTO)
        {
            Name = productDTO.Name;
            Country = productDTO.Country;
            Price = productDTO.Price;
            TimeOfGuaranteeInDays = productDTO.TimeOfGuaranteeInDays;
            Color = productDTO.Color;

            SetNewProducer();
        }

        public virtual void PrintCharacteristics()
        {
            ChangeCollorOfSring($"Name: {Name}\tProducer: {Producer}\tCountry: {Country} \tPrice: {Price}", ConsoleColor.Yellow);
            ChangeCollorOfSring($"Guarantee: {TimeOfGuaranteeInDays} days\tCollor: {Color}", ConsoleColor.DarkCyan);
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

        public string ShowTypeOfProduct() => GetType().Name;

        public abstract string ShowParentsTypeOfProduct();

        public void SetNewProducer()
        {
            _countries_producers.TryGetValue(this.Country, out _producer);
        }

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

