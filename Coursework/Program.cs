using System;

namespace Computer_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            SetDefaultBasket();

            Menu.StartMenu();
        }

        public static void SetDefaultBasket()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Default products:");
            Console.ForegroundColor = ConsoleColor.White;

            Keyboard keyboard1 = new Keyboard(new GadgetDTO("Клацалка", Country.England, 200, 30, Color.Red, 240));
            Keyboard keyboard2 = new Keyboard(new GadgetDTO("ТикалкаProMax+", Country.Ukraine, 500, 50, Color.Black, 300));

            Mouse mouse1 = new Mouse(new GadgetDTO("Natural Mouse", Country.Poland, 300, 14, Color.Black, 50));
            Headphones headphones1 = new Headphones(new GadgetDTO("Real headphones", Country.Spain, 100, 7, Color.White, 30));
            Microphone microphone1 = new Microphone(new GadgetDTO("False Micro", Country.Poland, 250, 50, Color.Black, 70));

            PC pc1 = new PC(new PCsDTO("Compucter007", Country.Poland, 2000, 90, Color.Black, 5.3, 480, OperationSystem.Windows, 2.1));
            Laptop macBook1 = new Laptop(new PCsDTO("MacBook Pro", Country.German, 2000, 90, Color.Black, 5.3, 480, OperationSystem.MacOC, 2.1));
            Phone phone1 = new Phone(new MobileDTO("IphoneSE", Country.German, 1000, 50, Color.Yellow, 0.4, 32, 4, 1600));
            Tablet tablet1 = new Tablet(new MobileDTO("SamsungPro", Country.England, 1700, 50, Color.White, 1.2, 240, 8.2, 3000));

            Laptop laptop2 = new Laptop(new PCsDTO("The best PC ever been", Country.Netherlands, 3500, 120, Color.Green, 4, 1024, OperationSystem.Windows, 3));
            Phone phone2 = new Phone(new MobileDTO("The best Mobile ever been", Country.England, 2500, 150, Color.Yellow, 1.6, 516, 5, 4500));

            Basket.AddProduct(keyboard1, keyboard2, mouse1, headphones1, microphone1, pc1, macBook1, phone1, tablet1, laptop2, phone2);

            Console.Clear();
        }
    }        
}
