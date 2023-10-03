using System;
using System.Diagnostics;
using System.Drawing;

namespace Computer_Shop
{
    class Admin
	{
		public void CreateNewProduct()
		{
            TypesOfProduct typeOfProduct = ChooseTypeOfProduct();

            Console.WriteLine();

            switch (typeOfProduct)
            {
                case TypesOfProduct.Gadget:
                    Gadgets gadgets = 0;
                    Gadgets typeOfGadget = ChooseTypeOfGadget(gadgets);

                    Console.WriteLine();

                    switch (typeOfGadget)
                    {
                        case Gadgets.Headphones:
                            Headphones headphones = new Headphones();

                            SetBaseCharacteristics(headphones);
                            SetNewLengthOfWire(headphones);

                            Basket.AddProduct(headphones);

                            break;
                        case Gadgets.Keyboard:
                            Keyboard keyboard = new Keyboard();

                            SetBaseCharacteristics(keyboard);
                            SetNewLengthOfWire(keyboard);

                            Basket.AddProduct(keyboard);

                            break;
                        case Gadgets.Microphone:
                            Microphone microphone = new Microphone();

                            SetBaseCharacteristics(microphone);
                            SetNewLengthOfWire(microphone);

                            Basket.AddProduct(microphone);

                            break;
                        case Gadgets.Mouse:
                            Mouse mouse = new Mouse();

                            SetBaseCharacteristics(mouse);
                            SetNewLengthOfWire(mouse);

                            Basket.AddProduct(mouse);

                            break;
                        default:
                            throw new ArgumentOutOfRangeException("Eror(typeOfGadget)");
                    }

                    break;
                case TypesOfProduct.Mobile:
                    MobileDevises mobileDevises = 0;
                    MobileDevises typeOfMobileDevises = ChooseTypeOfMobile(mobileDevises);

                    Console.WriteLine();

                    switch (typeOfMobileDevises)
                    {
                        case MobileDevises.Phone:
                            Phone phone = new Phone();

                            SetBaseCharacteristics(phone);
                            SetDeviseCharacteristics(phone);

                            SetNewBatteryCapacity(phone);
                            SetNewDisplaySize(phone);

                            Basket.AddProduct(phone);

                            break;
                        case MobileDevises.Tablet:
                            Tablet tablet = new Tablet();

                            SetBaseCharacteristics(tablet);
                            SetDeviseCharacteristics(tablet);

                            SetNewBatteryCapacity(tablet);
                            SetNewDisplaySize(tablet);

                            Basket.AddProduct(tablet);

                            break;
                        default:
                            throw new ArgumentOutOfRangeException("Eror(typeOfMobileDevises)");
                    }

                    break;
                case TypesOfProduct.PCs:
                    PCsDevises pCsDevises = 0;
                    PCsDevises typeOfPCsDevises = ChooseTypeOfPCs(pCsDevises);

                    Console.WriteLine();

                    switch (typeOfPCsDevises)
                    {
                        case PCsDevises.PC:
                            PC pC = new PC();

                            SetBaseCharacteristics(pC);
                            SetDeviseCharacteristics(pC);

                            SetNewOS(pC);
                            SetNewProcessorSpeed(pC);

                            Basket.AddProduct(pC);

                            break;
                        case PCsDevises.Laptop:
                            Laptop laptop = new Laptop();

                            SetBaseCharacteristics(laptop);
                            SetDeviseCharacteristics(laptop);

                            SetNewOS(laptop);
                            SetNewProcessorSpeed(laptop);

                            Basket.AddProduct(laptop);

                            break;
                        default:
                            throw new ArgumentOutOfRangeException("Eror(typeOfMobileDevises)");
                    }
                    break;

                default:
                    throw new ArgumentOutOfRangeException("Eror(typeOfProduct)");
            }
        }

