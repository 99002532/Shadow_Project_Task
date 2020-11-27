//using Microsoft.IdentityModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyApplication;
using KeyGen;

namespace UnitTestProject1
{
    [TestClass]
    public class Tests
    {

        [TestMethod]
         public void SizeRun()
        {
            int size = 0;

            for (size = 1; size <=1; size++)
            {
                switch (size)
                {
                    case 1:
                        RandomKey_Running_1();
                        break;
                    case 2:
                        RandomKey_Running_2();
                        break;
                    case 3:
                        RandomKey_Running_3();
                        break;
                    case 4:
                        RandomKey_Running_4();
                        break;
                    case 5:
                        RandomKey_Running_5();
                        break;
                    case 6:
                        RandomKey_Running_6();
                        break;
                    case 7:
                        RandomKey_Running_7();
                        break;
                    case 8:
                        RandomKey_Running_8();
                        break;
                }

            }
        }
        [TestMethod]
        public void RandomKey_Running_1()
        {
            int min = 1;
            int max = 10;
            KeyGenerator KeyObj = new KeyGenerator();

            int ActualVal = KeyObj.RandomKey(min, max);

            Assert.IsTrue(ActualVal >= 1 && ActualVal < 10);

        }

        [TestMethod]
        public void RandomKey_Running_2()
        {
            int min = 10;
            int max = 100;
            KeyGenerator KeyObj = new KeyGenerator();

            int ActualVal = KeyObj.RandomKey(min, max);

            Assert.IsTrue(ActualVal >= 10 && ActualVal < 100);

        }

        [TestMethod]
        public void RandomKey_Running_3()
        {
            int min = 100;
            int max = 1000;
            KeyGenerator KeyObj = new KeyGenerator();

            int ActualVal = KeyObj.RandomKey(min, max);

            Assert.IsTrue(ActualVal >= 100 && ActualVal < 1000);

        }
        [TestMethod]
        public void RandomKey_Running_4()
        {
            int min = 1000;
            int max = 10000;
            KeyGenerator KeyObj = new KeyGenerator();

            int ActualVal = KeyObj.RandomKey(min, max);

            Assert.IsTrue(ActualVal >= 1000 && ActualVal < 10000);

        }
        [TestMethod]
        public void RandomKey_Running_5()
        {
            int min = 10000;
            int max = 100000;
            KeyGenerator KeyObj = new KeyGenerator();

            int ActualVal = KeyObj.RandomKey(min, max);

            Assert.IsTrue(ActualVal >= 10000 && ActualVal < 100000);

        }

        [TestMethod]
        public void RandomKey_Running_6()
        {
            int min = 100000;
            int max = 1000000;
            KeyGenerator KeyObj = new KeyGenerator();

            int ActualVal = KeyObj.RandomKey(min, max);

            Assert.IsTrue(ActualVal >= 100000 && ActualVal < 1000000);

        }

        [TestMethod]
        public void RandomKey_Running_7()
        {
            int min = 10000000;
            int max = 100000000;
            KeyGenerator KeyObj = new KeyGenerator();

            int ActualVal = KeyObj.RandomKey(min, max);

            Assert.IsTrue(ActualVal >= 10000000 && ActualVal < 100000000);

        }
        [TestMethod]
        public void RandomKey_Running_8()
        {
            int min = 100000000;
            int max = 1000000000;
            KeyGenerator KeyObj = new KeyGenerator();

            int ActualVal = KeyObj.RandomKey(min, max);

            Assert.IsTrue(ActualVal >= 100000000 && ActualVal < 1000000000);

        }
     



    }
}
