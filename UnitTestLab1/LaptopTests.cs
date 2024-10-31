using lab1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTestLab1
{
    [TestClass]
    public class LaptopTests
    {
        private Laptop _laptop;

        [TestInitialize]
        public void Setup()
        {
            _laptop = new Laptop();
        }

        [TestMethod]
        public void DefaultConstructor_ShouldInitializeWithDefaultValues()
        {
            Assert.AreEqual("Неизвестный", _laptop.GetBrand());
            Assert.AreEqual("Неизвестный", _laptop.GetCpuBrand());
            Assert.AreEqual(0, _laptop.GetRam());
            Assert.AreEqual(0, _laptop.GetPrice());
            Assert.AreEqual(0, _laptop.GetBattery());
        }

        [TestMethod]
        public void ParameterizedConstructor_ShouldInitializeWithGivenValues()
        {
            var laptop = new Laptop("Dell", "Intel", 16, 1200, 4500);

            Assert.AreEqual("Dell", laptop.GetBrand());
            Assert.AreEqual("Intel", laptop.GetCpuBrand());
            Assert.AreEqual(16, laptop.GetRam());
            Assert.AreEqual(1200, laptop.GetPrice());
            Assert.AreEqual(4500, laptop.GetBattery());
        }

        [TestMethod]
        public void SetBrand_ShouldUpdateBrand()
        {
            _laptop.SetBrand("HP");
            Assert.AreEqual("HP", _laptop.GetBrand());
        }

        [TestMethod]
        public void SetCpuBrand_ShouldUpdateCpuBrand()
        {
            _laptop.SetCpuBrand("AMD");
            Assert.AreEqual("AMD", _laptop.GetCpuBrand());
        }

        [TestMethod]
        public void SetRam_ShouldUpdateRam()
        {
            _laptop.SetRam(32);
            Assert.AreEqual(32, _laptop.GetRam());
        }

        [TestMethod]
        public void SetPrice_ShouldUpdatePrice()
        {
            _laptop.SetPrice(1500);
            Assert.AreEqual(1500, _laptop.GetPrice());
        }

        [TestMethod]
        public void SetBattery_ShouldUpdateBattery()
        {
            _laptop.SetBattery(5500);
            Assert.AreEqual(5500, _laptop.GetBattery());
        }
    }
}