        public void SetSomethingNew(int selectedItem = 0)
        {
            int numberInBasket = 0;

            Product product = GetProductFromBasket(out numberInBasket);

            switch (selectedItem)
            {
                case 0:
                    SetNewName(product);

                    break;
                case 1:
                    SetNewCountryAndProducer(product);

                    break;
                case 2:
                    SetNewPrice(product);

                    break;
                case 3:
                    SetNewGuarantee(product);

                    break;
                case 4:
                    SetNewColor(product);

                    break;

                case 5:
                    if (product is Gadget gadget)
                    {
                        gadget = (Gadget)Basket._products[numberInBasket];
                        SetNewLengthOfWire(gadget);
                    }
                    else
                    {
                        ChangeCollorOfSring("Eror! - this product isn't gadget", ConsoleColor.Red);
                    }

                    break;

                case 6:
                    if (product is Device device)
                    {
                        device = (Device)Basket._products[numberInBasket];
                        SetNewWage(device);
                    }
                    else
                    {
                        ChangeCollorOfSring("Eror! - this product isn't Device", ConsoleColor.Red);
                    }

                    break;

                case 7:
                    if (product is Device device2)
                    {
                        device2 = (Device)Basket._products[numberInBasket];
                        SetNewMemoryCapacity(device2);
                    }
                    else
                    {
                        ChangeCollorOfSring("Eror! - this product isn't Device", ConsoleColor.Red);
                    }

                    break;

                case 8:
                    if (product is PCs pCs)
                    {
                        pCs = (PCs)Basket._products[numberInBasket];
                        SetNewOS(pCs);
                    }
                    else
                    {
                        ChangeCollorOfSring("Eror! - this product isn't PCs", ConsoleColor.Red);
                    }

                    break;

                case 9:
                    if (product is PCs pCs2)
                    {
                        pCs2 = (PCs)Basket._products[numberInBasket];
                        SetNewProcessorSpeed(pCs2);
                    }
                    else
                    {
                        ChangeCollorOfSring("Eror! - this product isn't PCs", ConsoleColor.Red);
                    }

                    break;

                case 10:
                    if (product is Mobile mobile)
                    {
                        mobile = (Mobile)Basket._products[numberInBasket];
                        SetNewDisplaySize(mobile);
                    }
                    else
                    {
                        ChangeCollorOfSring("Eror! - this product isn't Mobile", ConsoleColor.Red);
                    }

                    break;

                case 11:
                    if (product is Mobile mobile2)
                    {
                        mobile2 = (Mobile)Basket._products[numberInBasket];
                        SetNewBatteryCapacity(mobile2);
                    }
                    else
                    {
                        ChangeCollorOfSring("Eror! - this product isn't Mobile", ConsoleColor.Red);
                    }

                    break;
                default:
                    break;
            }
        }

        private Product GetProductFromBasket(out int numberInBasket)
        {
            int num;

            Basket.ShowAllProducts();

            while (true)
            {
                ChangeCollorOfSring("Enter number of product you want to change", ConsoleColor.Cyan);
                num = int.Parse(Console.ReadLine());

                if (num > 0 && num < Basket._products.Capacity)
                {
                    numberInBasket = num - 1;

                    return Basket._products[num - 1];
                }
                else
                {
                    ChangeCollorOfSring("Num is out of the diapasone", ConsoleColor.Red);
                }
            }
        }


        //Mobile
        public void SetNewDisplaySize(Mobile mobile, double DisplaySize = 0)
        {
            while (true)
            {
                if (DisplaySize > 0 && DisplaySize <= double.MaxValue)
                {
                    mobile.DisplayInInches = DisplaySize;

                    Console.WriteLine();

                    return;
                }
                else
                {
                    ChangeCollorOfSring("Enter display size(in Inches) of product", ConsoleColor.Cyan);
                    DisplaySize = double.Parse(Console.ReadLine());
                }
            }
        }

        public void SetNewBatteryCapacity(Mobile mobile, double BatteryInMaH = 0)
        {
            while (true)
            {
                if (BatteryInMaH > 0 && BatteryInMaH <= double.MaxValue)
                {
                    mobile.BatteryInMaH = BatteryInMaH;

                    Console.WriteLine();

                    return;
                }
                else
                {
                    ChangeCollorOfSring("Enter battery capacity(in MaH) of product", ConsoleColor.Cyan);
                    BatteryInMaH = int.Parse(Console.ReadLine());
                }
            }
        }

        //PCs
        public void SetNewOS(PCs pc, OperationSystem operationSystem = 0)
        {
            if (Enum.IsDefined(typeof(OperationSystem), (int)operationSystem))
            {
                pc.OS = operationSystem;

                Console.WriteLine();

                return;
            }

            int value;

            PrintEnum(operationSystem);

            Console.WriteLine();

            while (true)
            {
                ChangeCollorOfSring("Enter operation system(number): ", ConsoleColor.Cyan);
                value = int.Parse(Console.ReadLine());

                if (Enum.IsDefined(typeof(OperationSystem), (OperationSystem)value))
                {
                    pc.OS = (OperationSystem)value;

                    Console.WriteLine();

                    return;
                }
                else
                {
                    ChangeCollorOfSring("Number is out the diapasone", ConsoleColor.Red);
                }
            }
        }

