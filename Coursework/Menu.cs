using System;
namespace Computer_Shop
{
	static class Menu
	{
        private const int AUTHENTICATION_NUM_OF_OPTIONS = 2;
        private const int ADMIN_MENU_NUM_OF_OPTIONS = 4;
        private const int CUSTOMER_MENU_NUM_OF_OPTIONS = 9;
        private const int SEARCHING_TYPES_NUM_OF_OPTIONS = 5;
        private const int SET_NEW_PARAMS_TYPES_NUM_OF_OPTIONS = 13;

        private static List<Customer> _customers;
        private static List<string> _customersNames;

        private static int _numOfCustomers = 0;

        private static List<string> _authentication;
        private static List<string> _adminMenu;
        private static List<string> _customerMenu;
        private static List<string> _searchingBy;
        private static List<string> _setNewParams;

        private static string _pathAuthentication = "/Users/tarasivanov/Projects/Computer_Shop/Files/Authentication.txt";
        private static string _pathAdminMenu = "/Users/tarasivanov/Projects/Computer_Shop/Files/Admin menu.txt";
        private static string _pathCustomerMenu = "/Users/tarasivanov/Projects/Computer_Shop/Files/Customer menu.txt";
        private static string _pathSearchingTypes = "/Users/tarasivanov/Projects/Computer_Shop/Files/Searching types.txt";
        private static string _pathSetNewParams = "/Users/tarasivanov/Projects/Computer_Shop/Files/Set new params types.txt";


        static Menu()
        {
            _authentication = ReadFile(_pathAuthentication);
            _adminMenu = ReadFile(_pathAdminMenu);
            _customerMenu = ReadFile(_pathCustomerMenu);

            _searchingBy = ReadFile(_pathSearchingTypes);
            _setNewParams = ReadFile(_pathSetNewParams);

            _customers = new List<Customer>();
            _customersNames = new List<string>();
        }

        public static void StartMenu()
		{
            ConsoleKey key = 0;

            int selectedItem = 0;

            ChangeCollorOfSring("Hello!\nWe are very glad to see you in our shop!\n", ConsoleColor.Green);

            while (true)
            {
                SelectKey(_authentication, AUTHENTICATION_NUM_OF_OPTIONS, ref key, ref selectedItem);

                if (key == ConsoleKey.Escape)
                {
                    break;
                }

                switch (selectedItem)
                {
                    case 0:
                        Admin admin = new Admin();

                        AdminMenu(admin);

                        break;
                    case 1:
                        Customer customer = ChooseCustomer();

                        CustomerMenu(customer);

                        break;
                    default:
                        break;
                }
            }

            
        }


        private static void AdminMenu(Admin admin)
        {
            ConsoleKey key = 0;
            int selectedItem = 0;

            while (true)
            {
                SelectKey(_adminMenu, ADMIN_MENU_NUM_OF_OPTIONS, ref key, ref selectedItem);

                if (key == ConsoleKey.Escape)
                {
                    break;
                }

                switch (selectedItem)
                {
                    case 0:
                        admin.CreateNewProduct();

                        break;
                    case 1:
                        ConsoleKey key2 = 0;
                        int selectedItem2 = 0;

                        SelectKey(_setNewParams, SET_NEW_PARAMS_TYPES_NUM_OF_OPTIONS, ref key2, ref selectedItem2);

                        admin.SetSomethingNew(selectedItem2);

                        break;
                    case 2:
                        Basket.ShowAllProducts();
                        Basket.RemoveProduct();

                        break;
                    case 3:
                        Basket.ShowAllProducts();

                        break;
                    default:
                        ChangeCollorOfSring("Eror(admin menu)", ConsoleColor.Red);
                        break;
                }
            }
        }

