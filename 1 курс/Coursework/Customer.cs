namespace Computer_Shop
{
    class Customer
    {
        public string Name { get; private set; }
        public int SumOfMoney { get; private set; }

        private List<Product> _BoughtProducts = new List<Product>();
        private int _numOfBoughtProducts = 0;

        public Customer(string name, int sumOfMoney)
        {
            this.Name = name;
            this.SumOfMoney = sumOfMoney;
        }

        public Customer()
        {
            SetCustomerInfo();
        }

        public void ShowBouhtProducts()
        {
            ChangeCollorOfSring("\nYour product list:", ConsoleColor.Blue);

            for (int i = 0; i < _numOfBoughtProducts; i++)
            {
                Console.WriteLine($"Product {i + 1}: {_BoughtProducts[i].Name}");
            }

            Console.WriteLine();
        }


        public void BuyProduct()
        {
            Product product = GetProductForBying();

            if (SumOfMoney >= product.Price)
            {
                SumOfMoney -= product.Price;
                _BoughtProducts.Add(product);

                ChangeCollorOfSring($"A deal is successfull: {product.Name}({product.Price})", ConsoleColor.Green);

                _numOfBoughtProducts++;
            }
            else
            {
                ChangeCollorOfSring($"You haven't enough money: {product.Name}({product.Price})", ConsoleColor.Red);
                ChangeCollorOfSring($"Sum of {Name}'s money is: {SumOfMoney}", ConsoleColor.Magenta);
            }
        }

        public void ReturnProduct()
        {
            int daysAfterBying = 0;

            Product product = GetProductForReturning();

            while (true)
            {
                ChangeCollorOfSring("Enter how many days have passed since the purchase", ConsoleColor.Cyan);
                daysAfterBying = int.Parse(Console.ReadLine());

                if (daysAfterBying > 0)
                {
                    break;
                }
                else
                {
                    ChangeCollorOfSring("Num need to be bigger than 0", ConsoleColor.Red);
                }
            }

            ChangeCollorOfSring("\nChecking guarantee..", ConsoleColor.Yellow);

            if (!product.CheckGuarantee(daysAfterBying))
            {
                return;
            }

            _BoughtProducts.Remove(product);

            SumOfMoney += product.Price;
            _numOfBoughtProducts--;

            ChangeCollorOfSring($"Product was successfuly returned)(+{product.Price})", ConsoleColor.Green);
        }

        public void SearchingBy(int selectedItem)
        {
            switch (selectedItem)
            {
                case 0:
                    TypesOfProduct typeOfProduct = GetTypeOfProduct();

                    Basket.SearchByType(typeOfProduct);

                    break;
                case 1:
                    int price = GetPriceOfProduct();

                    Basket.SearchByPrice(price);

                    break;
                case 2:
                    Producer producer = GetProducerOfProduct();

                    Basket.SearchByProducer(producer);

                    break;
                case 3:
                    Country country = GetCountryOfProduct();

                    Basket.SearchByCountry(country);

                    break;
                case 4:
                    Color color = GetColorOfProduct();

                    Basket.SearchByColor(color);

                    break;
                default:
                    break;
            }
        }

        public void PCsSupportGTA5()
        {
            int counter = 0;

            foreach (var product in Basket._products)
            {
                if (product is PCs pc)
                {
                    if (pc.IsGoodForGTA5())
                    {
                        if (counter == 0)
                        {
                            ChangeCollorOfSring("List of PC which is good for GTA5: ", ConsoleColor.Magenta);
                        }

                        counter++;

                        ChangeCollorOfSring($"{counter}) {pc.ShowTypeOfProduct()}: {pc.Name}({pc.Price})", ConsoleColor.Yellow);
                    }
                }
            }

            if (counter == 0)
            {
                ChangeCollorOfSring("Sorry, but we haven't good PC for the game GTA5", ConsoleColor.DarkRed);
            }
        }

        public void MobileSupportPUBG()
        {
            int counter = 0;

            foreach (var product in Basket._products)
            {
                if (product is Mobile mobile)
                {
                    if (mobile.IsGoodForPubg())
                    {
                        if (counter == 0)
                        {
                            ChangeCollorOfSring("List of Mobile which is good for PUBG: ", ConsoleColor.Magenta);
                        }

                        counter++;

                        ChangeCollorOfSring($"{counter}) {mobile.ShowTypeOfProduct()}: {mobile.Name}({mobile.Price})", ConsoleColor.Yellow);
                    }
                }
            }

            if (counter == 0)
            {
                ChangeCollorOfSring("Sorry, but we haven't good Mobeli for the game PUBG", ConsoleColor.DarkRed);
            }
        }


        public void ShowCustomerInfo()
        {
            ChangeCollorOfSring($"\nName: {Name}\nMoney: {SumOfMoney}", ConsoleColor.Cyan);
        }

        public void SetCustomerInfo()
        {
            string name;
            int money;

            while (true)
            {
                ChangeCollorOfSring("Enter your name:", ConsoleColor.Cyan);
                name = Console.ReadLine();

                if (name.Length < 2)
                {
                    ChangeCollorOfSring("Enter name with bigger length", ConsoleColor.Red);
                }
                else
                {
                    this.Name = name;
                    break;
                }
            }

            while (true)
            {
                ChangeCollorOfSring("Enter sum of your money:", ConsoleColor.Cyan);
                money = int.Parse(Console.ReadLine());

                if (money <= 0)
                {
                    ChangeCollorOfSring("Enter bigger sum of money", ConsoleColor.Red);
                }
                else
                {
                    this.SumOfMoney = money;
                    break;
                }
            }
            
        }

        
        private Product GetProductForBying()
        {
            int num;

            Basket.ShowAllProducts();

            while (true)
            {
                ChangeCollorOfSring("Enter number of product you want to buy", ConsoleColor.Cyan);

                num = int.Parse(Console.ReadLine());

                if (num > 0 && num <= Basket.CounterOfProducts)
                {
                    return Basket._products[num - 1];
                }
                else
                {
                    ChangeCollorOfSring("Num is out of the diapasone", ConsoleColor.Red);
                }
            }
        }

        private Product GetProductForReturning()
        {
            int num;

            ShowBouhtProducts();

            while (true)
            {
                ChangeCollorOfSring("Enter number of product you want to return", ConsoleColor.Cyan);


                num = int.Parse(Console.ReadLine());

                if (num > 0 && num <= _numOfBoughtProducts)
                {
                    return _BoughtProducts[num - 1];
                }
                else
                {
                    ChangeCollorOfSring("Num is out of the diapasone", ConsoleColor.Red);
                }
            }
        }


        private int GetPriceOfProduct()
        {
            int num;

            while (true)
            {
                ChangeCollorOfSring("Enter the range to which the amount of the product should be: ", ConsoleColor.Magenta);
                num = int.Parse(Console.ReadLine());

                if (num > 0)
                {
                    return num;
                }
                else
                {
                    ChangeCollorOfSring("Number is out the diapasone", ConsoleColor.Red);
                }
            }
        }

        private Country GetCountryOfProduct()
        {
            Country country = 0;
            int num;

            ChangeCollorOfSring("Countries: ", ConsoleColor.Magenta);
            PrintEnum(country);

            while (true)
            {
                ChangeCollorOfSring("Enter num of country:");
                num = int.Parse(Console.ReadLine());

                if (Enum.IsDefined(typeof(Country), num))
                {
                    return (Country)num;
                }
                else
                {
                    ChangeCollorOfSring("Number is out the diapasone", ConsoleColor.Red);
                }
            }
        }

        private Producer GetProducerOfProduct()
        {
            Producer producer = 0;
            int num;

            ChangeCollorOfSring("Producers: ", ConsoleColor.Magenta);
            PrintEnum(producer);

            while (true)
            {
                ChangeCollorOfSring("Enter num of producer:");
                num = int.Parse(Console.ReadLine());

                if (Enum.IsDefined(typeof(Producer), num))
                {
                    return (Producer)num;
                }
                else
                {
                    ChangeCollorOfSring("Number is out the diapasone", ConsoleColor.Red);
                }
            }
        }

        private Color GetColorOfProduct()
        {
            Color color = 0;
            int num;

            ChangeCollorOfSring("Colors: ", ConsoleColor.Magenta);
            PrintEnum(color);

            while (true)
            {
                ChangeCollorOfSring("Enter num of color:");
                num = int.Parse(Console.ReadLine());

                if (Enum.IsDefined(typeof(Color), num))
                {
                    return (Color)num;
                }
                else
                {
                    ChangeCollorOfSring("Number is out the diapasone", ConsoleColor.Red);
                }
            }
        }

        private TypesOfProduct GetTypeOfProduct()
        {
            TypesOfProduct typesOfProduct = 0;
            int num;

            ChangeCollorOfSring("Types: ", ConsoleColor.Magenta);
            PrintEnum(typesOfProduct);

            while (true)
            {
                ChangeCollorOfSring("Enter num of type:");
                num = int.Parse(Console.ReadLine());

                if (Enum.IsDefined(typeof(TypesOfProduct), num))
                {
                    return (TypesOfProduct)num;
                }
                else
                {
                    ChangeCollorOfSring("Number is out the diapasone", ConsoleColor.Red);
                }
            }
        }


        private void PrintEnum(Enum @enum)
        {
            var parameters = Enum.GetValues(@enum.GetType());

            foreach (var item in parameters)
            {
                ChangeCollorOfSring($"{@enum.GetType().Name} {Convert.ToInt32(item)}: {item}", ConsoleColor.Yellow);
            }
        }

        private void ChangeCollorOfSring(string str, ConsoleColor firstCollor = ConsoleColor.White, bool newLine = true)
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

