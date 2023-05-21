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

        protected void SetNewDefaultCharacteristics();

        public virtual void PrintCharacteristics();
            

        public bool CheckGuarantee(int daysAfterBying);

        public string ShowTypeOfProduct();

        public abstract string ShowParentsTypeOfProduct();

        protected void ChangeCollorOfSring(string str, ConsoleColor firstCollor, bool newLine = true);
    }
}