        private static void CustomerMenu(Customer customer)
        {
            ConsoleKey key = 0;
            int selectedItem = 0;

            while (true)
            {
                SelectKey(_customerMenu, CUSTOMER_MENU_NUM_OF_OPTIONS, ref key, ref selectedItem);

                if (key == ConsoleKey.Escape)
                {
                    break;
                }

                switch (selectedItem)
                {
                    case 0:
                        Basket.ShowAllProducts();

                        break;
                    case 1:
                        customer.BuyProduct();

                        break;
                    case 2:
                        customer.ShowBouhtProducts();

                        break;
                    case 3:
                        customer.ReturnProduct();

                        break;
                    case 4:
                        ConsoleKey key2 = 0;
                        int selectedItem2 = 0;

                        SelectKey(_searchingBy, SEARCHING_TYPES_NUM_OF_OPTIONS, ref key2, ref selectedItem2);

                        customer.SearchingBy(selectedItem2);

                        break;
                    case 5:
                        customer.PCsSupportGTA5();

                        break;
                    case 6:
                        customer.MobileSupportPUBG();

                        break;
                    case 7:
                        customer.ShowCustomerInfo();

                        break;
                    case 8:
                        int selectedCustomer = 0;

                        for (int i = 0; i < _customers.Capacity; i++)
                        {
                            if (customer.Equals(_customers[i]))
                            {
                                selectedCustomer = i;

                                break;
                            }
                        }

                        customer.SetCustomerInfo();

                        _customersNames[selectedCustomer] = $"{selectedCustomer + 1})Name:{customer.Name}\tMoney:{customer.SumOfMoney}";

                        break;
                    default:
                        ChangeCollorOfSring("Eror(customer menu)", ConsoleColor.Red);
                        break;
                }
            }
        }

        private static Customer ChooseCustomer()
        {
            if (_customers.Capacity == 0)
            {
                Customer customer = new Customer();

                _customers.Add(customer);

                _numOfCustomers++;

                _customersNames.Add($"{_numOfCustomers})Name:{customer.Name}\tMoney:{customer.SumOfMoney}");

                return customer;
            }

            ConsoleKey key = 0;
            int selectedItem = 0;

            string strCreateNewCustomer = "Create new customer";

            ChangeCollorOfSring("List of customers: ");

            _customersNames.Add(strCreateNewCustomer);

            SelectKey(_customersNames, _numOfCustomers + 1, ref key, ref selectedItem);

            if (_customersNames[selectedItem] == strCreateNewCustomer)
            {
                Customer customer = new Customer();

                _customers.Add(customer);

                _numOfCustomers++;

                _customersNames.Add($"{_numOfCustomers})Name:{customer.Name}\tMoney:{customer.SumOfMoney}");

                _customersNames.Remove(strCreateNewCustomer);

                return customer;
            }

            _customersNames.Remove(strCreateNewCustomer);

            return _customers[selectedItem];
        }

        private static void SelectKey(List<string> list, int maxValueOfOperations, ref ConsoleKey key, ref int selectedItem)
        {
            ConsoleKey tempKey;
            int activePosition = 0;

            PrintList(list, activePosition);

            while (true)
            {
                ChangeCollorOfSring("\nuse: S - down; W - up; Enter - to select; Escape - exit", ConsoleColor.White);

                tempKey = Console.ReadKey().Key;

                switch (tempKey)
                {
                    case ConsoleKey.W:
                        if (activePosition > 0)
                        {
                            Console.Clear();

                            activePosition--;

                            PrintList(list, activePosition);
                        }

                        break;

                    case ConsoleKey.S:
                        if (activePosition < maxValueOfOperations - 1)
                        {
                            Console.Clear();

                            activePosition++;

                            PrintList(list, activePosition);
                        }

                        break;

                    case ConsoleKey.Enter:

                        Console.Clear();

                        selectedItem = activePosition;
                        return;

                    case ConsoleKey.Escape:

                        Console.Clear();

                        key = tempKey;
                        return;

                    default:
                        break;
                }
            }
            

        }

        private static void PrintList(List<string> list, int activePosition)
        {
            ConsoleColor backgroundColor = Console.BackgroundColor;

            for (int i = 0; i < list.Count; i++)
            {
                if (i == activePosition)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    ChangeCollorOfSring(list[i]);
                    Console.BackgroundColor = backgroundColor;
                }
                else
                {
                    ChangeCollorOfSring(list[i]);
                }

            }
        }

        private static List<string> ReadFile(string path)
        {
            List<string> list = new List<string>();

            using (var sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    list.Add(sr.ReadLine());
                }
            }

            return list;
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

