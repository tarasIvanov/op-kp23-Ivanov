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
            _products = new List<Product>();
        }

        public Basket(params Product[] products)
        {
            foreach (var product in products)
            {
                _products.Add(product);
                CounterOfProducts++;
            }
        }

        public static void AddProduct(params Product[] products)
		{
            foreach (var product in products)
            {
                _products.Add(product);
                CounterOfProducts++;

                ChangeCollorOfSring($"Product <{product.Name}> was succesfuly aded to basket", ConsoleColor.Green);
            }
        }
        
        public static void RemoveProduct(int numberOfProduct = 0)
        {
            if (numberOfProduct <= 0)
            {
                ChangeCollorOfSring("Enter product number, you want to delete:", ConsoleColor.Cyan);
                numberOfProduct = Convert.ToInt32(Console.ReadLine());
            }

            while (true)
            {
                if (numberOfProduct > 0 && numberOfProduct <= CounterOfProducts)
                {
                    ChangeCollorOfSring($"Product <{_products[numberOfProduct - 1].Name}> was successfully removed", ConsoleColor.Green);

                    _products.Remove(_products[numberOfProduct - 1]);
                    CounterOfProducts--;

                    break;
                }

                ChangeCollorOfSring($"Number was out diapason, product is not exist", ConsoleColor.Red);

                ChangeCollorOfSring("Enter product number, you want to delete:", ConsoleColor.Cyan);
                numberOfProduct = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void RemoveProduct(Product product)
        {
            if (IsProductInBasket(product))
            {
                ChangeCollorOfSring($"Product <{product.Name}> was successfully removed", ConsoleColor.Green);

                _products.Remove(product);
                CounterOfProducts--;
            }
            else
            {
                ChangeCollorOfSring($"The product <{product.Name}> does not exist in basket", ConsoleColor.Red);
            }
        }

        public static void ShowAllProducts()
		{
            for (int i = 0; i < CounterOfProducts; i++)
            {
                Console.WriteLine($"\nProduct {i + 1}: {_products[i].ShowTypeOfProduct()}");
                _products[i].PrintCharacteristics();
            }
        }


        public static void SearchByPrice(int lastDiapason, int firstDiapason = 0)
        {
            Console.WriteLine();

            int counter = 1;

            if (lastDiapason <= 0)
            {
                ChangeCollorOfSring("Enter last diapason :", ConsoleColor.Cyan);
                lastDiapason = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var product in _products)
            {
                if (product.Price >= firstDiapason && product.Price <= lastDiapason)
                {
                    if (counter == 1)
                    {
                        ChangeCollorOfSring($"Products in diapason from {firstDiapason} to {lastDiapason}", ConsoleColor.Cyan);
                    }

                    ChangeCollorOfSring($"Product {counter}: {product.Name} - {product.Price}", ConsoleColor.Yellow);

                    counter++;
                }
            }

            if (counter == 1)
            {
                ChangeCollorOfSring($"Products is this diapason is not exist", ConsoleColor.Red);
            }
        }
        
        public static void SearchByCountry(Country country)
        {
            Console.WriteLine();

            int counter = 1;

            foreach (var product in _products)
            {
                if (product.Country == country)
                {
                    if (counter == 1)
                    {
                        ChangeCollorOfSring($"Products from {country}", ConsoleColor.Cyan);
                    }

                    ChangeCollorOfSring($"Product {counter}: {product.Name} - {product.Price}", ConsoleColor.Yellow);

                    counter++;
                }
            }

            if (counter == 1)
            {
                ChangeCollorOfSring($"Products from this country is not exist", ConsoleColor.Red);
            }
        }

        public static void SearchByColor(Color color)
        {
            Console.WriteLine();

            int counter = 1;

            foreach (var product in _products)
            {
                if (product.Color == color)
                {
                    if (counter == 1)
                    {
                        ChangeCollorOfSring($"Products color {color}:", ConsoleColor.Cyan);
                    }

                    ChangeCollorOfSring($"Product {counter}: {product.Name} - {product.Price}", ConsoleColor.Yellow);

                    counter++;
                }
            }

            if (counter == 1)
            {
                ChangeCollorOfSring($"Products this color is not exist", ConsoleColor.Red);
            }
        }

        public static void SearchByProducer(Producer producer)
        {
            Console.WriteLine();

            int counter = 1;

            foreach (var product in _products)
            {
                if (product.Producer == producer)
                {
                    if (counter == 1)
                    {
                        ChangeCollorOfSring($"Products manufactured by {producer}:", ConsoleColor.Cyan);
                    }

                    ChangeCollorOfSring($"Product {counter}: {product.Name} - {product.Price}", ConsoleColor.Yellow);

                    counter++;
                }
            }

            if (counter == 1)
            {
                ChangeCollorOfSring($"Products manufactured this producer is not exist", ConsoleColor.Red);
            }
        }

        public static void SearchByType(TypesOfProduct type)
        {
            Console.WriteLine();

            int counter = 1;

            foreach (var product in _products)
            {
                if (product.ShowParentsTypeOfProduct() == type.ToString())
                {
                    if (counter == 1)
                    {
                        ChangeCollorOfSring($"Products type {type}:", ConsoleColor.Cyan);
                    }

                    ChangeCollorOfSring($"Product {counter}: {product.Name}({product.ShowTypeOfProduct()}) - {product.Price}", ConsoleColor.Yellow);

                    counter++;
                }
            }

            if (counter == 1)
            {
                ChangeCollorOfSring($"Products this type is not exist", ConsoleColor.Red);
            }

        }


        private static bool IsProductInBasket(Product product)
        {
            foreach (var product1 in _products)
            {
                if (product.Equals(product1))
                {
                    return true;
                }
            }

            return false;
        }

        private static void ChangeCollorOfSring(string str, ConsoleColor firstCollor = ConsoleColor.White, bool newLine = true)
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