        public void SetNewProcessorSpeed(PCs pc, double ProcessorSpeed = 0)
        {
            while (true)
            {
                if (ProcessorSpeed > 0 && ProcessorSpeed <= double.MaxValue)
                {
                    pc.ProcessorSpeedInGHz = ProcessorSpeed;

                    Console.WriteLine();

                    return;
                }
                else
                {
                    ChangeCollorOfSring("Enter processor speed(in GHz) of product", ConsoleColor.Cyan);
                    ProcessorSpeed = double.Parse(Console.ReadLine());
                }
            }
        }

        //Device
        public void SetDeviseCharacteristics(Device device)
        {
            SetNewWage(device);
            SetNewMemoryCapacity(device);
        }

        public void SetNewWage(Device device, double Wage = 0)
        {
            while (true)
            {
                if (Wage > 0 && Wage <= double.MaxValue)
                {
                    device.WageInKG = Wage;

                    Console.WriteLine();

                    return;
                }
                else
                {
                    ChangeCollorOfSring("Enter wage(in KG) of product", ConsoleColor.Cyan);
                    Wage = double.Parse(Console.ReadLine());
                }
            }
        }

        public void SetNewMemoryCapacity(Device device, double Memory = 0)
        {
            while (true)
            {
                if (Memory > 0 && Memory <= double.MaxValue)
                {
                    device.MemoryinGB = Memory;

                    Console.WriteLine();

                    return;
                }
                else
                {
                    ChangeCollorOfSring("Enter memory capacity(in GB) of product", ConsoleColor.Cyan);
                    Memory = double.Parse(Console.ReadLine());
                }
            }
        }

        //Gadgets
        public void SetNewLengthOfWire(Gadget gadget, int lengthOfWire = 0)
        {
            while (true)
            {
                if (lengthOfWire > 0 && lengthOfWire <= int.MaxValue)
                {
                    gadget.LengthOfWireInCM = lengthOfWire;

                    Console.WriteLine();

                    return;
                }
                else
                {
                    ChangeCollorOfSring("Enter wire length(in CM) of product", ConsoleColor.Cyan);
                    lengthOfWire = int.Parse(Console.ReadLine());
                }
            }
        }

        //Types
        private TypesOfProduct ChooseTypeOfProduct(TypesOfProduct typesOfProduct = 0)
        {
            if (Enum.IsDefined(typeof(TypesOfProduct), (int)typesOfProduct))
            {
                return typesOfProduct;
            }

            int value;

            PrintEnum(typesOfProduct);

            Console.WriteLine();

            while (true)
            {
                ChangeCollorOfSring("Enter type(number) of product: ", ConsoleColor.DarkCyan);
                value = int.Parse(Console.ReadLine());

                if (Enum.IsDefined(typeof(TypesOfProduct), value))
                {
                    return (TypesOfProduct)value;
                }
                else
                {
                    ChangeCollorOfSring("Number is out the diapasone", ConsoleColor.Red);
                }
            }
        }

        private Gadgets ChooseTypeOfGadget(Gadgets gadgets = 0)
        {
            if (Enum.IsDefined(typeof(Gadgets), (int)gadgets))
            {
                return gadgets;
            }

            int value;

            PrintEnum(gadgets);

            Console.WriteLine();

            while (true)
            {
                ChangeCollorOfSring("Enter type(number) of gadget: ", ConsoleColor.DarkCyan);
                value = int.Parse(Console.ReadLine());

                if (Enum.IsDefined(typeof(Gadgets), value))
                {
                    return (Gadgets)value;
                }
                else
                {
                    ChangeCollorOfSring("Number is out the diapasone", ConsoleColor.Red);
                }
            }
        }

        private PCsDevises ChooseTypeOfPCs(PCsDevises pCsDevises = 0)
        {
            if (Enum.IsDefined(typeof(PCsDevises), (int)pCsDevises))
            {
                return pCsDevises;
            }

            int value;

            PrintEnum(pCsDevises);

            Console.WriteLine();

            while (true)
            {
                ChangeCollorOfSring("Enter type(number) of PCs: ", ConsoleColor.DarkCyan);
                value = int.Parse(Console.ReadLine());

                if (Enum.IsDefined(typeof(PCsDevises), value))
                {
                    return (PCsDevises)value;
                }
                else
                {
                    ChangeCollorOfSring("Number is out the diapasone", ConsoleColor.Red);
                }
            }
        }

