using System;
using System.Diagnostics.Metrics;

namespace Computer_Shop
{
	class Basket
	{
        public static List<Product> _products { get; private set; }
        public static int CounterOfProducts { get; private set; }

        static Basket()
        {

        }

        public Basket(params Product[] products)
        {
            
        }

        public static void AddProduct(params Product[] products);
        
        public static void RemoveProduct(int numberOfProduct = 0);

        public static void RemoveProduct(Product product);

        public static void ShowAllProducts();


        public static void SearchByPrice(int lastDiapason, int firstDiapason = 0);
        
        public static void SearchByCountry(Country country);

        public static void SearchByColor(Color color);

        public static void SearchByProducer(Producer producer);

        public static void SearchByType(TypesOfProduct type);


        private static bool IsProductInBasket(Product product);
    }
}

