using lab1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTestLab1
{
    [TestClass]
    public class PersonalComputerTests
    {
        private PersonalComputer _personalComputer;

        [TestInitialize]
        public void Setup()
        {
            _personalComputer = new PersonalComputer();
        }

        [TestMethod]
        public void DefaultConstructor_ShouldInitializeWithDefaultValues()
        {
            Assert.AreEqual("Неизвестный", _personalComputer.GetBrand());
            Assert.AreEqual("Неизвестный", _personalComputer.GetCpuBrand());
            Assert.AreEqual(0, _personalComputer.GetRam());
            Assert.AreEqual(0, _personalComputer.GetPrice());
            Assert.AreEqual(0, _personalComputer.GetWeight());
        }

        [TestMethod]
        public void ParameterizedConstructor_ShouldInitializeWithGivenValues()
        {
            var personalComputer = new PersonalComputer("Dell", "Intel", 16, 1200, 22);

            Assert.AreEqual("Dell", personalComputer.GetBrand());
            Assert.AreEqual("Intel", personalComputer.GetCpuBrand());
            Assert.AreEqual(16, personalComputer.GetRam());
            Assert.AreEqual(1200, personalComputer.GetPrice());
            Assert.AreEqual(22, personalComputer.GetWeight());
        }

        [TestMethod]
        public void SetBrand_ShouldUpdateBrand()
        {
            _personalComputer.SetBrand("HP");
            Assert.AreEqual("HP", _personalComputer.GetBrand());
        }

        [TestMethod]
        public void SetCpuBrand_ShouldUpdateCpuBrand()
        {
            _personalComputer.SetCpuBrand("AMD");
            Assert.AreEqual("AMD", _personalComputer.GetCpuBrand());
        }

        [TestMethod]
        public void SetRam_ShouldUpdateRam()
        {
            _personalComputer.SetRam(32);
            Assert.AreEqual(32, _personalComputer.GetRam());
        }

        [TestMethod]
        public void SetPrice_ShouldUpdatePrice()
        {
            _personalComputer.SetPrice(1500);
            Assert.AreEqual(1500, _personalComputer.GetPrice());
        }

        [TestMethod]
        public void SetBattery_ShouldUpdateBattery()
        {
            _personalComputer.SetWeight(5);
            Assert.AreEqual(5, _personalComputer.GetWeight());
        }
    }
}
