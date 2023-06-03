using System;
namespace Computer_Shop
{
	class UnitTest
	{
        public void CheckAllTests()
        {
            if (!TestIsGoodForGTA())
            {
                throw new Exception("Eror - TestIsGoodForGTA");
            }

            if (!TestIsGoodForPUBG())
            {
                throw new Exception("Eror - TestIsGoodForPUBG");
            }
        }

		public bool TestIsGoodForGTA()
		{
			bool expectedRes1 = false;
            bool expectedRes2 = true;

            PC pc1 = new PC(new PCsDTO("Compucter007", Country.Poland, 2000, 90, Color.Black, 5.3, 480, OperationSystem.MacOC, 1.5));

            Laptop laptop2 = new Laptop(new PCsDTO("The best PC", Country.Netherlands, 3500, 120, Color.Green, 4, 1024, OperationSystem.Windows, 3));

			if (pc1.IsGoodForGTA5() == expectedRes1 && laptop2.IsGoodForGTA5() == expectedRes2)
			{
				return true;
			}
			else
			{
				return false;
			}
        }

        public bool TestIsGoodForPUBG()
        {
            bool expectedRes1 = false;
            bool expectedRes2 = true;

            Phone phone1 = new Phone(new MobileDTO("IphoneSE", Country.German, 1000, 50, Color.Yellow, 0.4, 32, 4, 1600));

            Phone phone2 = new Phone(new MobileDTO("The best Mobile ever been", Country.England, 2500, 150, Color.Yellow, 1.6, 516, 5, 4500));

            if (phone1.IsGoodForPubg() == expectedRes1 && phone2.IsGoodForPubg() == expectedRes2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

