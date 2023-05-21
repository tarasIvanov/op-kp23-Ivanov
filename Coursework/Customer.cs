namespace Computer_Shop
{
    class Customer
    {
        public string Name { get; private set; }
        public int SumOfMoney { get; private set; }

        private List<Product> _BoughtProducts;
        private int _numOfBoughtProducts;

        public void ShowBouhtProducts();


        public void BuyProduct();

        public void ReturnProduct();

        public void SearchingBy(int selectedItem);

        public void PCsSupportGTA5();

        public void MobileSupportPUBG();


        public void ShowCustomerInfo();

        public void SetCustomerInfo();

        
        private Product GetProductForBying();

        private Product GetProductForReturning();


        private int GetPriceOfProduct();

        private Country GetCountryOfProduct();

        private Producer GetProducerOfProduct();

        private Color GetColorOfProduct();

        private TypesOfProduct GetTypeOfProduct();

    }
}