        private MobileDevises ChooseTypeOfMobile(MobileDevises mobileDevises = 0)
        {
            if (Enum.IsDefined(typeof(MobileDevises), (int)mobileDevises))
            {
                return mobileDevises;
            }

            int value;

            PrintEnum(mobileDevises);

            Console.WriteLine();

            while (true)
            {
                ChangeCollorOfSring("Enter type(number) of mobile device: ", ConsoleColor.DarkCyan);
                value = int.Parse(Console.ReadLine());

                if (Enum.IsDefined(typeof(MobileDevises), value))
                {
                    return (MobileDevises)value;
                }
                else
                {
                    ChangeCollorOfSring("Number is out the diapasone", ConsoleColor.Red);
                }
            }
        }

        //Default characteristics
        public void SetBaseCharacteristics(Product product)
        {
            SetNewName(product);
            SetNewCountryAndProducer(product);
            SetNewPrice(product);
            SetNewGuarantee(product);
            SetNewColor(product);
        }

        public void SetNewColor(Product product, Color color = 0)
        {
            if (Enum.IsDefined(typeof(Color), (int)color))
            {
                product.Color = color;

                Console.WriteLine();

                return;
            }

            int value;

            PrintEnum(color);

            while (true)
            {
                ChangeCollorOfSring("Enter color of product(number)", ConsoleColor.Cyan);
                value = int.Parse(Console.ReadLine());

                if (Enum.IsDefined(typeof(Color), value))
                {
                    product.Color = (Color)value;

                    Console.WriteLine();

                    return;
                }
                else
                {
                    ChangeCollorOfSring("Number is out the diapasone", ConsoleColor.Red);
                }
            }
        }

        public void SetNewGuarantee(Product product, int timeOfGuaranteeInDays = -1)
        {
            while (true)
            {
                if (timeOfGuaranteeInDays >= 0 && timeOfGuaranteeInDays <= int.MaxValue)
                {
                    product.TimeOfGuaranteeInDays = timeOfGuaranteeInDays;

                    Console.WriteLine();

                    return;
                }
                else
                {
                    ChangeCollorOfSring("Enter guarantee of product", ConsoleColor.Cyan);
                    timeOfGuaranteeInDays = int.Parse(Console.ReadLine());
                }
            }
        }

        public void SetNewPrice(Product product, int price = 0)
        {
            while (true)
            {
                if (price > 0 && price <= int.MaxValue)
                {
                    product.Price = price;

                    Console.WriteLine();

                    return;
                }
                else
                {
                    ChangeCollorOfSring("Enter price of product", ConsoleColor.Cyan);
                    price = int.Parse(Console.ReadLine());
                }
            }
        }

        public void SetNewCountryAndProducer(Product product, Country country = 0)
        {
            if (Enum.IsDefined(typeof(Country), (int)country))
            {
                product.Country = country;

                product.SetNewProducer();

                Console.WriteLine();

                return;
            }

            int value;

            PrintEnum(country);

            while (true)
            {
                ChangeCollorOfSring("Enter country(number)", ConsoleColor.Cyan);
                value = int.Parse(Console.ReadLine());

                if (Enum.IsDefined(typeof(Country), value))
                {
                    product.Country = (Country)value;

                    product.SetNewProducer();

                    Console.WriteLine();

                    return;
                }
                else
                {
                    ChangeCollorOfSring("Number is out the diapasone", ConsoleColor.Red);
                }
            }
        }

        public void SetNewName(Product product, string name = "\0")
        {
            while (true)
            {
                if (name != "\0" && name.Length >= 3)
                {
                    product.Name = name;

                    Console.WriteLine();

                    return;
                }
                else
                {
                    ChangeCollorOfSring("Enter name of product", ConsoleColor.Cyan);
                    name = Console.ReadLine();
                }
            }
        }


        private void PrintEnum(Enum @enum)
        {
            var parameters = Enum.GetValues(@enum.GetType());

            //{@enum.GetType().Name}

            foreach (var item in parameters)
            {
                ChangeCollorOfSring($"{Convert.ToInt32(item)}: {item}", ConsoleColor.Yellow);
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

